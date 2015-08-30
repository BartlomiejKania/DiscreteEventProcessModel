using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DiscreteEventProcessModel
{
    public class State
    {
        public HashSet<string> Functionalities
        {
            get;
            private set;
        }

        public State(Collection<string> functionalities)
        {
            Functionalities = new HashSet<string>(functionalities);
        }
    }
}