using PresentationControls;
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
        List<Company> mCompanies = new List<Company>();
        List<Funcionality> mFunctionalities = new List<Funcionality>();

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
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Algorithm1 algorithm1 = new Algorithm1(mCompanies, mFunctionalities);
            algorithm1.Run();

            //mCompanies[i].Name
            //mCompanies[i].OrderOfFunctionalitiesImplementationWithCosts
        }

        private void loadDatabutton_Click(object sender, EventArgs e)
        {
            string dataPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\CmsData.txt";
            string[] rawVersions = File.ReadAllLines(dataPath, Encoding.UTF8);
            List<string> descriptions = new List<string>();

            foreach (string line in rawVersions.Where(l => !String.IsNullOrEmpty(l)))
            {
                string[] splittedVersion = line.Split(':');
                string description = splittedVersion.First();
                int wordPressCost = int.Parse(splittedVersion[1]);
                int joomlaCost = int.Parse(splittedVersion[2]);
                int drupalCost = int.Parse(splittedVersion[3]);
                string marketReaction = splittedVersion[4];
                SimulationData data = new SimulationData(description, wordPressCost,
                    joomlaCost, drupalCost, marketReaction);
                mSimulationData.Add(data);
                descriptions.Add(description);
            }

            FillCompaniesFunctionalities();

            dataGridView1.DataSource = mSimulationData;
            newListBox4.Items.AddRange(descriptions.ToArray());

            loadDatabutton.Enabled = false;
            startButton.Enabled = true;
        }

        private void FillCompaniesFunctionalities()
        {
            int numberOfCompanies = 3;
            List<String> companyNames = new List<String>{"WordPress", "Joomla", "Drupal"};

            for (int i = 0; i < numberOfCompanies; i++)
            {
                mCompanies.Add(new Company());
                mCompanies[i].Name = companyNames[i];
            }

            foreach (SimulationData data in mSimulationData)
            {
                Funcionality func = new Funcionality(data.Functionality, data.MarketReaction);

                mCompanies[0].addRequiredFuncionalityWithCost(func, data.WordPressCost);
                mCompanies[1].addRequiredFuncionalityWithCost(func, data.JoomlaCost);
                mCompanies[2].addRequiredFuncionalityWithCost(func, data.DrupalCost);

                mFunctionalities.Add(func);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.loadDatabutton_Click(null, null);
            //this.startButton_Click(null, null);
        }
    }
}
