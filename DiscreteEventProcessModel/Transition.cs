namespace DiscreteEventProcessModel
{
    public class Transition
    {
        public State BaseState
        {
            get;
            private set;
        }

        public State TargetState
        {
            get;
            private set;
        }

        public Transition(State baseState, State targetState)
        {
            BaseState = baseState;
            TargetState = targetState;
        }
    }
}