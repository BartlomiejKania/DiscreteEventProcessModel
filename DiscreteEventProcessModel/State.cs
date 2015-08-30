namespace DiscreteEventProcessModel
{
    public class State
    {
        public string Functionality
        {
            get;
            private set;
        }

        public State(string functionality)
        {
            Functionality = functionality;
        }
    }
}