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
        private IEnumerable<Company> mAllComapnies;
        private IEnumerable<Funcionality> mAllFunctionalities;

        private List<int> A; //No idea what should conatins this array
        private List<int> B; //No idea what should conatins this array
        private List<int> C; //No idea what should conatins this array

        public Algorithm1(IEnumerable<Company> allCompanies, IEnumerable<Funcionality> allFunctionalities)
        {
            mAllComapnies = allCompanies;
            mAllFunctionalities = allFunctionalities;
        }

        public void Run()
        {
            //Step1(); //Decomposition doesn't needed
            //Step2(); //Criteria are determined in the input data

            while (Step6())
            {
                foreach (var company in mAllComapnies.Where(company => company.State == Company.CompanyState.Idle))
                {
                    Step3i(company);
                    //Step4i(company);
                    //Step5i(company);
                }

                int timeToDevelopNextFuncionality = mAllComapnies.Min(company => company.TimeToDevelopNextFunctionality);

                foreach (var company in mAllComapnies)
                {
                    company.TimeToDevelopNextFunctionality -= timeToDevelopNextFuncionality;

                    if (company.TimeToDevelopNextFunctionality == 0)
                    {
                        company.finishDevelopFuncionality();
                    }
                }
            }
        }

         private void Step3i(Company company)
        {
            Console.Out.WriteLine("Step3i");
            IEnumerable<Company> otherCompanies = mAllComapnies.Where(c => c != company);
            List<Funcionality> priorityFunctionalities = new List<Funcionality>();

            foreach (var otherCompany in otherCompanies)
            {
                priorityFunctionalities.AddRange(otherCompany.ImplementedFunctionalites.Except(company.ImplementedFunctionalites));
            }

            if (priorityFunctionalities.Count != 0)
            {
                priorityFunctionalities.Sort();
            }

            priorityFunctionalities = priorityFunctionalities.Distinct().ToList();

            bool leader = priorityFunctionalities.Count == 0;
            List<Funcionality> missingFunctionalities = leader ?  company.MissingFunctionalities : priorityFunctionalities;

            if (!leader)
            {
                missingFunctionalities = ChooseBestFunctionalities(missingFunctionalities, company);
            }

            var functionalitesWithCost = missingFunctionalities
                .Select(func => new { Functionality = func, Cost = company.functionalityCost(func) });

            Funcionality functionalityToDevelop = null;

            functionalityToDevelop = functionalitesWithCost
                    .First(pair => pair.Cost == functionalitesWithCost.Min(internalPair => internalPair.Cost)).Functionality;

            company.developFunctionality(functionalityToDevelop);
        }

        private List<Funcionality> ChooseBestFunctionalities(IEnumerable<Funcionality> missingFunctionalities, Company company)
        {
            MarketReaction reaction = MarketReaction.HighGrowth;
            List<Funcionality> bestFunctionalities = new List<Funcionality>();

            while (bestFunctionalities.Count() == 0)
            {
                bestFunctionalities = missingFunctionalities.Where(func => func.MarketReaction == reaction).ToList();
                reaction--;
            }

            return bestFunctionalities;    
        }

        private void Step4i(Company company)
        {
            Console.Out.WriteLine("Step4i");
        }

        private void Step5i(Company company)
        {
            Console.Out.WriteLine("Step5i");
        }

        private bool Step6()
        {
            return mAllComapnies.Any(company => company.State != Company.CompanyState.DoneAllFunctionalities);
        }
    }
}
