using Facet.Combinatorics;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Algorithm1
    {
        private Automation automation;
        private List<Path> Paths;
        private List<Path> ReducedNetwork;
        private int iterator;
        private Path SupervisorTrajectory;

        public Algorithm1(Automation automation)
        {
            this.automation = automation;
        }

        public void Run()
        {
            DecomposeStatesToLevelSets();
            SetSuperVisorTrajectory();
            ComputeCriteria();
            AlgorithmLoop();
        }

        private void DecomposeStatesToLevelSets()
        {
            List<State> states = automation.States.ToList();
            iterator = 1;
            Paths = new List<Path>();

            foreach(var state in states)
            {
                AddAllPaths(states, state);
            }

            State finalState = states.Last();
            finalState.FinalState = true;
            Paths.Add(new Path(new List<State> { finalState }));

            foreach (var stateSet in Paths)
            {
                stateSet.Trajectory.Add(finalState);
            }
        }

        private void AddAllPaths(List<State> states, State state)
        {
            var states2 = states.Where(s => state.Functionalities.All(f => s.Functionalities.Contains(f)) &&
            state != s && s.Functionalities.Count > state.Functionalities.Count);
            foreach (var state2 in states2)
            {
                List<State> fullPath = new List<State>();
                fullPath.Add(state);
                AddState(state2, state, fullPath);
                Paths.Add(new Path(fullPath));
            }
        }

        private void AddState(State bState, State state, List<State> fullPath)
        {
            fullPath.Add(bState);

            if (bState.Functionalities.Count == automation.FunctionalitiesCount ||
                (state != null && bState == state))
            {
                return;
            }

            State nextState = automation.States.First(s => s != bState &&
            bState.Functionalities.All(f => s.Functionalities.Contains(f)) &&
            s.Functionalities.Count > bState.Functionalities.Count);
            AddState(nextState, bState, fullPath);
        }

        private void SetSuperVisorTrajectory()
        {
            SupervisorTrajectory = Paths.First();
        }

        private void ComputeCriteria()
        {
            foreach(var path in Paths)
            {
                State firstState = path.Trajectory.ElementAt(0);
                int functionalitiesCount = firstState.Functionalities.Count;
                int cost = 0;

                foreach(var funcionality in firstState.Functionalities)
                {
                    cost += automation.Functionalities.First(f => f.Description == funcionality).Cost;
                }

                //path.IncreaseCost(cost*)
            }
        }

        private void AlgorithmLoop()
        {
            FindAllowedTransitions();
            Step4i();
            ChooseLeastDistance();
            CheckStopCriterium();
        }

        private void FindAllowedTransitions()
        {
            State supervisorState = SupervisorTrajectory.Trajectory.ElementAt(iterator);
            ReducedNetwork = new List<Path>();
            foreach (var stateSet in Paths)
            {
                State nextState = stateSet.Trajectory.ElementAt(1);

                if (supervisorState.Functionalities.All(f => nextState.Functionalities.Contains(f)))
                {
                    ReducedNetwork.Add(stateSet);
                }
            }
        }

        private void Step4i()
        {
            throw new NotImplementedException();
        }

        private void ChooseLeastDistance()
        {
            throw new NotImplementedException();
        }

        private void CheckStopCriterium()
        {
            throw new NotImplementedException();
        }
    }
}
