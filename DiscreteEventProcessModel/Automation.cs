using Facet.Combinatorics;
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
        public State InitialState;
        public int FunctionalitiesCount;

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

        public Collection<Transition> Transitions
        {
            get;
            private set;
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

        public List<Funcionality> Functionalities
        {
            get;
            private set;
        }

        public List<string> Descriptions
        {
            get;
            private set;
        }

        public Automation(List<Funcionality> funcionalities)
        {
            Functionalities = funcionalities;
            Descriptions = funcionalities.Select(f => f.Description).ToList();
            GenerateStates();
            GenerateTransitions();
        }

        private void GenerateStates()
        {
            List<State> states = new List<State>();
            FunctionalitiesCount = Descriptions.Count - 1;

            string initialDescription = Descriptions.First();
            InitialState = new State(new Collection<string> { initialDescription });
            Descriptions.Remove(initialDescription);

            for (int i = 1; i <Descriptions.Count + 1; i++)
            {
                Variations<string> v = new Variations<string>(Descriptions, i);

                foreach(var variation in v)
                {
                    State state = new State(new Collection<string>(variation));
                    states.Add(state);
                }
            }

            States = new Collection<State>();

            foreach (var state in states)
            {
                if (!States.Any(s => state.Functionalities.All(f => s.Functionalities.Contains(f))))
                {
                    States.Add(state);
                }
            }
        }

        private void GenerateTransitions()
        {
            Transitions = new Collection<Transition>();

            foreach (State state in States)
            {
                List<State> possibleNextStates = States.Where(
                    s => state.Functionalities.All(f => s.Functionalities.Contains(f)) &&
                    state != s).ToList();

                foreach (var possibleNextState in possibleNextStates)
                {
                    Transition transition = new Transition(state, possibleNextState);
                    Transitions.Add(transition);
                }
            }
        }
    }
}
