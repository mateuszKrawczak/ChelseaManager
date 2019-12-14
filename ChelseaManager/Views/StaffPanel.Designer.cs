namespace ChelseaManager.Views
{
    partial class StaffPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRoleStaff = new System.Windows.Forms.Button();
            this.buttonCountryEmployee = new System.Windows.Forms.Button();
            this.buttonSack = new System.Windows.Forms.Button();
            this.groupBoxEditEmployee = new System.Windows.Forms.GroupBox();
            this.labelBirthDateEdit = new System.Windows.Forms.Label();
            this.dateTimePickerEditBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditRole = new System.Windows.Forms.TextBox();
            this.labelPositionEdit = new System.Windows.Forms.Label();
            this.textBoxEditCountry = new System.Windows.Forms.TextBox();
            this.labelCountryEdit = new System.Windows.Forms.Label();
            this.textBoxEditSurname = new System.Windows.Forms.TextBox();
            this.labelSurnameEdit = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.labelEditName = new System.Windows.Forms.Label();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.groupBoxTransfers = new System.Windows.Forms.GroupBox();
            this.labelHireBirth = new System.Windows.Forms.Label();
            this.dateTimePickerHireBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxHireRole = new System.Windows.Forms.TextBox();
            this.labelHireRole = new System.Windows.Forms.Label();
            this.textBoxHireCountry = new System.Windows.Forms.TextBox();
            this.labelHireCountry = new System.Windows.Forms.Label();
            this.textBoxHireSurname = new System.Windows.Forms.TextBox();
            this.labelHireSurname = new System.Windows.Forms.Label();
            this.textBoxHireName = new System.Windows.Forms.TextBox();
            this.labelHireName = new System.Windows.Forms.Label();
            this.buttonHire = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.groupBoxEditEmployee.SuspendLayout();
            this.groupBoxTransfers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRoleStaff
            // 
            this.buttonRoleStaff.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonRoleStaff.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonRoleStaff.ForeColor = System.Drawing.Color.Gold;
            this.buttonRoleStaff.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRoleStaff.Location = new System.Drawing.Point(344, 549);
            this.buttonRoleStaff.Name = "buttonRoleStaff";
            this.buttonRoleStaff.Size = new System.Drawing.Size(136, 38);
            this.buttonRoleStaff.TabIndex = 11;
            this.buttonRoleStaff.Text = "Role";
            this.buttonRoleStaff.UseVisualStyleBackColor = false;
            this.buttonRoleStaff.Click += new System.EventHandler(this.buttonRoleStaff_Click);
            // 
            // buttonCountryEmployee
            // 
            this.buttonCountryEmployee.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonCountryEmployee.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonCountryEmployee.ForeColor = System.Drawing.Color.Gold;
            this.buttonCountryEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCountryEmployee.Location = new System.Drawing.Point(189, 549);
            this.buttonCountryEmployee.Name = "buttonCountryEmployee";
            this.buttonCountryEmployee.Size = new System.Drawing.Size(136, 38);
            this.buttonCountryEmployee.TabIndex = 10;
            this.buttonCountryEmployee.Text = "Country";
            this.buttonCountryEmployee.UseVisualStyleBackColor = false;
            this.buttonCountryEmployee.Click += new System.EventHandler(this.buttonCountryEmployee_Click);
            // 
            // buttonSack
            // 
            this.buttonSack.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSack.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonSack.ForeColor = System.Drawing.Color.Gold;
            this.buttonSack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSack.Location = new System.Drawing.Point(34, 549);
            this.buttonSack.Name = "buttonSack";
            this.buttonSack.Size = new System.Drawing.Size(136, 38);
            this.buttonSack.TabIndex = 9;
            this.buttonSack.Text = "Sack";
            this.buttonSack.UseVisualStyleBackColor = false;
            this.buttonSack.Click += new System.EventHandler(this.buttonSack_Click);
            // 
            // groupBoxEditEmployee
            // 
            this.groupBoxEditEmployee.Controls.Add(this.labelBirthDateEdit);
            this.groupBoxEditEmployee.Controls.Add(this.dateTimePickerEditBirth);
            this.groupBoxEditEmployee.Controls.Add(this.textBoxEditRole);
            this.groupBoxEditEmployee.Controls.Add(this.labelPositionEdit);
            this.groupBoxEditEmployee.Controls.Add(this.textBoxEditCountry);
            this.groupBoxEditEmployee.Controls.Add(this.labelCountryEdit);
            this.groupBoxEditEmployee.Controls.Add(this.textBoxEditSurname);
            this.groupBoxEditEmployee.Controls.Add(this.labelSurnameEdit);
            this.groupBoxEditEmployee.Controls.Add(this.textBoxEditName);
            this.groupBoxEditEmployee.Controls.Add(this.labelEditName);
            this.groupBoxEditEmployee.Controls.Add(this.buttonEditEmployee);
            this.groupBoxEditEmployee.Font = new System.Drawing.Font("Venus Rising", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxEditEmployee.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxEditEmployee.Location = new System.Drawing.Point(506, 405);
            this.groupBoxEditEmployee.Name = "groupBoxEditEmployee";
            this.groupBoxEditEmployee.Size = new System.Drawing.Size(331, 306);
            this.groupBoxEditEmployee.TabIndex = 8;
            this.groupBoxEditEmployee.TabStop = false;
            this.groupBoxEditEmployee.Text = "Edit";
            // 
            // labelBirthDateEdit
            // 
            this.labelBirthDateEdit.AutoSize = true;
            this.labelBirthDateEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelBirthDateEdit.Location = new System.Drawing.Point(21, 212);
            this.labelBirthDateEdit.Name = "labelBirthDateEdit";
            this.labelBirthDateEdit.Size = new System.Drawing.Size(83, 14);
            this.labelBirthDateEdit.TabIndex = 20;
            this.labelBirthDateEdit.Text = "Bithdate:";
            // 
            // dateTimePickerEditBirth
            // 
            this.dateTimePickerEditBirth.Font = new System.Drawing.Font("Microsoft YaHei", 6F);
            this.dateTimePickerEditBirth.Location = new System.Drawing.Point(127, 205);
            this.dateTimePickerEditBirth.Name = "dateTimePickerEditBirth";
            this.dateTimePickerEditBirth.Size = new System.Drawing.Size(204, 21);
            this.dateTimePickerEditBirth.TabIndex = 19;
            // 
            // textBoxEditRole
            // 
            this.textBoxEditRole.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxEditRole.Location = new System.Drawing.Point(127, 158);
            this.textBoxEditRole.Name = "textBoxEditRole";
            this.textBoxEditRole.Size = new System.Drawing.Size(204, 24);
            this.textBoxEditRole.TabIndex = 15;
            // 
            // labelPositionEdit
            // 
            this.labelPositionEdit.AutoSize = true;
            this.labelPositionEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelPositionEdit.Location = new System.Drawing.Point(21, 164);
            this.labelPositionEdit.Name = "labelPositionEdit";
            this.labelPositionEdit.Size = new System.Drawing.Size(64, 14);
            this.labelPositionEdit.TabIndex = 14;
            this.labelPositionEdit.Text = "Role ID:";
            // 
            // textBoxEditCountry
            // 
            this.textBoxEditCountry.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxEditCountry.Location = new System.Drawing.Point(127, 120);
            this.textBoxEditCountry.Name = "textBoxEditCountry";
            this.textBoxEditCountry.Size = new System.Drawing.Size(204, 24);
            this.textBoxEditCountry.TabIndex = 13;
            // 
            // labelCountryEdit
            // 
            this.labelCountryEdit.AutoSize = true;
            this.labelCountryEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelCountryEdit.Location = new System.Drawing.Point(21, 126);
            this.labelCountryEdit.Name = "labelCountryEdit";
            this.labelCountryEdit.Size = new System.Drawing.Size(98, 14);
            this.labelCountryEdit.TabIndex = 12;
            this.labelCountryEdit.Text = "Country ID:";
            // 
            // textBoxEditSurname
            // 
            this.textBoxEditSurname.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxEditSurname.Location = new System.Drawing.Point(127, 82);
            this.textBoxEditSurname.Name = "textBoxEditSurname";
            this.textBoxEditSurname.Size = new System.Drawing.Size(204, 24);
            this.textBoxEditSurname.TabIndex = 11;
            // 
            // labelSurnameEdit
            // 
            this.labelSurnameEdit.AutoSize = true;
            this.labelSurnameEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelSurnameEdit.Location = new System.Drawing.Point(21, 88);
            this.labelSurnameEdit.Name = "labelSurnameEdit";
            this.labelSurnameEdit.Size = new System.Drawing.Size(85, 14);
            this.labelSurnameEdit.TabIndex = 10;
            this.labelSurnameEdit.Text = "Surname:";
            // 
            // textBoxEditName
            // 
            this.textBoxEditName.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxEditName.Location = new System.Drawing.Point(127, 44);
            this.textBoxEditName.Name = "textBoxEditName";
            this.textBoxEditName.Size = new System.Drawing.Size(204, 24);
            this.textBoxEditName.TabIndex = 9;
            // 
            // labelEditName
            // 
            this.labelEditName.AutoSize = true;
            this.labelEditName.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelEditName.Location = new System.Drawing.Point(21, 50);
            this.labelEditName.Name = "labelEditName";
            this.labelEditName.Size = new System.Drawing.Size(55, 14);
            this.labelEditName.TabIndex = 8;
            this.labelEditName.Text = "Name:";
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonEditEmployee.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonEditEmployee.ForeColor = System.Drawing.Color.Gold;
            this.buttonEditEmployee.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEditEmployee.Location = new System.Drawing.Point(111, 256);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(96, 30);
            this.buttonEditEmployee.TabIndex = 7;
            this.buttonEditEmployee.Text = "Edit";
            this.buttonEditEmployee.UseVisualStyleBackColor = false;
            this.buttonEditEmployee.Click += new System.EventHandler(this.buttonEditEmployee_Click);
            // 
            // groupBoxTransfers
            // 
            this.groupBoxTransfers.Controls.Add(this.labelHireBirth);
            this.groupBoxTransfers.Controls.Add(this.dateTimePickerHireBirth);
            this.groupBoxTransfers.Controls.Add(this.textBoxHireRole);
            this.groupBoxTransfers.Controls.Add(this.labelHireRole);
            this.groupBoxTransfers.Controls.Add(this.textBoxHireCountry);
            this.groupBoxTransfers.Controls.Add(this.labelHireCountry);
            this.groupBoxTransfers.Controls.Add(this.textBoxHireSurname);
            this.groupBoxTransfers.Controls.Add(this.labelHireSurname);
            this.groupBoxTransfers.Controls.Add(this.textBoxHireName);
            this.groupBoxTransfers.Controls.Add(this.labelHireName);
            this.groupBoxTransfers.Controls.Add(this.buttonHire);
            this.groupBoxTransfers.Font = new System.Drawing.Font("Venus Rising", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransfers.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxTransfers.Location = new System.Drawing.Point(506, 41);
            this.groupBoxTransfers.Name = "groupBoxTransfers";
            this.groupBoxTransfers.Size = new System.Drawing.Size(331, 312);
            this.groupBoxTransfers.TabIndex = 7;
            this.groupBoxTransfers.TabStop = false;
            this.groupBoxTransfers.Text = "Hire";
            // 
            // labelHireBirth
            // 
            this.labelHireBirth.AutoSize = true;
            this.labelHireBirth.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelHireBirth.Location = new System.Drawing.Point(21, 209);
            this.labelHireBirth.Name = "labelHireBirth";
            this.labelHireBirth.Size = new System.Drawing.Size(83, 14);
            this.labelHireBirth.TabIndex = 32;
            this.labelHireBirth.Text = "Bithdate:";
            // 
            // dateTimePickerHireBirth
            // 
            this.dateTimePickerHireBirth.Font = new System.Drawing.Font("Microsoft YaHei", 6F);
            this.dateTimePickerHireBirth.Location = new System.Drawing.Point(132, 202);
            this.dateTimePickerHireBirth.Name = "dateTimePickerHireBirth";
            this.dateTimePickerHireBirth.Size = new System.Drawing.Size(204, 21);
            this.dateTimePickerHireBirth.TabIndex = 31;
            // 
            // textBoxHireRole
            // 
            this.textBoxHireRole.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxHireRole.Location = new System.Drawing.Point(132, 158);
            this.textBoxHireRole.Name = "textBoxHireRole";
            this.textBoxHireRole.Size = new System.Drawing.Size(204, 24);
            this.textBoxHireRole.TabIndex = 28;
            // 
            // labelHireRole
            // 
            this.labelHireRole.AutoSize = true;
            this.labelHireRole.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelHireRole.Location = new System.Drawing.Point(21, 164);
            this.labelHireRole.Name = "labelHireRole";
            this.labelHireRole.Size = new System.Drawing.Size(64, 14);
            this.labelHireRole.TabIndex = 27;
            this.labelHireRole.Text = "Role ID:";
            // 
            // textBoxHireCountry
            // 
            this.textBoxHireCountry.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxHireCountry.Location = new System.Drawing.Point(132, 120);
            this.textBoxHireCountry.Name = "textBoxHireCountry";
            this.textBoxHireCountry.Size = new System.Drawing.Size(204, 24);
            this.textBoxHireCountry.TabIndex = 26;
            // 
            // labelHireCountry
            // 
            this.labelHireCountry.AutoSize = true;
            this.labelHireCountry.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelHireCountry.Location = new System.Drawing.Point(21, 126);
            this.labelHireCountry.Name = "labelHireCountry";
            this.labelHireCountry.Size = new System.Drawing.Size(98, 14);
            this.labelHireCountry.TabIndex = 25;
            this.labelHireCountry.Text = "Country ID:";
            // 
            // textBoxHireSurname
            // 
            this.textBoxHireSurname.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxHireSurname.Location = new System.Drawing.Point(132, 82);
            this.textBoxHireSurname.Name = "textBoxHireSurname";
            this.textBoxHireSurname.Size = new System.Drawing.Size(204, 24);
            this.textBoxHireSurname.TabIndex = 24;
            // 
            // labelHireSurname
            // 
            this.labelHireSurname.AutoSize = true;
            this.labelHireSurname.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelHireSurname.Location = new System.Drawing.Point(21, 88);
            this.labelHireSurname.Name = "labelHireSurname";
            this.labelHireSurname.Size = new System.Drawing.Size(85, 14);
            this.labelHireSurname.TabIndex = 23;
            this.labelHireSurname.Text = "Surname:";
            // 
            // textBoxHireName
            // 
            this.textBoxHireName.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxHireName.Location = new System.Drawing.Point(132, 44);
            this.textBoxHireName.Name = "textBoxHireName";
            this.textBoxHireName.Size = new System.Drawing.Size(204, 24);
            this.textBoxHireName.TabIndex = 22;
            // 
            // labelHireName
            // 
            this.labelHireName.AutoSize = true;
            this.labelHireName.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelHireName.Location = new System.Drawing.Point(21, 50);
            this.labelHireName.Name = "labelHireName";
            this.labelHireName.Size = new System.Drawing.Size(55, 14);
            this.labelHireName.TabIndex = 21;
            this.labelHireName.Text = "Name:";
            // 
            // buttonHire
            // 
            this.buttonHire.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonHire.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonHire.ForeColor = System.Drawing.Color.Gold;
            this.buttonHire.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonHire.Location = new System.Drawing.Point(111, 257);
            this.buttonHire.Name = "buttonHire";
            this.buttonHire.Size = new System.Drawing.Size(96, 30);
            this.buttonHire.TabIndex = 6;
            this.buttonHire.Text = "Hire";
            this.buttonHire.UseVisualStyleBackColor = false;
            this.buttonHire.Click += new System.EventHandler(this.buttonHire_Click);
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.AllowUserToOrderColumns = true;
            this.dataGridViewEmployees.AllowUserToResizeColumns = false;
            this.dataGridViewEmployees.AllowUserToResizeRows = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(31, 41);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(438, 490);
            this.dataGridViewEmployees.TabIndex = 6;
            this.dataGridViewEmployees.SelectionChanged += new System.EventHandler(this.dataGridViewEmployees_SelectionChanged);
            // 
            // StaffPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.BackgroundImage = global::ChelseaManager.Properties.Resources.chelseaBack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonRoleStaff);
            this.Controls.Add(this.buttonCountryEmployee);
            this.Controls.Add(this.buttonSack);
            this.Controls.Add(this.groupBoxEditEmployee);
            this.Controls.Add(this.groupBoxTransfers);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "StaffPanel";
            this.Size = new System.Drawing.Size(868, 753);
            this.groupBoxEditEmployee.ResumeLayout(false);
            this.groupBoxEditEmployee.PerformLayout();
            this.groupBoxTransfers.ResumeLayout(false);
            this.groupBoxTransfers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRoleStaff;
        private System.Windows.Forms.Button buttonCountryEmployee;
        private System.Windows.Forms.Button buttonSack;
        private System.Windows.Forms.GroupBox groupBoxEditEmployee;
        private System.Windows.Forms.Label labelBirthDateEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditBirth;
        private System.Windows.Forms.TextBox textBoxEditRole;
        private System.Windows.Forms.Label labelPositionEdit;
        private System.Windows.Forms.TextBox textBoxEditCountry;
        private System.Windows.Forms.Label labelCountryEdit;
        private System.Windows.Forms.TextBox textBoxEditSurname;
        private System.Windows.Forms.Label labelSurnameEdit;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.Label labelEditName;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.GroupBox groupBoxTransfers;
        private System.Windows.Forms.Label labelHireBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerHireBirth;
        private System.Windows.Forms.TextBox textBoxHireRole;
        private System.Windows.Forms.Label labelHireRole;
        private System.Windows.Forms.TextBox textBoxHireCountry;
        private System.Windows.Forms.Label labelHireCountry;
        private System.Windows.Forms.TextBox textBoxHireSurname;
        private System.Windows.Forms.Label labelHireSurname;
        private System.Windows.Forms.TextBox textBoxHireName;
        private System.Windows.Forms.Label labelHireName;
        private System.Windows.Forms.Button buttonHire;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
    }
}
