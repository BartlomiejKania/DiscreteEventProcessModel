using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            set;
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

        public Automation()
        {
        }
    }
}
