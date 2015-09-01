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
        private int Iterator;

        private List<string> supervisorFunctionalities = new List<string>();
        private List<List<State>> LevelSets
        {
            get;
            set;
        }


        public Algorithm1(Automation automation)
        {
            this.automation = automation;
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
            Iterator = 1;
        }

        private void DecomposeStatesToLevelSets()
        {
            LevelSets = new List<List<State>>();

            for(int i = 1; i <= automation.FunctionalitiesCount; i++)
            {
                List<State> levelSet = automation.States.Where(s => s.Functionalities.Count == i).ToList();
                LevelSets.Add(levelSet);
            }
        }

        private void Step2()
        {
            ComputeCriteria();
        }

        private void ComputeCriteria()
        {
            Paths = new List<Path>();

            foreach (State stateQ1 in LevelSets.ElementAt(0))
            {
                Path path = new Path(new List<State> { stateQ1 });
                string functionality = stateQ1.Functionalities.ElementAt(0);
                int cost = automation.Functionalities.First(f => f.Description == functionality).Cost;
                path.IncreaseCost(cost);
                Paths.Add(path);
            }
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
            List<Path> extendedPaths = new List<Path>();

            foreach (Path path in Paths)
            {
                foreach (State stateQi in LevelSets.ElementAt(Iterator))
                {
                    if (path.Trajectory.All(s => s.Functionalities.All(f => stateQi.Functionalities.Contains(f))))
                    {
                        List<State> newTrajectory = new List<State>();
                        newTrajectory.AddRange(path.Trajectory);
                        newTrajectory.Add(stateQi);
                        Path extendedPath = new Path(newTrajectory);
                        extendedPath.IncreaseCost(path.ActualCost);
                        extendedPaths.Add(new Path(newTrajectory));
                    }
                }
            }

            if (supervisorFunctionalities.Count > 0)
            {
                extendedPaths = extendedPaths.Where(p => supervisorFunctionalities.
                All(f => p.Trajectory.Any(s => s.Functionalities.Contains(f)))).ToList();
            }
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
