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

        public List<string> DependsOn
        {
            get;
            set;
        }

        public Funcionality(string description)
        {
            this.Description = description;
        }

        public Funcionality(string description, int cost, List<string> dependsOn)
        {
            Description = description;
            Cost = cost;
            DependsOn = dependsOn;
        }
    }
}
