using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Automation
    {
        public Collection<State> States
        {
            get;
            private set;
        }

        public Collection<Operation> Operations
        {
            get;
            set;
        }

        public Function StateTransitionFunction
        {
            get;
            set;
        }

        public Collection<State> InitialStates
        {
            get;
            set;
        }

        public Collection<State> FinalStates
        {
            get;
            set;
        }

        public Automation(string dataPath)
        {
            string[] rawVersions = File.ReadAllLines(dataPath);
            GenerateStates(rawVersions);
        }

        private void GenerateStates(string[] versions)
        {
            States = new Collection<State>();
            List<string> descriptions = GetDescriptions(versions);

            foreach (string description in descriptions)
            {
                State state = new State(description);
                States.Add(state);
            }
        }

        private static List<string> GetDescriptions(string[] versions)
        {
            List<string> descriptions = new List<string>();

            foreach (string version in versions)
            {
                string[] splittedVersion = version.Split(':');
                string description = splittedVersion.First();
                descriptions.Add(description);
            }

            return descriptions;
        }
    }
}
