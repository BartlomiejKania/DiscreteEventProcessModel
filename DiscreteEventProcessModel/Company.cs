using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Company
    {
        public Dictionary<Funcionality, int> mFunctionalities = new Dictionary<Funcionality, int>();
        private Funcionality mCurrentlyDevelopedFuncionality;

        public enum CompanyState
        {
            Idle,
            ProccessingFunctionality,
            DoneAllFunctionalities
        }

        public String Name { get; set; }
        public CompanyState State { get; set; }
        public int TimeToDevelopNextFunctionality { get; set; }
        public List<Funcionality> ImplementedFunctionalites { get; set; }
        public List<Funcionality> MissingFunctionalities
        {
            get
            {
                return mFunctionalities.Keys.Except(ImplementedFunctionalites).ToList();
            }
        }
        public List<Tuple<Funcionality, int>> OrderOfFunctionalitiesImplementationWithCosts { get; private set; }

        public Company()
        {
            //this.TimeToDevelopNextFunctionality = int.MaxValue;
            this.State = CompanyState.Idle;
            this.ImplementedFunctionalites = new List<Funcionality>();
        }

        public void addRequiredFuncionalityWithCost(Funcionality func, int functionalityCost)
        {
            mFunctionalities.Add(func, functionalityCost);
        }

        public int functionalityCost(Funcionality func)
        {
            return mFunctionalities[func];
        }

        public void developFunctionality(Funcionality func)
        {
            mCurrentlyDevelopedFuncionality = func;
            TimeToDevelopNextFunctionality = mFunctionalities[func];
            State = CompanyState.ProccessingFunctionality;
        }

        public void finishDevelopFuncionality()
        {
            ImplementedFunctionalites.Add(mCurrentlyDevelopedFuncionality);

            mCurrentlyDevelopedFuncionality = null;
            TimeToDevelopNextFunctionality = int.MaxValue;

            State = MissingFunctionalities.Count == 0 ? CompanyState.DoneAllFunctionalities : CompanyState.Idle;

            if (State == CompanyState.DoneAllFunctionalities) {
                OrderOfFunctionalitiesImplementationWithCosts = ImplementedFunctionalites.Select(func => new Tuple<Funcionality, int>(func, mFunctionalities[func])).ToList();
            }
        }
    }
}
