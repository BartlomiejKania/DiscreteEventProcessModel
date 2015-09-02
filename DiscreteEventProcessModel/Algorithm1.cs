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

        public Algorithm1(IEnumerable<Company> allCompanies, IEnumerable<Funcionality> allFunctionalities)
        {
            mAllComapnies = allCompanies;
            mAllFunctionalities = allFunctionalities;
        }

        public void Run()
        {
            Step1();
            Step2();
            AlgorithmLoop();
        }

        private void Step1()
        {
            DecomposeStatesToLevelSets();
            //mIterator = 1;
        }

        private void DecomposeStatesToLevelSets()
        {
            //mLevelSets = new List<List<State>>();

            //for(int i = 1; i <= mAutomation.FunctionalitiesCount; i++)
            //{
            //    List<State> levelSet = mAutomation.States.Where(s => s.Functionalities.Count == i).ToList();
            //    mLevelSets.Add(levelSet);
            //}
        }

        private void Step2()
        {
            ComputeCriteria();
        }

        private void ComputeCriteria()
        {
            //mPaths = new List<Path>();

            //foreach (State stateQ1 in mLevelSets.ElementAt(0))
            //{
            //    Path path = new Path(new List<State> { stateQ1 });
            //    string functionality = stateQ1.Functionalities.ElementAt(0);
            //    int cost = mAutomation.Functionalities.First(f => f.Description == functionality).Cost;
            //    path.IncreaseCost(cost);
            //    mPaths.Add(path);
            //}
        }

        private void AlgorithmLoop()
        {
            FindAllowedTransitions();
            Step4i();
            Step5i();
            Step6i();
        }

        private void FindAllowedTransitions()
        {
            //List<Path> extendedPaths = new List<Path>();

            //foreach (Path path in mPaths)
            //{
            //    foreach (State stateQi in mLevelSets.ElementAt(mIterator))
            //    {
            //        if (path.Trajectory.All(s => s.Functionalities.All(f => stateQi.Functionalities.Contains(f))))
            //        {
            //            List<State> newTrajectory = new List<State>();
            //            newTrajectory.AddRange(path.Trajectory);
            //            newTrajectory.Add(stateQi);
            //            Path extendedPath = new Path(newTrajectory);
            //            extendedPath.IncreaseCost(path.ActualCost);
            //            extendedPaths.Add(new Path(newTrajectory));
            //        }
            //    }
            //}

            //if (mSupervisorFunctionalities.Count > 0)
            //{
            //    extendedPaths = extendedPaths.Where(p => mSupervisorFunctionalities.
            //    All(f => p.Trajectory.Any(s => s.Functionalities.Contains(f)))).ToList();
            //}
        }

        private void Step4i()
        {
            throw new NotImplementedException();
        }

        private void Step5i()
        {
            throw new NotImplementedException();
        }

        private void Step6i()
        {
            throw new NotImplementedException();
        }
    }
}
