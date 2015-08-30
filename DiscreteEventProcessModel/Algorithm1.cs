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
        private List<List<State>> StateSets;
        private int iterator;

        public Algorithm1(Automation automation)
        {
            this.automation = automation;
        }

        public void Run()
        {
            DecomposeStatesToVariationSets();
            ComputeCriteria();
            AlgorithmLoop();
        }

        private void DecomposeStatesToVariationSets()
        {
            List<State> states = automation.States.ToList();
            iterator = 2;
            StateSets = new List<List<State>>();

            foreach(var state in states)
            {
                AddAllPaths(states, state);
            }

            StateSets.Add(new List<State> { states.Last() });
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
                StateSets.Add(fullPath);
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

        private void ComputeCriteria()
        {
            throw new NotImplementedException();
        }

        private void AlgorithmLoop()
        {
            FindTransitions();
            FindTheCharacteristics();
            ChooseLeastDistance();
            CheckStopCriterium();
        }

        private void FindTransitions()
        {
            throw new NotImplementedException();
        }

        private void FindTheCharacteristics()
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
