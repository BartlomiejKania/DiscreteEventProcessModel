using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Company
    {
        public List<Funcionality> mImplementedFunctionalites = new List<Funcionality>();
        private Dictionary<Funcionality, int> mFunctionalities = new Dictionary<Funcionality, int>();

        public Company()
        {
        }

        public void addRequiredFuncionalityWithCost(Funcionality func, int functionalityCost)
        {
            mFunctionalities.Add(func, functionalityCost);
        }
    }
}
