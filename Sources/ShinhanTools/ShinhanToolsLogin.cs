using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxGIEXPERTCONTROLLib;
using GIEXPERTCONTROLLib;

namespace ShinhanTools
{
    public partial class ShinhanToolsLogin : Form
    {
        public OpenFileDialog    dialog;
        public AxGiExpertControl control;
        public string            indiPath = @"C:\SHINHAN-i\indi\giexpertstarter.exe";

        public ShinhanToolsLogin(ShinhanTools host)
        {
            InitializeComponent();

            dialog = new OpenFileDialog
            {
                Title  = "Locating Shinhan-Indi Starter",
                Filter = "Shinhan-Indi Executable|giexpertstarter.exe"
            };

            control = host.control;
        }

        private void ShinhanToolsLogin_Load(object sender, EventArgs e)
        {

        }

        private void doLoginButton_Click(object sender, EventArgs e)
        {
            var id = userId.Text;
            var pw = userPw.Text;
            var cp = userCertiPw.Text;

            if (!File.Exists(indiPath) && dialog.ShowDialog() == DialogResult.OK)
            {
                indiPath = dialog.FileName;
            }


            if (control.StartIndi(id, pw, cp, indiPath))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("로그인 실패!");
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            control.AboutBox();
        }
    }
}
