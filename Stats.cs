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
        //continue where Attributes left off
        handToHand = Attributes.intelligence + 1,
        sword,
        axe,
        spear,
        thrown,
        shield,
    }

    public class Stats
    {
        [Serializable]
        public class Stat
        {            
            string _name;
            int _baseValue;
            int _buff;

            public string name { get{return _name;} set{_name = value;} }
            public int baseValue { get { return _baseValue; } set { _baseValue = value; } }
            public int buff { get { return _buff; } set { _buff = value; } }

            public Stat() { }
            public Stat(string s, int bv, int b)
            {
                _name = s;
                _baseValue = bv;
                _buff = b;
            }
        }
        
        [Serializable]
        public class Effect
        {
            string name;
            int value;
        }
        
        List<Stat> _stats = new List<Stat>();
        public List<Stat> stats {get { return _stats; }}

        string[] names =
        {
            "Strength",
            "Agility",
            "Intelligence",
            "Hand to Hand",
            "Sword",
            "Axe",
            "Spear",
            "Thrown",
            "Shield",
        };

        public Stats()
        {
            //int size = Enum.GetValues(typeof(Attributes)).Cast<int>().Count();
            //size += Enum.GetValues(typeof(Skills)).Cast<int>().Count();
            int size = names.Count();
            for (int i = 0; i < size; ++i)
            {
                Stat s = new Stat();
                s.name = names[i];
                s.baseValue = 0;
                s.buff = 0;
                _stats.Add(s);
            }
            //this way would rid the need for an array of strings,
            //but would have to append each stat to list manually.
            //_stats.Add(new Stat("Strength", 0, 0));
            //_stats.Add(new Stat("Agility", 0, 0));
            //_stats.Add(new Stat("Intelligence", 0, 0));
            //etc...
        }
    }


    public interface IAttribute
    {
        //void AddAttribute(Attributes attribute, int amount);
    }

    public interface ISkill
    {
        //void AddSkill(Skills skill, int amount);
    }

    public interface IModifier
    {
        //void AddModifier(Attributes attribute, int amount);
        //void AddModifier(Skills skill, int amount);
    }
}
