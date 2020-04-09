using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AxGIEXPERTCONTROLLib;

namespace ShinhanTools
{
    public partial class ShinhanTools : Form
    {
        bool exiting = false;
        readonly ShinhanToolsLogin loginWindow;

        public bool IsCommOk
        {
            get => (control.GetCommState() | realtimeControl.GetCommState()) == 0;
        }

        public ShinhanTools()
        {
            InitializeComponent();

            loginWindow = new ShinhanToolsLogin(this);
            if (!IsCommOk)
            {
                this.Hide();
                loginWindow.ShowDialog();
            }

            control.ReceiveSysMsg         += Control_ReceiveSysMsg;
            realtimeControl.ReceiveSysMsg += Control_ReceiveSysMsg;

            control.ReceiveData           += Control_ReceiveData;
        }

        public void TR_AccountList(object rdata)
        {
            var data = rdata as string[,];

            for (var i = 0; i < data.Length / 2; ++i)
            {
                accountListBox.Items.Add(data[i, 0]);
            }

            if (accountListBox.Items.Count > 0)
            {
                accountListBox.SelectedIndex = 0;
            }
        }

        private void Control_ReceiveData(object sender, _DGiExpertControlEvents_ReceiveDataEvent e)
        {
            var methodName   = control.GetInputTRName(e.rqid);
            var method       = this.GetType()
                                   .GetMethod("TR_" + methodName as string);

            if (method != null)
            {
                var array = control.GetMultiBlockData();
                method.Invoke(this, new [] { array });
            }
        }

        private void Control_ReceiveSysMsg(object sender, _DGiExpertControlEvents_ReceiveSysMsgEvent e)
        {
            switch (e.nMsgID) {
                case 7:
                case 10:
                    if (!exiting && !IsCommOk)
                    {
                        this.Hide();
                        loginWindow.ShowDialog();
                    }

                    break;

                case 11:
                    this.Show();
                    break;
            }
        }

        private void RequestData(AxGiExpertControl targetControl, 
                                 string queryName, 
                                 params string[] data)
        {
            targetControl.SetQueryName(queryName);

            for (short i = 0; i < data.Length; ++i)
            {
                targetControl.SetSingleData(i, data[i]);
            }

            targetControl.RequestData();
        }

        private void ShinhanTools_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("정말로 ShinhanTools를 종료하시겠습니까?", 
                            "ShinhanTools", 
                            MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                exiting = true;

                this.Text = "[종료중입니다...]";
                control.CloseIndi();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void ShinhanTools_Shown(object sender, EventArgs e)
        {
            if (!IsCommOk) this.Hide();
        }

        private void queryAccountList_Click(object sender, EventArgs e)
        {
            RequestData(control, "AccountList");
        }
    }
}
