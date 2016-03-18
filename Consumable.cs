using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Consumable : IConsumable
    {
        List<Stats.Effect> effects = new List<Stats.Effect>();
        public void Use()
        {
            //for (int i = 0; i < effects.Last; ++i)
            //    stats[i] += effects[i];
        }
    }
}
