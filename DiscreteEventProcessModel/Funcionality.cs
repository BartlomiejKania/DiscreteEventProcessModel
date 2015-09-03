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

        public List<string> DependsOn
        {
            get;
            set;
        }

        public Funcionality(string description, List<string> dependsOn)
        {
            mId = nextId++;
            Description = description;
            DependsOn = dependsOn;
        }

        public int CompareTo(Funcionality other)
        {
            return mId.CompareTo(other.mId);
        }
    }
}
