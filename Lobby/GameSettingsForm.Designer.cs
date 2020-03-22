﻿namespace BlowtorchesAndGunpowder
{
    partial class GameSettingsForm
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
            this.quitBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.serverIpTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serverPortTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.myUsernameTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.quitBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.quitBtn.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.quitBtn.Location = new System.Drawing.Point(12, 56);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(114, 23);
            this.quitBtn.TabIndex = 0;
            this.quitBtn.Text = "Avsluta till lobby";
            this.quitBtn.UseVisualStyleBackColor = false;
            // 
            // continueBtn
            // 
            this.continueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.continueBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.continueBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.continueBtn.Location = new System.Drawing.Point(307, 56);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(104, 23);
            this.continueBtn.TabIndex = 1;
            this.continueBtn.Text = "Fortsätt spela";
            this.continueBtn.UseVisualStyleBackColor = false;
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveBtn.Location = new System.Drawing.Point(167, 56);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(134, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Spara och fortsätt spela";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // serverIpTxt
            // 
            this.serverIpTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.serverIpTxt.Location = new System.Drawing.Point(12, 25);
            this.serverIpTxt.Name = "serverIpTxt";
            this.serverIpTxt.Size = new System.Drawing.Size(127, 20);
            this.serverIpTxt.TabIndex = 3;
            this.serverIpTxt.Text = "localhost";
            this.serverIpTxt.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server ip";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(284, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server port";
            this.label2.Visible = false;
            // 
            // serverPortTxt
            // 
            this.serverPortTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.serverPortTxt.Location = new System.Drawing.Point(284, 25);
            this.serverPortTxt.Name = "serverPortTxt";
            this.serverPortTxt.Size = new System.Drawing.Size(127, 20);
            this.serverPortTxt.TabIndex = 5;
            this.serverPortTxt.Text = "4567";
            this.serverPortTxt.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(145, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "My username";
            this.label3.Visible = false;
            // 
            // myUsernameTxt
            // 
            this.myUsernameTxt.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myUsernameTxt.Location = new System.Drawing.Point(145, 25);
            this.myUsernameTxt.Name = "myUsernameTxt";
            this.myUsernameTxt.Size = new System.Drawing.Size(112, 20);
            this.myUsernameTxt.TabIndex = 7;
            this.myUsernameTxt.Text = "Player1";
            this.myUsernameTxt.Visible = false;
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(423, 91);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.myUsernameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverPortTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverIpTxt);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.quitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pause";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.TextBox serverIpTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serverPortTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox myUsernameTxt;
    }
}