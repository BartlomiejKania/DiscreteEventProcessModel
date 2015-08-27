using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Algorithm1
    {
        private Automation automation;

        public Algorithm1(Automation automation)
        {
            this.automation = automation;
        }

        public void Run()
        {
            DecomposeStates();
            ComputeCriteria();
            AlgorithmLoop();
        }

        private void DecomposeStates()
        {
            throw new NotImplementedException();
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
