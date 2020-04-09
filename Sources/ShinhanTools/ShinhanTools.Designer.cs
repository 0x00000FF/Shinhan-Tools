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
            ((System.ComponentModel.ISupportInitialize)(this.control)).BeginInit();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.Enabled = true;
            this.control.Location = new System.Drawing.Point(6335, 487);
            this.control.Name = "control";
            this.control.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("control.OcxState")));
            this.control.Size = new System.Drawing.Size(136, 50);
            this.control.TabIndex = 0;
            // 
            // ShinhanTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.control);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShinhanTools";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.control)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal AxGIEXPERTCONTROLLib.AxGiExpertControl control;
    }
}

