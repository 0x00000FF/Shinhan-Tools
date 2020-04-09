namespace ShinhanTools
{
    partial class ShinhanTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShinhanTools));
            this.control = new AxGIEXPERTCONTROLLib.AxGiExpertControl();
            this.realtimeControl = new AxGIEXPERTCONTROLLib.AxGiExpertControl();
            this.accountListBox = new System.Windows.Forms.ComboBox();
            this.accountPasswordText = new System.Windows.Forms.TextBox();
            this.queryAccountList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtimeControl)).BeginInit();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.Enabled = true;
            this.control.Location = new System.Drawing.Point(8497, 798);
            this.control.Name = "control";
            this.control.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("control.OcxState")));
            this.control.Size = new System.Drawing.Size(136, 50);
            this.control.TabIndex = 0;
            // 
            // realtimeControl
            // 
            this.realtimeControl.Enabled = true;
            this.realtimeControl.Location = new System.Drawing.Point(4967, 540);
            this.realtimeControl.Name = "realtimeControl";
            this.realtimeControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("realtimeControl.OcxState")));
            this.realtimeControl.Size = new System.Drawing.Size(136, 50);
            this.realtimeControl.TabIndex = 1;
            // 
            // accountListBox
            // 
            this.accountListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountListBox.FormattingEnabled = true;
            this.accountListBox.Location = new System.Drawing.Point(12, 10);
            this.accountListBox.Name = "accountListBox";
            this.accountListBox.Size = new System.Drawing.Size(160, 21);
            this.accountListBox.TabIndex = 3;
            // 
            // accountPasswordText
            // 
            this.accountPasswordText.Location = new System.Drawing.Point(301, 12);
            this.accountPasswordText.Name = "accountPasswordText";
            this.accountPasswordText.PasswordChar = '*';
            this.accountPasswordText.Size = new System.Drawing.Size(58, 20);
            this.accountPasswordText.TabIndex = 4;
            // 
            // queryAccountList
            // 
            this.queryAccountList.Location = new System.Drawing.Point(178, 9);
            this.queryAccountList.Name = "queryAccountList";
            this.queryAccountList.Size = new System.Drawing.Size(75, 23);
            this.queryAccountList.TabIndex = 5;
            this.queryAccountList.Text = "조회";
            this.queryAccountList.UseVisualStyleBackColor = true;
            this.queryAccountList.Click += new System.EventHandler(this.queryAccountList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "비번";
            // 
            // ShinhanTools
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryAccountList);
            this.Controls.Add(this.accountPasswordText);
            this.Controls.Add(this.accountListBox);
            this.Controls.Add(this.realtimeControl);
            this.Controls.Add(this.control);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShinhanTools";
            this.Text = "ShinhanTools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShinhanTools_FormClosing);
            this.Shown += new System.EventHandler(this.ShinhanTools_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realtimeControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal AxGIEXPERTCONTROLLib.AxGiExpertControl control;
        private AxGIEXPERTCONTROLLib.AxGiExpertControl realtimeControl;
        private System.Windows.Forms.ComboBox accountListBox;
        private System.Windows.Forms.TextBox accountPasswordText;
        private System.Windows.Forms.Button queryAccountList;
        private System.Windows.Forms.Label label1;
    }
}

