namespace Serialization
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_createConsumable = new System.Windows.Forms.Button();
            this.statsBox = new System.Windows.Forms.ListBox();
            this.statValueBox = new System.Windows.Forms.ComboBox();
            this.effectNameBox = new System.Windows.Forms.TextBox();
            this.effectNameLabel = new System.Windows.Forms.Label();
            this.effectAmountLabel = new System.Windows.Forms.Label();
            this.statsLabel = new System.Windows.Forms.Label();
            this.effectsBox = new System.Windows.Forms.ListBox();
            this.knownEffectsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_createConsumable
            // 
            this.button_createConsumable.Location = new System.Drawing.Point(657, 223);
            this.button_createConsumable.Name = "button_createConsumable";
            this.button_createConsumable.Size = new System.Drawing.Size(75, 23);
            this.button_createConsumable.TabIndex = 1;
            this.button_createConsumable.Text = "Create";
            this.button_createConsumable.UseVisualStyleBackColor = true;
            this.button_createConsumable.Click += new System.EventHandler(this.OnCreateButton);
            // 
            // statsBox
            // 
            this.statsBox.FormattingEnabled = true;
            this.statsBox.Location = new System.Drawing.Point(627, 95);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(143, 95);
            this.statsBox.TabIndex = 2;
            // 
            // statValueBox
            // 
            this.statValueBox.FormattingEnabled = true;
            this.statValueBox.Location = new System.Drawing.Point(627, 196);
            this.statValueBox.Name = "statValueBox";
            this.statValueBox.Size = new System.Drawing.Size(143, 21);
            this.statValueBox.TabIndex = 3;
            this.statValueBox.Text = "(Enter the effect amount)";
            this.statValueBox.TextChanged += new System.EventHandler(this.StatValueBox);
            // 
            // effectNameBox
            // 
            this.effectNameBox.Location = new System.Drawing.Point(627, 48);
            this.effectNameBox.Name = "effectNameBox";
            this.effectNameBox.Size = new System.Drawing.Size(143, 20);
            this.effectNameBox.TabIndex = 4;
            this.effectNameBox.Text = "(Enter a name)";
            // 
            // effectNameLabel
            // 
            this.effectNameLabel.AutoSize = true;
            this.effectNameLabel.Location = new System.Drawing.Point(575, 51);
            this.effectNameLabel.Name = "effectNameLabel";
            this.effectNameLabel.Size = new System.Drawing.Size(38, 13);
            this.effectNameLabel.TabIndex = 5;
            this.effectNameLabel.Text = "Name:";
            // 
            // effectAmountLabel
            // 
            this.effectAmountLabel.AutoSize = true;
            this.effectAmountLabel.Location = new System.Drawing.Point(575, 199);
            this.effectAmountLabel.Name = "effectAmountLabel";
            this.effectAmountLabel.Size = new System.Drawing.Size(46, 13);
            this.effectAmountLabel.TabIndex = 6;
            this.effectAmountLabel.Text = "Amount:";
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.Location = new System.Drawing.Point(575, 95);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(29, 13);
            this.statsLabel.TabIndex = 7;
            this.statsLabel.Text = "Stat:";
            // 
            // effectsBox
            // 
            this.effectsBox.FormattingEnabled = true;
            this.effectsBox.Location = new System.Drawing.Point(30, 95);
            this.effectsBox.Name = "effectsBox";
            this.effectsBox.Size = new System.Drawing.Size(198, 95);
            this.effectsBox.TabIndex = 8;
            // 
            // knownEffectsLabel
            // 
            this.knownEffectsLabel.AutoSize = true;
            this.knownEffectsLabel.Location = new System.Drawing.Point(27, 70);
            this.knownEffectsLabel.Name = "knownEffectsLabel";
            this.knownEffectsLabel.Size = new System.Drawing.Size(79, 13);
            this.knownEffectsLabel.TabIndex = 9;
            this.knownEffectsLabel.Text = "Known Effects:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 447);
            this.Controls.Add(this.knownEffectsLabel);
            this.Controls.Add(this.effectsBox);
            this.Controls.Add(this.statsLabel);
            this.Controls.Add(this.effectAmountLabel);
            this.Controls.Add(this.effectNameLabel);
            this.Controls.Add(this.effectNameBox);
            this.Controls.Add(this.statValueBox);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.button_createConsumable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_createConsumable;
        private System.Windows.Forms.ListBox statsBox;
        private System.Windows.Forms.ComboBox statValueBox;
        private System.Windows.Forms.TextBox effectNameBox;
        private System.Windows.Forms.Label effectNameLabel;
        private System.Windows.Forms.Label effectAmountLabel;
        private System.Windows.Forms.Label statsLabel;
        private System.Windows.Forms.ListBox effectsBox;
        private System.Windows.Forms.Label knownEffectsLabel;
    }
}

