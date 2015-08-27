namespace DiscreteEventProcessModel
{
    public class State
    {
        public string[] Functionalities
        {
            get;
            private set;
        }

        public State(string[] functionalities)
        {
            Functionalities = functionalities;
        }
    }
}