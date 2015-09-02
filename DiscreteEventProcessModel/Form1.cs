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
        List<Funcionality> mFunctionalities;
        List<Company> mCompanies;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
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
                int costForCompany = int.Parse(splittedVersion[i + 1].Replace(";",""));

                mCompanies[i].addRequiredFuncionalityWithCost(functionality, costForCompany);
            }
        }

        private void loadDatabutton_Click(object sender, EventArgs e)
        {
            string dataPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\CmsData.txt";
            string[] rawVersions = File.ReadAllLines(dataPath, Encoding.UTF8);
            
            int numberOfCompnies = int.Parse(rawVersions.First());
            mCompanies = new List<Company>(numberOfCompnies);

            for (int i = 0; i < numberOfCompnies; i++)
            {
                mCompanies.Add(new Company());
            }

            mFunctionalities = new List<Funcionality>(rawVersions.Count() - 1);

            foreach (var line in rawVersions.Skip(1))
            {
                ParseFuncionalityAndFillCompanies(line);
            }

            dataGridView1.DataSource = mFunctionalities;
            loadDatabutton.Enabled = false;
            startButton.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadDatabutton_Click(null, null);
            this.startButton_Click(null, null);
        }
    }
}
