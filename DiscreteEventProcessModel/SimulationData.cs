using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class SimulationData
    {
        public string ID
        {
            get;
            set;
        }

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

        public SimulationData(int id, string functionality, int wordPressCost, int joomlaCost, int drupalCost,
            string marketReaction)
        {
            ID = id.ToString();
            Functionality = functionality;
            WordPressCost = wordPressCost;
            JoomlaCost = joomlaCost;
            DrupalCost = drupalCost;
            MarketReaction = marketReaction;
        }
    }
}
