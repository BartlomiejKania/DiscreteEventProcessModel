﻿using PresentationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscreteEventProcessModel
{
    public partial class Form1 : Form
    {
        private List<SimulationData> mSimulationData = new List<SimulationData>();
        List<Company> mCompanies;
        List<Funcionality> mFunctionalities;

        public List<Funcionality> WordPressFunctionalities
        {
            get;
            private set;
        }

        public List<Funcionality> JoomlaFunctionalities
        {
            get;
            set;
        }

        public List<Funcionality> DrupalFunctionalities
        {
            get;
            set;
        }

        public Form1()
        {
            InitializeComponent();
            this.newDataGridView1.ListBoxCollection[0].DoubleClick +=
                new EventHandler(ListBox1_DoubleClick);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            FillCompaniesFunctionalities();
            Algorithm1 algorithm1 = new Algorithm1(mCompanies, mFunctionalities);
            algorithm1.Run();
        }

        private void ParseFuncionalityAndFillCompanies(String line)
        {
            string[] splittedVersion = line.Split(':');
            string description = splittedVersion[0];

            Funcionality functionality = new Funcionality(description);
            mFunctionalities.Add(functionality);

            for (int i = 0; i < mCompanies.Count; i++)
            {
                mCompanies[i].addRequiredFuncionalityWithCost(functionality, 0);
            }
        }

        private void loadDatabutton_Click(object sender, EventArgs e)
        {
            string dataPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\CmsData.txt";
            string[] rawVersions = File.ReadAllLines(dataPath, Encoding.UTF8);
            
            int numberOfCompanies = 3;
            mCompanies = new List<Company>(numberOfCompanies);

            for (int i = 0; i < numberOfCompanies; i++)
            {
                mCompanies.Add(new Company());
            }

            mFunctionalities = new List<Funcionality>(rawVersions.Count() - 1);
            List<string> descriptions = new List<string>();

            foreach (string line in rawVersions.Where(l => !String.IsNullOrEmpty(l)))
            {
                ParseFuncionalityAndFillCompanies(line);
                string[] splittedVersion = line.Split(':');
                string description = splittedVersion.First();
                int wordPressCost = int.Parse(splittedVersion[1]);
                int joomlaCost = int.Parse(splittedVersion[2]);
                int drupalCost = int.Parse(splittedVersion[3]);
                List<string> dependsOn = splittedVersion[4].Split(';').ToList();
                SimulationData data = new SimulationData(description, wordPressCost,
                    joomlaCost, drupalCost, dependsOn);
                mSimulationData.Add(data);
                descriptions.Add(description);
            }

            newDataGridView1.DataSource = mSimulationData;
            newListBox4.Items.AddRange(descriptions.ToArray());

            loadDatabutton.Enabled = false;
            startButton.Enabled = true;
        }

        private void FillCompaniesFunctionalities()
        {
            WordPressFunctionalities = new List<Funcionality>();
            JoomlaFunctionalities = new List<Funcionality>();
            DrupalFunctionalities = new List<Funcionality>();

            foreach (SimulationData data in mSimulationData)
            {
                WordPressFunctionalities.Add(new Funcionality(data.Functionality, data.WordPressCost, data.DependensOn));
                JoomlaFunctionalities.Add(new Funcionality(data.Functionality, data.JoomlaCost, data.DependensOn));
                DrupalFunctionalities.Add(new Funcionality(data.Functionality, data.DrupalCost, data.DependensOn));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.loadDatabutton_Click(null, null);
            //this.startButton_Click(null, null);
        }
        int rowIndex, columnIndex;

        /// <summary>
        /// When ListBox is double clicked, called this method.
        /// Add select item of ListBox into appropriate cell of the DataGridView.
        /// After then hide ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            this.newDataGridView1[columnIndex, rowIndex].Value =
                this.newDataGridView1.ListBoxCollection[0].SelectedItem.ToString();

            this.newDataGridView1.ListBoxCollection[0].Visible = false;
        }

        /// <summary>
        /// Get row index and column index of selected cell of the DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newDataGridView1_CellEnter
        (object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            columnIndex = e.ColumnIndex;
        }
    }
}
