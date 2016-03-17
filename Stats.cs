using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public enum Attributes
    {
        strength, agility, intelligence
    }

    public enum Skills
    {
        handToHand,
        sword,
        axe,
        spear,
        thrown,
        shield,
    }

    public interface IAttribute
    {
        //int variable;
        void AddAttribute(Attributes attribute, int amount);
    }

    public interface ISkill
    {
        void AddSkill(Skills skill, int amount);
    }

    public interface IModifier
    {
        void AddModifier(Attributes attribute, int amount);
        void AddModifier(Skills skill, int amount);
    }
}
