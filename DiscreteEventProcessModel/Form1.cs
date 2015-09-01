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
        List<Funcionality> data = new List<Funcionality>();

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Automation automation = new Automation(data);
            Algorithm1 algorithm1 = new Algorithm1(automation);
            algorithm1.Run();
        }

        private void loadDatabutton_Click(object sender, EventArgs e)
        {
            string dataPath = Directory.GetCurrentDirectory() + "\\..\\..\\..\\CmsData.txt";
            string[] rawVersions = File.ReadAllLines(dataPath);
            var descriptions = GetDescriptions(rawVersions);

            foreach (var description in descriptions)
            {
                var func = new Funcionality(description);
                data.Add(func);
            }
            
            dataGridView1.DataSource = data;
            loadDatabutton.Enabled = false;
            startButton.Enabled = true;
        }

        private List<string> GetDescriptions(string[] versions)
        {
            List<string> descriptions = new List<string>();

            foreach (string version in versions.Where(v => !string.IsNullOrEmpty(v)))
            {
                string[] splittedVersion = version.Split(':');
                string description = splittedVersion.First();
                descriptions.Add(description);
            }

            return descriptions;
        }
    }
}
