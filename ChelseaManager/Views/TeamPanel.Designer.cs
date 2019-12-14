using System;

namespace ChelseaManager.Views
{
    partial class TeamPanel
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
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.groupBoxTransfers = new System.Windows.Forms.GroupBox();
            this.labelTransferBirth = new System.Windows.Forms.Label();
            this.dateTimePickerTransferBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxTransferNumber = new System.Windows.Forms.TextBox();
            this.labelNumberTransfer = new System.Windows.Forms.Label();
            this.textBoxTransferPosition = new System.Windows.Forms.TextBox();
            this.labelTransferPosition = new System.Windows.Forms.Label();
            this.textBoxTransferCountry = new System.Windows.Forms.TextBox();
            this.labelTransferCountry = new System.Windows.Forms.Label();
            this.textBoxTransferSurname = new System.Windows.Forms.TextBox();
            this.labelTransferSurname = new System.Windows.Forms.Label();
            this.textBoxTransferName = new System.Windows.Forms.TextBox();
            this.labelTransferName = new System.Windows.Forms.Label();
            this.buttonBuyPlayer = new System.Windows.Forms.Button();
            this.groupBoxEdit = new System.Windows.Forms.GroupBox();
            this.labelBirthDateEdit = new System.Windows.Forms.Label();
            this.dateTimePickerEditBirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxEditNumber = new System.Windows.Forms.TextBox();
            this.labelShirtNumberEdit = new System.Windows.Forms.Label();
            this.textBoxEditPosition = new System.Windows.Forms.TextBox();
            this.labelPositionEdit = new System.Windows.Forms.Label();
            this.textBoxEditCountry = new System.Windows.Forms.TextBox();
            this.labelCountryEdit = new System.Windows.Forms.Label();
            this.textBoxEditSurname = new System.Windows.Forms.TextBox();
            this.labelSurnameEdit = new System.Windows.Forms.Label();
            this.textBoxEditName = new System.Windows.Forms.TextBox();
            this.labelEditName = new System.Windows.Forms.Label();
            this.buttonEditPlayer = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonCountryPlayer = new System.Windows.Forms.Button();
            this.buttonPositionPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.groupBoxTransfers.SuspendLayout();
            this.groupBoxEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.AllowUserToAddRows = false;
            this.dataGridViewPlayer.AllowUserToDeleteRows = false;
            this.dataGridViewPlayer.AllowUserToOrderColumns = true;
            this.dataGridViewPlayer.AllowUserToResizeColumns = false;
            this.dataGridViewPlayer.AllowUserToResizeRows = false;
            this.dataGridViewPlayer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPlayer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPlayer.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(23, 55);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.ReadOnly = true;
            this.dataGridViewPlayer.RowHeadersWidth = 51;
            this.dataGridViewPlayer.RowTemplate.Height = 24;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(438, 490);
            this.dataGridViewPlayer.TabIndex = 0;
            this.dataGridViewPlayer.SelectionChanged += new System.EventHandler(this.dataGridViewPlayer_SelectionChanged);
            // 
            // groupBoxTransfers
            // 
            this.groupBoxTransfers.Controls.Add(this.labelTransferBirth);
            this.groupBoxTransfers.Controls.Add(this.dateTimePickerTransferBirth);
            this.groupBoxTransfers.Controls.Add(this.textBoxTransferNumber);
            this.groupBoxTransfers.Controls.Add(this.labelNumberTransfer);
            this.groupBoxTransfers.Controls.Add(this.textBoxTransferPosition);
            this.groupBoxTransfers.Controls.Add(this.labelTransferPosition);
            this.groupBoxTransfers.Controls.Add(this.textBoxTransferCountry);
            this.groupBoxTransfers.Controls.Add(this.labelTransferCountry);
            this.groupBoxTransfers.Controls.Add(this.textBoxTransferSurname);
            this.groupBoxTransfers.Controls.Add(this.labelTransferSurname);
            this.groupBoxTransfers.Controls.Add(this.textBoxTransferName);
            this.groupBoxTransfers.Controls.Add(this.labelTransferName);
            this.groupBoxTransfers.Controls.Add(this.buttonBuyPlayer);
            this.groupBoxTransfers.Font = new System.Drawing.Font("Venus Rising", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxTransfers.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxTransfers.Location = new System.Drawing.Point(498, 55);
            this.groupBoxTransfers.Name = "groupBoxTransfers";
            this.groupBoxTransfers.Size = new System.Drawing.Size(331, 334);
            this.groupBoxTransfers.TabIndex = 1;
            this.groupBoxTransfers.TabStop = false;
            this.groupBoxTransfers.Text = "Transfers";
            // 
            // labelTransferBirth
            // 
            this.labelTransferBirth.AutoSize = true;
            this.labelTransferBirth.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelTransferBirth.Location = new System.Drawing.Point(21, 233);
            this.labelTransferBirth.Name = "labelTransferBirth";
            this.labelTransferBirth.Size = new System.Drawing.Size(83, 14);
            this.labelTransferBirth.TabIndex = 32;
            this.labelTransferBirth.Text = "Bithdate:";
            // 
            // dateTimePickerTransferBirth
            // 
            this.dateTimePickerTransferBirth.Font = new System.Drawing.Font("Microsoft YaHei", 6F);
            this.dateTimePickerTransferBirth.Location = new System.Drawing.Point(132, 227);
            this.dateTimePickerTransferBirth.Name = "dateTimePickerTransferBirth";
            this.dateTimePickerTransferBirth.Size = new System.Drawing.Size(204, 21);
            this.dateTimePickerTransferBirth.TabIndex = 31;
            // 
            // textBoxTransferNumber
            // 
            this.textBoxTransferNumber.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxTransferNumber.Location = new System.Drawing.Point(132, 196);
            this.textBoxTransferNumber.Name = "textBoxTransferNumber";
            this.textBoxTransferNumber.Size = new System.Drawing.Size(204, 24);
            this.textBoxTransferNumber.TabIndex = 30;
            // 
            // labelNumberTransfer
            // 
            this.labelNumberTransfer.AutoSize = true;
            this.labelNumberTransfer.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelNumberTransfer.Location = new System.Drawing.Point(21, 202);
            this.labelNumberTransfer.Name = "labelNumberTransfer";
            this.labelNumberTransfer.Size = new System.Drawing.Size(75, 14);
            this.labelNumberTransfer.TabIndex = 29;
            this.labelNumberTransfer.Text = "Number:";
            // 
            // textBoxTransferPosition
            // 
            this.textBoxTransferPosition.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxTransferPosition.Location = new System.Drawing.Point(132, 158);
            this.textBoxTransferPosition.Name = "textBoxTransferPosition";
            this.textBoxTransferPosition.Size = new System.Drawing.Size(204, 24);
            this.textBoxTransferPosition.TabIndex = 28;
            // 
            // labelTransferPosition
            // 
            this.labelTransferPosition.AutoSize = true;
            this.labelTransferPosition.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelTransferPosition.Location = new System.Drawing.Point(21, 164);
            this.labelTransferPosition.Name = "labelTransferPosition";
            this.labelTransferPosition.Size = new System.Drawing.Size(93, 14);
            this.labelTransferPosition.TabIndex = 27;
            this.labelTransferPosition.Text = "Position ID:";
            // 
            // textBoxTransferCountry
            // 
            this.textBoxTransferCountry.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxTransferCountry.Location = new System.Drawing.Point(132, 120);
            this.textBoxTransferCountry.Name = "textBoxTransferCountry";
            this.textBoxTransferCountry.Size = new System.Drawing.Size(204, 24);
            this.textBoxTransferCountry.TabIndex = 26;
            // 
            // labelTransferCountry
            // 
            this.labelTransferCountry.AutoSize = true;
            this.labelTransferCountry.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelTransferCountry.Location = new System.Drawing.Point(21, 126);
            this.labelTransferCountry.Name = "labelTransferCountry";
            this.labelTransferCountry.Size = new System.Drawing.Size(98, 14);
            this.labelTransferCountry.TabIndex = 25;
            this.labelTransferCountry.Text = "Country ID:";
            // 
            // textBoxTransferSurname
            // 
            this.textBoxTransferSurname.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxTransferSurname.Location = new System.Drawing.Point(132, 82);
            this.textBoxTransferSurname.Name = "textBoxTransferSurname";
            this.textBoxTransferSurname.Size = new System.Drawing.Size(204, 24);
            this.textBoxTransferSurname.TabIndex = 24;
            // 
            // labelTransferSurname
            // 
            this.labelTransferSurname.AutoSize = true;
            this.labelTransferSurname.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelTransferSurname.Location = new System.Drawing.Point(21, 88);
            this.labelTransferSurname.Name = "labelTransferSurname";
            this.labelTransferSurname.Size = new System.Drawing.Size(85, 14);
            this.labelTransferSurname.TabIndex = 23;
            this.labelTransferSurname.Text = "Surname:";
            // 
            // textBoxTransferName
            // 
            this.textBoxTransferName.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxTransferName.Location = new System.Drawing.Point(132, 44);
            this.textBoxTransferName.Name = "textBoxTransferName";
            this.textBoxTransferName.Size = new System.Drawing.Size(204, 24);
            this.textBoxTransferName.TabIndex = 22;
            // 
            // labelTransferName
            // 
            this.labelTransferName.AutoSize = true;
            this.labelTransferName.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelTransferName.Location = new System.Drawing.Point(21, 50);
            this.labelTransferName.Name = "labelTransferName";
            this.labelTransferName.Size = new System.Drawing.Size(55, 14);
            this.labelTransferName.TabIndex = 21;
            this.labelTransferName.Text = "Name:";
            // 
            // buttonBuyPlayer
            // 
            this.buttonBuyPlayer.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonBuyPlayer.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonBuyPlayer.ForeColor = System.Drawing.Color.Gold;
            this.buttonBuyPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBuyPlayer.Location = new System.Drawing.Point(111, 285);
            this.buttonBuyPlayer.Name = "buttonBuyPlayer";
            this.buttonBuyPlayer.Size = new System.Drawing.Size(96, 30);
            this.buttonBuyPlayer.TabIndex = 6;
            this.buttonBuyPlayer.Text = "Buy";
            this.buttonBuyPlayer.UseVisualStyleBackColor = false;
            this.buttonBuyPlayer.Click += new System.EventHandler(this.buttonBuyPlayer_Click);
            // 
            // groupBoxEdit
            // 
            this.groupBoxEdit.Controls.Add(this.labelBirthDateEdit);
            this.groupBoxEdit.Controls.Add(this.dateTimePickerEditBirth);
            this.groupBoxEdit.Controls.Add(this.textBoxEditNumber);
            this.groupBoxEdit.Controls.Add(this.labelShirtNumberEdit);
            this.groupBoxEdit.Controls.Add(this.textBoxEditPosition);
            this.groupBoxEdit.Controls.Add(this.labelPositionEdit);
            this.groupBoxEdit.Controls.Add(this.textBoxEditCountry);
            this.groupBoxEdit.Controls.Add(this.labelCountryEdit);
            this.groupBoxEdit.Controls.Add(this.textBoxEditSurname);
            this.groupBoxEdit.Controls.Add(this.labelSurnameEdit);
            this.groupBoxEdit.Controls.Add(this.textBoxEditName);
            this.groupBoxEdit.Controls.Add(this.labelEditName);
            this.groupBoxEdit.Controls.Add(this.buttonEditPlayer);
            this.groupBoxEdit.Font = new System.Drawing.Font("Venus Rising", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxEdit.ForeColor = System.Drawing.Color.Gold;
            this.groupBoxEdit.Location = new System.Drawing.Point(498, 419);
            this.groupBoxEdit.Name = "groupBoxEdit";
            this.groupBoxEdit.Size = new System.Drawing.Size(331, 306);
            this.groupBoxEdit.TabIndex = 2;
            this.groupBoxEdit.TabStop = false;
            this.groupBoxEdit.Text = "Edit Player";
            // 
            // labelBirthDateEdit
            // 
            this.labelBirthDateEdit.AutoSize = true;
            this.labelBirthDateEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelBirthDateEdit.Location = new System.Drawing.Point(21, 233);
            this.labelBirthDateEdit.Name = "labelBirthDateEdit";
            this.labelBirthDateEdit.Size = new System.Drawing.Size(83, 14);
            this.labelBirthDateEdit.TabIndex = 20;
            this.labelBirthDateEdit.Text = "Bithdate:";
            // 
            // dateTimePickerEditBirth
            // 
            this.dateTimePickerEditBirth.Font = new System.Drawing.Font("Microsoft YaHei", 6F);
            this.dateTimePickerEditBirth.Location = new System.Drawing.Point(127, 233);
            this.dateTimePickerEditBirth.Name = "dateTimePickerEditBirth";
            this.dateTimePickerEditBirth.Size = new System.Drawing.Size(204, 21);
            this.dateTimePickerEditBirth.TabIndex = 19;
            // 
            // textBoxEditNumber
            // 
            this.textBoxEditNumber.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxEditNumber.Location = new System.Drawing.Point(127, 196);
            this.textBoxEditNumber.Name = "textBoxEditNumber";
            this.textBoxEditNumber.Size = new System.Drawing.Size(204, 24);
            this.textBoxEditNumber.TabIndex = 17;
            // 
            // labelShirtNumberEdit
            // 
            this.labelShirtNumberEdit.AutoSize = true;
            this.labelShirtNumberEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelShirtNumberEdit.Location = new System.Drawing.Point(21, 202);
            this.labelShirtNumberEdit.Name = "labelShirtNumberEdit";
            this.labelShirtNumberEdit.Size = new System.Drawing.Size(75, 14);
            this.labelShirtNumberEdit.TabIndex = 16;
            this.labelShirtNumberEdit.Text = "Number:";
            // 
            // textBoxEditPosition
            // 
            this.textBoxEditPosition.Font = new System.Drawing.Font("Venus Rising", 8F);
            this.textBoxEditPosition.Location = new System.Drawing.Point(127, 158);
            this.textBoxEditPosition.Name = "textBoxEditPosition";
            this.textBoxEditPosition.Size = new System.Drawing.Size(204, 24);
            this.textBoxEditPosition.TabIndex = 15;
            // 
            // labelPositionEdit
            // 
            this.labelPositionEdit.AutoSize = true;
            this.labelPositionEdit.Font = new System.Drawing.Font("Venus Rising", 6F);
            this.labelPositionEdit.Location = new System.Drawing.Point(21, 164);
            this.labelPositionEdit.Name = "labelPositionEdit";
            this.labelPositionEdit.Size = new System.Drawing.Size(93, 14);
            this.labelPositionEdit.TabIndex = 14;
            this.labelPositionEdit.Text = "Position ID:";
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
            // buttonEditPlayer
            // 
            this.buttonEditPlayer.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonEditPlayer.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonEditPlayer.ForeColor = System.Drawing.Color.Gold;
            this.buttonEditPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonEditPlayer.Location = new System.Drawing.Point(111, 270);
            this.buttonEditPlayer.Name = "buttonEditPlayer";
            this.buttonEditPlayer.Size = new System.Drawing.Size(96, 30);
            this.buttonEditPlayer.TabIndex = 7;
            this.buttonEditPlayer.Text = "Edit";
            this.buttonEditPlayer.UseVisualStyleBackColor = false;
            this.buttonEditPlayer.Click += new System.EventHandler(this.buttonEditPlayer_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonSell.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonSell.ForeColor = System.Drawing.Color.Gold;
            this.buttonSell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSell.Location = new System.Drawing.Point(26, 563);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(136, 38);
            this.buttonSell.TabIndex = 3;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonCountryPlayer
            // 
            this.buttonCountryPlayer.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonCountryPlayer.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonCountryPlayer.ForeColor = System.Drawing.Color.Gold;
            this.buttonCountryPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCountryPlayer.Location = new System.Drawing.Point(181, 563);
            this.buttonCountryPlayer.Name = "buttonCountryPlayer";
            this.buttonCountryPlayer.Size = new System.Drawing.Size(136, 38);
            this.buttonCountryPlayer.TabIndex = 4;
            this.buttonCountryPlayer.Text = "Country";
            this.buttonCountryPlayer.UseVisualStyleBackColor = false;
            this.buttonCountryPlayer.Click += new System.EventHandler(this.buttonCountryPlayer_Click);
            // 
            // buttonPositionPlayer
            // 
            this.buttonPositionPlayer.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonPositionPlayer.Font = new System.Drawing.Font("Venus Rising", 8F, System.Drawing.FontStyle.Bold);
            this.buttonPositionPlayer.ForeColor = System.Drawing.Color.Gold;
            this.buttonPositionPlayer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPositionPlayer.Location = new System.Drawing.Point(336, 563);
            this.buttonPositionPlayer.Name = "buttonPositionPlayer";
            this.buttonPositionPlayer.Size = new System.Drawing.Size(136, 38);
            this.buttonPositionPlayer.TabIndex = 5;
            this.buttonPositionPlayer.Text = "Position";
            this.buttonPositionPlayer.UseVisualStyleBackColor = false;
            this.buttonPositionPlayer.Click += new System.EventHandler(this.buttonPositionPlayer_Click);
            // 
            // TeamPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumBlue;
            this.BackgroundImage = global::ChelseaManager.Properties.Resources.chelseaBack1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.buttonPositionPlayer);
            this.Controls.Add(this.buttonCountryPlayer);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.groupBoxEdit);
            this.Controls.Add(this.groupBoxTransfers);
            this.Controls.Add(this.dataGridViewPlayer);
            this.Name = "TeamPanel";
            this.Size = new System.Drawing.Size(868, 753);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.groupBoxTransfers.ResumeLayout(false);
            this.groupBoxTransfers.PerformLayout();
            this.groupBoxEdit.ResumeLayout(false);
            this.groupBoxEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.GroupBox groupBoxTransfers;
        private System.Windows.Forms.GroupBox groupBoxEdit;
        private System.Windows.Forms.Label labelTransferBirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransferBirth;
        private System.Windows.Forms.TextBox textBoxTransferNumber;
        private System.Windows.Forms.Label labelNumberTransfer;
        private System.Windows.Forms.TextBox textBoxTransferPosition;
        private System.Windows.Forms.Label labelTransferPosition;
        private System.Windows.Forms.TextBox textBoxTransferCountry;
        private System.Windows.Forms.Label labelTransferCountry;
        private System.Windows.Forms.TextBox textBoxTransferSurname;
        private System.Windows.Forms.Label labelTransferSurname;
        private System.Windows.Forms.TextBox textBoxTransferName;
        private System.Windows.Forms.Label labelTransferName;
        private System.Windows.Forms.Button buttonBuyPlayer;
        private System.Windows.Forms.Label labelBirthDateEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerEditBirth;
        private System.Windows.Forms.TextBox textBoxEditNumber;
        private System.Windows.Forms.Label labelShirtNumberEdit;
        private System.Windows.Forms.TextBox textBoxEditPosition;
        private System.Windows.Forms.Label labelPositionEdit;
        private System.Windows.Forms.TextBox textBoxEditCountry;
        private System.Windows.Forms.Label labelCountryEdit;
        private System.Windows.Forms.TextBox textBoxEditSurname;
        private System.Windows.Forms.Label labelSurnameEdit;
        private System.Windows.Forms.TextBox textBoxEditName;
        private System.Windows.Forms.Label labelEditName;
        private System.Windows.Forms.Button buttonEditPlayer;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonCountryPlayer;
        private System.Windows.Forms.Button buttonPositionPlayer;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
    }
}
