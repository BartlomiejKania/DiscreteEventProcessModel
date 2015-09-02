using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Funcionality
    {
        public string Description
        {
            get;
            set;
        }

        public int Cost
        {
            get;
            set;
        }

        public Funcionality(string description)
        {
            Description = description;
        }
    }
}
