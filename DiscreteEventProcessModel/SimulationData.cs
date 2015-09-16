using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class SimulationData
    {
        public string Functionality
        {
            get;
            set;
        }

        public int WordPressCost
        {
            get;
            set;
        }

        public int JoomlaCost
        {
            get;
            set;
        }

        public int DrupalCost
        {
            get;
            set;
        }

        public string MarketReaction
        {
            get;
            set;
        }

        public SimulationData(string functionality, int wordPressCost, int joomlaCost, int drupalCost,
            string marketReaction)
        {
            Functionality = functionality;
            WordPressCost = wordPressCost;
            JoomlaCost = joomlaCost;
            DrupalCost = drupalCost;
            MarketReaction = marketReaction;
        }
    }
}
