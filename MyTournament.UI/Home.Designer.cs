﻿namespace MyTournament.UI
{
    partial class Home
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnViewTeams = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.btnViewMembers = new System.Windows.Forms.Button();
            this.btnTry = new System.Windows.Forms.Button();
            this.btnAddMembers = new System.Windows.Forms.Button();
            this.lblNumberOfMembers = new System.Windows.Forms.Label();
            this.lblNumberOfTeams = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(255, 116);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(488, 36);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to My Kirubel Tournament";
            this.lblWelcome.Click += new System.EventHandler(this.LblWelcome_Click);
            // 
            // btnViewTeams
            // 
            this.btnViewTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTeams.Location = new System.Drawing.Point(248, 235);
            this.btnViewTeams.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewTeams.Name = "btnViewTeams";
            this.btnViewTeams.Size = new System.Drawing.Size(184, 46);
            this.btnViewTeams.TabIndex = 1;
            this.btnViewTeams.Text = "View Teams";
            this.btnViewTeams.UseVisualStyleBackColor = true;
            this.btnViewTeams.Click += new System.EventHandler(this.btnViewTeams_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblErrorMessage.Location = new System.Drawing.Point(434, 441);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 17);
            this.lblErrorMessage.TabIndex = 2;
            // 
            // btnViewMembers
            // 
            this.btnViewMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMembers.Location = new System.Drawing.Point(559, 235);
            this.btnViewMembers.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewMembers.Name = "btnViewMembers";
            this.btnViewMembers.Size = new System.Drawing.Size(184, 46);
            this.btnViewMembers.TabIndex = 3;
            this.btnViewMembers.Text = "View Members";
            this.btnViewMembers.UseVisualStyleBackColor = true;
            this.btnViewMembers.Click += new System.EventHandler(this.btnViewMembers_Click);
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTry.Location = new System.Drawing.Point(248, 346);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(184, 47);
            this.btnTry.TabIndex = 4;
            this.btnTry.Text = "ADD TEAM";
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnAddMembers
            // 
            this.btnAddMembers.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddMembers.Location = new System.Drawing.Point(559, 346);
            this.btnAddMembers.Name = "btnAddMembers";
            this.btnAddMembers.Size = new System.Drawing.Size(184, 47);
            this.btnAddMembers.TabIndex = 5;
            this.btnAddMembers.Text = "Add Members";
            this.btnAddMembers.UseVisualStyleBackColor = false;
            this.btnAddMembers.Click += new System.EventHandler(this.BtnAddMembers_Click);
            // 
            // lblNumberOfMembers
            // 
            this.lblNumberOfMembers.AutoSize = true;
            this.lblNumberOfMembers.Location = new System.Drawing.Point(570, 288);
            this.lblNumberOfMembers.Name = "lblNumberOfMembers";
            this.lblNumberOfMembers.Size = new System.Drawing.Size(139, 17);
            this.lblNumberOfMembers.TabIndex = 6;
            this.lblNumberOfMembers.Text = "Number Of Members";
            this.lblNumberOfMembers.Click += new System.EventHandler(this.NumberOfMembers_Click);
            // 
            // lblNumberOfTeams
            // 
            this.lblNumberOfTeams.AutoSize = true;
            this.lblNumberOfTeams.Location = new System.Drawing.Point(258, 288);
            this.lblNumberOfTeams.Name = "lblNumberOfTeams";
            this.lblNumberOfTeams.Size = new System.Drawing.Size(124, 17);
            this.lblNumberOfTeams.TabIndex = 7;
            this.lblNumberOfTeams.Text = "Number Of Teams";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 554);
            this.Controls.Add(this.lblNumberOfTeams);
            this.Controls.Add(this.lblNumberOfMembers);
            this.Controls.Add(this.btnAddMembers);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.btnViewMembers);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnViewTeams);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnViewTeams;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Button btnViewMembers;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Button btnAddMembers;
        private System.Windows.Forms.Label lblNumberOfMembers;
        private System.Windows.Forms.Label lblNumberOfTeams;
    }
}