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

namespace ShinhanTools
{
    public partial class ShinhanTools : Form
    {
        private bool IsCommOK
        {
            get => control.GetCommState() == 0;
        }

        public ShinhanTools()
        {
            InitializeComponent();

            try
            {
                var login = new ShinhanToolsLogin(this);
                login.ShowDialog();
            }
            catch (COMException e)
            {
                var message = $"Cannot initialize GiExpertControl COM Object\n" +
                              $"Message: {e.Message}";

                MessageBox.Show(message, "ShinhanTools",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
        }

    }
}
