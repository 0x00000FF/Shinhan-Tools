namespace ShinhanTools
{
    partial class ShinhanToolsLogin
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
            this.userId = new System.Windows.Forms.TextBox();
            this.userPw = new System.Windows.Forms.TextBox();
            this.userCertiPw = new System.Windows.Forms.TextBox();
            this.doLoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userId
            // 
            this.userId.Location = new System.Drawing.Point(97, 12);
            this.userId.Name = "userId";
            this.userId.PasswordChar = '*';
            this.userId.Size = new System.Drawing.Size(209, 20);
            this.userId.TabIndex = 0;
            // 
            // userPw
            // 
            this.userPw.Location = new System.Drawing.Point(97, 38);
            this.userPw.Name = "userPw";
            this.userPw.PasswordChar = '*';
            this.userPw.Size = new System.Drawing.Size(209, 20);
            this.userPw.TabIndex = 1;
            // 
            // userCertiPw
            // 
            this.userCertiPw.Location = new System.Drawing.Point(97, 64);
            this.userCertiPw.Name = "userCertiPw";
            this.userCertiPw.PasswordChar = '*';
            this.userCertiPw.Size = new System.Drawing.Size(209, 20);
            this.userCertiPw.TabIndex = 2;
            // 
            // doLoginButton
            // 
            this.doLoginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.doLoginButton.Location = new System.Drawing.Point(97, 91);
            this.doLoginButton.Name = "doLoginButton";
            this.doLoginButton.Size = new System.Drawing.Size(132, 26);
            this.doLoginButton.TabIndex = 3;
            this.doLoginButton.Text = "로그인";
            this.doLoginButton.UseVisualStyleBackColor = true;
            this.doLoginButton.Click += new System.EventHandler(this.doLoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "사용자ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "사용자PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "인증서PW";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(235, 91);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(71, 26);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "정보";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // ShinhanToolsLogin
            // 
            this.AcceptButton = this.doLoginButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(318, 129);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.doLoginButton);
            this.Controls.Add(this.userCertiPw);
            this.Controls.Add(this.userPw);
            this.Controls.Add(this.userId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShinhanToolsLogin";
            this.Text = "ShinhanToolsLogin";
            this.Load += new System.EventHandler(this.ShinhanToolsLogin_Load);
            this.Shown += new System.EventHandler(this.ShinhanToolsLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userId;
        private System.Windows.Forms.TextBox userPw;
        private System.Windows.Forms.TextBox userCertiPw;
        private System.Windows.Forms.Button doLoginButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aboutButton;
    }
}