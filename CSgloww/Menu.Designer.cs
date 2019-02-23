namespace CSgloww
{
    partial class Menu
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
            this.checkBoxGlow = new System.Windows.Forms.CheckBox();
            this.checkBoxTrigger = new System.Windows.Forms.CheckBox();
            this.checkBoxESP = new System.Windows.Forms.CheckBox();
            this.checkBoxBHop = new System.Windows.Forms.CheckBox();
            this.checkBoxOnlyEnemy = new System.Windows.Forms.CheckBox();
            this.checkBoxSpotted = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxGlow
            // 
            this.checkBoxGlow.AutoSize = true;
            this.checkBoxGlow.Checked = true;
            this.checkBoxGlow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGlow.Location = new System.Drawing.Point(40, 40);
            this.checkBoxGlow.Name = "checkBoxGlow";
            this.checkBoxGlow.Size = new System.Drawing.Size(50, 17);
            this.checkBoxGlow.TabIndex = 0;
            this.checkBoxGlow.Text = "Glow";
            this.checkBoxGlow.UseVisualStyleBackColor = true;
            this.checkBoxGlow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxTrigger
            // 
            this.checkBoxTrigger.AutoSize = true;
            this.checkBoxTrigger.Checked = true;
            this.checkBoxTrigger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTrigger.Location = new System.Drawing.Point(40, 83);
            this.checkBoxTrigger.Name = "checkBoxTrigger";
            this.checkBoxTrigger.Size = new System.Drawing.Size(75, 17);
            this.checkBoxTrigger.TabIndex = 1;
            this.checkBoxTrigger.Text = "TriggerBot";
            this.checkBoxTrigger.UseVisualStyleBackColor = true;
            this.checkBoxTrigger.CheckedChanged += new System.EventHandler(this.checkBoxTrigger_CheckedChanged);
            // 
            // checkBoxESP
            // 
            this.checkBoxESP.AutoSize = true;
            this.checkBoxESP.Location = new System.Drawing.Point(394, 223);
            this.checkBoxESP.Name = "checkBoxESP";
            this.checkBoxESP.Size = new System.Drawing.Size(67, 17);
            this.checkBoxESP.TabIndex = 2;
            this.checkBoxESP.Text = "ESP test";
            this.checkBoxESP.UseVisualStyleBackColor = true;
            this.checkBoxESP.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxBHop
            // 
            this.checkBoxBHop.AutoSize = true;
            this.checkBoxBHop.Checked = true;
            this.checkBoxBHop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBHop.Location = new System.Drawing.Point(40, 120);
            this.checkBoxBHop.Name = "checkBoxBHop";
            this.checkBoxBHop.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBHop.TabIndex = 3;
            this.checkBoxBHop.Text = "BHop";
            this.checkBoxBHop.UseVisualStyleBackColor = true;
            this.checkBoxBHop.CheckedChanged += new System.EventHandler(this.checkBoxBHop_CheckedChanged);
            // 
            // checkBoxOnlyEnemy
            // 
            this.checkBoxOnlyEnemy.AutoSize = true;
            this.checkBoxOnlyEnemy.Location = new System.Drawing.Point(128, 40);
            this.checkBoxOnlyEnemy.Name = "checkBoxOnlyEnemy";
            this.checkBoxOnlyEnemy.Size = new System.Drawing.Size(82, 17);
            this.checkBoxOnlyEnemy.TabIndex = 4;
            this.checkBoxOnlyEnemy.Text = "Enemy Only";
            this.checkBoxOnlyEnemy.UseVisualStyleBackColor = true;
            this.checkBoxOnlyEnemy.CheckedChanged += new System.EventHandler(this.checkBoxOnlyEnemy_CheckedChanged);
            // 
            // checkBoxSpotted
            // 
            this.checkBoxSpotted.AutoSize = true;
            this.checkBoxSpotted.Location = new System.Drawing.Point(275, 40);
            this.checkBoxSpotted.Name = "checkBoxSpotted";
            this.checkBoxSpotted.Size = new System.Drawing.Size(77, 17);
            this.checkBoxSpotted.TabIndex = 5;
            this.checkBoxSpotted.Text = "RadarSpot";
            this.checkBoxSpotted.UseVisualStyleBackColor = true;
            this.checkBoxSpotted.CheckedChanged += new System.EventHandler(this.checkBoxSpotted_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 252);
            this.Controls.Add(this.checkBoxSpotted);
            this.Controls.Add(this.checkBoxOnlyEnemy);
            this.Controls.Add(this.checkBoxBHop);
            this.Controls.Add(this.checkBoxESP);
            this.Controls.Add(this.checkBoxTrigger);
            this.Controls.Add(this.checkBoxGlow);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxESP;
        public System.Windows.Forms.CheckBox checkBoxGlow;
        public System.Windows.Forms.CheckBox checkBoxTrigger;
        private System.Windows.Forms.CheckBox checkBoxBHop;
        private System.Windows.Forms.CheckBox checkBoxOnlyEnemy;
        private System.Windows.Forms.CheckBox checkBoxSpotted;
    }
}