using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serialization
{
    public partial class Form1 : Form
    {
        List<Stats.Effect> knownEffects = new List<Stats.Effect>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stats s = new Stats();
            for (int i = 0; i < s.stats.Count; ++i)
            {
                statsBox.Items.Add(s.stats[i].name);
            }            
            
        }

        #region statValueBox
        private void StatValueBox(object sender, EventArgs e)
        {
            int value = 0;
            int.TryParse(statValueBox.Text, out value);            

            if (statsBox.SelectedIndex >= 0 || statsBox.SelectedIndex <=
               Enum.GetValues(typeof(Attributes)).Length)
            {
                if (value <= -9 || value >= 9 || value == 0)
                {
                    statValueBox.Text = "(Must be between -9 and 9)";

                    //hacky way to apply the same effect of validating the control so
                    //that when you click on the textbox, typing is enabled again.
                    //Alternatively, could put "(Must be..." text outside of textbox;
                    statValueBox.Parent.SelectNextControl((Control)sender, true, true, true, true);
                    statValueBox.Parent.SelectNextControl((Control)sender, false, true, true, true);
                }
            }
            else if(value <= -99 || value >= 99 || value == 0)
            {
                statValueBox.Text = "(Must be between -99 and 99)";

                //again with the nonsense
                statValueBox.Parent.SelectNextControl((Control)sender, true, true, true, true);
                statValueBox.Parent.SelectNextControl((Control)sender, false, true, true, true);
            }
            
        }
        #endregion

        private void OnCreateButton(object sender, EventArgs e)
        {
            if (statsBox.SelectedIndex == -1)
                MessageBox.Show("Choose a stat from the list.");
            else if(statValueBox.Text.ElementAt(0) == '(')
                MessageBox.Show("Enter a positive or negative amount for the effect.");
            else
            {
                Stats.Effect effect = new Stats.Effect();
                effect.name = (string)statsBox.SelectedItem;
                int value;
                int.TryParse(statValueBox.Text, out value);
                effect.value = value;

                string effectPrefix;
                if (effect.value < 0)
                    effectPrefix = "Damage";
                else
                    effectPrefix = "Fortify";

                

                effect.name = effectPrefix + " " + effect.name;

                knownEffects.Add(effect);
                //effectsBox.Items.Add(newEffectName);
            }
        }
    }
}
