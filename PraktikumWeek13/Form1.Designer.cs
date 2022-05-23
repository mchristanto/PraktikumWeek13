namespace PraktikumWeek13
{
    partial class FormPlayer
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
            this.btnKiri2 = new System.Windows.Forms.Button();
            this.btnKiri1 = new System.Windows.Forms.Button();
            this.btnKanan1 = new System.Windows.Forms.Button();
            this.btnKanan2 = new System.Windows.Forms.Button();
            this.lblPlayerID = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblTeamNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tboxPlayerID = new System.Windows.Forms.TextBox();
            this.tboxPlayerName = new System.Windows.Forms.TextBox();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.cboxTeam = new System.Windows.Forms.ComboBox();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.cboxNationality = new System.Windows.Forms.ComboBox();
            this.numTeamNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numTeamNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKiri2
            // 
            this.btnKiri2.Location = new System.Drawing.Point(87, 12);
            this.btnKiri2.Name = "btnKiri2";
            this.btnKiri2.Size = new System.Drawing.Size(54, 39);
            this.btnKiri2.TabIndex = 0;
            this.btnKiri2.Text = "<<";
            this.btnKiri2.UseVisualStyleBackColor = true;
            this.btnKiri2.Click += new System.EventHandler(this.btnKiri2_Click);
            // 
            // btnKiri1
            // 
            this.btnKiri1.Location = new System.Drawing.Point(173, 12);
            this.btnKiri1.Name = "btnKiri1";
            this.btnKiri1.Size = new System.Drawing.Size(54, 39);
            this.btnKiri1.TabIndex = 1;
            this.btnKiri1.Text = "<";
            this.btnKiri1.UseVisualStyleBackColor = true;
            this.btnKiri1.Click += new System.EventHandler(this.btnKiri1_Click);
            // 
            // btnKanan1
            // 
            this.btnKanan1.Location = new System.Drawing.Point(265, 12);
            this.btnKanan1.Name = "btnKanan1";
            this.btnKanan1.Size = new System.Drawing.Size(54, 39);
            this.btnKanan1.TabIndex = 2;
            this.btnKanan1.Text = ">";
            this.btnKanan1.UseVisualStyleBackColor = true;
            this.btnKanan1.Click += new System.EventHandler(this.btnKanan1_Click);
            // 
            // btnKanan2
            // 
            this.btnKanan2.Location = new System.Drawing.Point(354, 12);
            this.btnKanan2.Name = "btnKanan2";
            this.btnKanan2.Size = new System.Drawing.Size(54, 39);
            this.btnKanan2.TabIndex = 3;
            this.btnKanan2.Text = ">>";
            this.btnKanan2.UseVisualStyleBackColor = true;
            this.btnKanan2.Click += new System.EventHandler(this.btnKanan2_Click);
            // 
            // lblPlayerID
            // 
            this.lblPlayerID.AutoSize = true;
            this.lblPlayerID.Location = new System.Drawing.Point(47, 70);
            this.lblPlayerID.Name = "lblPlayerID";
            this.lblPlayerID.Size = new System.Drawing.Size(50, 13);
            this.lblPlayerID.TabIndex = 4;
            this.lblPlayerID.Text = "Player ID";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(47, 99);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 5;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(47, 123);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(51, 13);
            this.lblBirthDate.TabIndex = 6;
            this.lblBirthDate.Text = "BirthDate";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(47, 151);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(56, 13);
            this.lblNationality.TabIndex = 7;
            this.lblNationality.Text = "Nationality";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(47, 179);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(34, 13);
            this.lblTeam.TabIndex = 8;
            this.lblTeam.Text = "Team";
            // 
            // lblTeamNumber
            // 
            this.lblTeamNumber.AutoSize = true;
            this.lblTeamNumber.Location = new System.Drawing.Point(47, 205);
            this.lblTeamNumber.Name = "lblTeamNumber";
            this.lblTeamNumber.Size = new System.Drawing.Size(74, 13);
            this.lblTeamNumber.TabIndex = 9;
            this.lblTeamNumber.Text = "Team Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(50, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(179, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(265, 254);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tboxPlayerID
            // 
            this.tboxPlayerID.Location = new System.Drawing.Point(133, 67);
            this.tboxPlayerID.Name = "tboxPlayerID";
            this.tboxPlayerID.Size = new System.Drawing.Size(100, 20);
            this.tboxPlayerID.TabIndex = 12;
            // 
            // tboxPlayerName
            // 
            this.tboxPlayerName.Location = new System.Drawing.Point(133, 96);
            this.tboxPlayerName.Name = "tboxPlayerName";
            this.tboxPlayerName.Size = new System.Drawing.Size(100, 20);
            this.tboxPlayerName.TabIndex = 13;
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(133, 122);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthdate.TabIndex = 15;
            // 
            // cboxTeam
            // 
            this.cboxTeam.FormattingEnabled = true;
            this.cboxTeam.Location = new System.Drawing.Point(133, 174);
            this.cboxTeam.Name = "cboxTeam";
            this.cboxTeam.Size = new System.Drawing.Size(121, 21);
            this.cboxTeam.TabIndex = 16;
            this.cboxTeam.SelectedIndexChanged += new System.EventHandler(this.cboxTeam_SelectedIndexChanged);
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Location = new System.Drawing.Point(298, 205);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(70, 13);
            this.lblAvailability.TabIndex = 18;
            this.lblAvailability.Text = "Not Available";
            // 
            // cboxNationality
            // 
            this.cboxNationality.FormattingEnabled = true;
            this.cboxNationality.Location = new System.Drawing.Point(133, 147);
            this.cboxNationality.Name = "cboxNationality";
            this.cboxNationality.Size = new System.Drawing.Size(121, 21);
            this.cboxNationality.TabIndex = 20;
            this.cboxNationality.SelectedIndexChanged += new System.EventHandler(this.cboxNationality_SelectedIndexChanged);
            // 
            // numTeamNumber
            // 
            this.numTeamNumber.Location = new System.Drawing.Point(133, 202);
            this.numTeamNumber.Name = "numTeamNumber";
            this.numTeamNumber.Size = new System.Drawing.Size(120, 20);
            this.numTeamNumber.TabIndex = 21;
            // 
            // FormPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 302);
            this.Controls.Add(this.numTeamNumber);
            this.Controls.Add(this.cboxNationality);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.cboxTeam);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.tboxPlayerName);
            this.Controls.Add(this.tboxPlayerID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTeamNumber);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblPlayerID);
            this.Controls.Add(this.btnKanan2);
            this.Controls.Add(this.btnKanan1);
            this.Controls.Add(this.btnKiri1);
            this.Controls.Add(this.btnKiri2);
            this.Name = "FormPlayer";
            this.Text = "Player";
            this.Load += new System.EventHandler(this.FormPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTeamNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKiri2;
        private System.Windows.Forms.Button btnKiri1;
        private System.Windows.Forms.Button btnKanan1;
        private System.Windows.Forms.Button btnKanan2;
        private System.Windows.Forms.Label lblPlayerID;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblTeamNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tboxPlayerID;
        private System.Windows.Forms.TextBox tboxPlayerName;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.ComboBox cboxTeam;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.ComboBox cboxNationality;
        private System.Windows.Forms.NumericUpDown numTeamNumber;
    }
}

