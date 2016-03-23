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
            this.SuspendLayout();
            // 
            // button_createConsumable
            // 
            this.button_createConsumable.Location = new System.Drawing.Point(602, 187);
            this.button_createConsumable.Name = "button_createConsumable";
            this.button_createConsumable.Size = new System.Drawing.Size(75, 23);
            this.button_createConsumable.TabIndex = 1;
            this.button_createConsumable.Text = "Create";
            this.button_createConsumable.UseVisualStyleBackColor = true;
            // 
            // statsBox
            // 
            this.statsBox.FormattingEnabled = true;
            this.statsBox.Location = new System.Drawing.Point(565, 59);
            this.statsBox.Name = "statsBox";
            this.statsBox.Size = new System.Drawing.Size(143, 95);
            this.statsBox.TabIndex = 2;
            // 
            // statValueBox
            // 
            this.statValueBox.FormattingEnabled = true;
            this.statValueBox.Location = new System.Drawing.Point(565, 160);
            this.statValueBox.Name = "statValueBox";
            this.statValueBox.Size = new System.Drawing.Size(143, 21);
            this.statValueBox.TabIndex = 3;
            this.statValueBox.Text = "(Enter the effect amount)";
            this.statValueBox.TextChanged += new System.EventHandler(this.StatValueBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 447);
            this.Controls.Add(this.statValueBox);
            this.Controls.Add(this.statsBox);
            this.Controls.Add(this.button_createConsumable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_createConsumable;
        private System.Windows.Forms.ListBox statsBox;
        private System.Windows.Forms.ComboBox statValueBox;
    }
}

