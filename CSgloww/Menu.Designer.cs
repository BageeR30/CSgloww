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
            this.numericUpDownEnemy = new System.Windows.Forms.NumericUpDown();
            this.buttonExit = new System.Windows.Forms.Button();
            this.numericUpDownAlly = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxConsole = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlly)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxGlow
            // 
            this.checkBoxGlow.AutoSize = true;
            this.checkBoxGlow.Checked = true;
            this.checkBoxGlow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGlow.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxGlow.Location = new System.Drawing.Point(6, 19);
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
            this.checkBoxTrigger.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxTrigger.Location = new System.Drawing.Point(18, 125);
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
            this.checkBoxESP.Location = new System.Drawing.Point(18, 194);
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
            this.checkBoxBHop.ForeColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxBHop.Location = new System.Drawing.Point(18, 148);
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
            this.checkBoxOnlyEnemy.ForeColor = System.Drawing.Color.White;
            this.checkBoxOnlyEnemy.Location = new System.Drawing.Point(62, 19);
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
            this.checkBoxSpotted.ForeColor = System.Drawing.Color.White;
            this.checkBoxSpotted.Location = new System.Drawing.Point(18, 171);
            this.checkBoxSpotted.Name = "checkBoxSpotted";
            this.checkBoxSpotted.Size = new System.Drawing.Size(77, 17);
            this.checkBoxSpotted.TabIndex = 5;
            this.checkBoxSpotted.Text = "RadarSpot";
            this.checkBoxSpotted.UseVisualStyleBackColor = true;
            this.checkBoxSpotted.CheckedChanged += new System.EventHandler(this.checkBoxSpotted_CheckedChanged);
            // 
            // numericUpDownEnemy
            // 
            this.numericUpDownEnemy.ForeColor = System.Drawing.Color.Red;
            this.numericUpDownEnemy.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownEnemy.Name = "numericUpDownEnemy";
            this.numericUpDownEnemy.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownEnemy.TabIndex = 7;
            this.numericUpDownEnemy.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numericUpDownEnemy.ValueChanged += new System.EventHandler(this.numericUpDownEnemy_ValueChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonExit.Location = new System.Drawing.Point(18, 274);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(135, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // numericUpDownAlly
            // 
            this.numericUpDownAlly.ForeColor = System.Drawing.Color.Blue;
            this.numericUpDownAlly.Location = new System.Drawing.Point(71, 19);
            this.numericUpDownAlly.Name = "numericUpDownAlly";
            this.numericUpDownAlly.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownAlly.TabIndex = 9;
            this.numericUpDownAlly.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownAlly.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownEnemy);
            this.groupBox1.Controls.Add(this.numericUpDownAlly);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "brightness";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.checkBoxGlow);
            this.groupBox2.Controls.Add(this.checkBoxOnlyEnemy);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GlowESP";
            // 
            // checkBoxConsole
            // 
            this.checkBoxConsole.AutoSize = true;
            this.checkBoxConsole.Location = new System.Drawing.Point(18, 217);
            this.checkBoxConsole.Name = "checkBoxConsole";
            this.checkBoxConsole.Size = new System.Drawing.Size(64, 17);
            this.checkBoxConsole.TabIndex = 12;
            this.checkBoxConsole.Text = "Console";
            this.checkBoxConsole.UseVisualStyleBackColor = true;
            this.checkBoxConsole.CheckedChanged += new System.EventHandler(this.checkBoxConsole_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(168, 309);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxConsole);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.checkBoxSpotted);
            this.Controls.Add(this.checkBoxBHop);
            this.Controls.Add(this.checkBoxESP);
            this.Controls.Add(this.checkBoxTrigger);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEnemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlly)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numericUpDownEnemy;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.NumericUpDown numericUpDownAlly;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxConsole;
    }
}