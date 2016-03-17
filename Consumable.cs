using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Consumable : IConsumable
    {
        List<IModifier> effects = new List<IModifier>();
        public void Use()
        {
            //for (int i = 0; i < effects.Last; ++i)
            //    stats[i] += effects[i];
        }
    }
}
