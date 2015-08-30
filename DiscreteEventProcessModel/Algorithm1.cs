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
        private Variations<State> variations;
        private State initialState;
        private uint iterator;

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
            Collection<State> states = automation.States;
            initialState = automation.States.First();
            iterator = 2;
            states.Remove(initialState);
            variations = new Variations<State>(states, states.Count);
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
