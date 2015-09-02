using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteEventProcessModel
{
    public class Funcionality
    {
        public string Description { get; private set; }

        public Funcionality(string description)
        {
            this.Description = description;
        }
    }
}
