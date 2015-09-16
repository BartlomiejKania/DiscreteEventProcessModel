using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Funcionality : IComparable<Funcionality>
    {
        private static int nextId = 0;
        private int mId;

        public string Description { get; private set; }

        public MarketReaction MarketReaction
        {
            get;
            set;
        }

        public Funcionality(string description, string marketReaction)
        {
            mId = nextId++;
            Description = description;
            MarketReaction = GetMarketReactionFromString(marketReaction);
        }

        private MarketReaction GetMarketReactionFromString(string marketReaction)
        {
            MarketReaction reaction = 0;

            switch (marketReaction.ToUpper())
            {
                case "HIGH DROP":
                    reaction = MarketReaction.HighDrop;
                    break;
                case "LOW DROP":
                    reaction = MarketReaction.LowDrop;
                    break;
                case "STAGNATION":
                    reaction = MarketReaction.Stagnation;
                    break;
                case "LOW GROWTH":
                    reaction = MarketReaction.LowGrowth;
                    break;
                case "HIGH GROWTH":
                    reaction = MarketReaction.HighGrowth;
                    break;
            }

            return reaction;
        }

        public int CompareTo(Funcionality other)
        {
            return mId.CompareTo(other.mId);
        }
    }

    public enum MarketReaction
    {
        HighDrop = 0,
        LowDrop = 1,
        Stagnation = 2,
        LowGrowth = 3,
        HighGrowth = 4
    }
}
