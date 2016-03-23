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

        private void StatValueBox(object sender, EventArgs e)
        {
            
            int value = int.Parse(statValueBox.SelectedText);
            if (statsBox.SelectedIndex >= 0 || statsBox.SelectedIndex <=
               Enum.GetValues(typeof(Attributes)).Length)
            {
                if (value <= -9 || value >= 9 || value == 0)
                {
                    statValueBox.Text = "(Must be between -9 and 9)";
                }
            }
            else
            {
                if (value <= -99 || value >= 99 || value == 0)
                {
                    statValueBox.Text = "(Must be between -99 and 99)";
                }
            }
        }
    }
}
