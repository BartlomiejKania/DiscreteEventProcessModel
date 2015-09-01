using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Path
    {
        public List<State> Trajectory
        {
            get;
            private set;
        }

        public int ActualCost
        {
            get;
            private set;
        }

        public Path(List<State> trajectory)
        {
            Trajectory = trajectory;
            ActualCost = 0;
        }

        public void IncreaseCost(int cost)
        {
            ActualCost += cost;
        }
    }
}
