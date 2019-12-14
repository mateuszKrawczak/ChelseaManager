namespace ChelseaManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonTeam = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelButtons.Controls.Add(this.buttonStats);
            this.panelButtons.Controls.Add(this.buttonStaff);
            this.panelButtons.Controls.Add(this.buttonTeam);
            resources.ApplyResources(this.panelButtons, "panelButtons");
            this.panelButtons.Name = "panelButtons";
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.MediumBlue;
            resources.ApplyResources(this.buttonStats, "buttonStats");
            this.buttonStats.ForeColor = System.Drawing.Color.Gold;
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.UseVisualStyleBackColor = false;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.BackColor = System.Drawing.Color.MediumBlue;
            resources.ApplyResources(this.buttonStaff, "buttonStaff");
            this.buttonStaff.ForeColor = System.Drawing.Color.Gold;
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.UseVisualStyleBackColor = false;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonTeam
            // 
            this.buttonTeam.BackColor = System.Drawing.Color.MediumBlue;
            resources.ApplyResources(this.buttonTeam, "buttonTeam");
            this.buttonTeam.ForeColor = System.Drawing.Color.Gold;
            this.buttonTeam.Name = "buttonTeam";
            this.buttonTeam.UseVisualStyleBackColor = false;
            this.buttonTeam.Click += new System.EventHandler(this.buttonTeam_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.MediumBlue;
            this.panelMain.BackgroundImage = global::ChelseaManager.Properties.Resources.stadion;
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.panelMain);
            this.Name = "FormMain";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonTeam;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonStaff;
    }
}

