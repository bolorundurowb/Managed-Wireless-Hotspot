using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Managed_Wifi_Hotspot
{
    public partial class UI : MetroForm
    {
        public UI()
        {
            InitializeComponent();
        }

        //global  variables
        bool nameEmpty = true;
        bool passEmpty = true;
        string ap_name;
        string ap_password;

        private void txt_ap_name_TextChanged(object sender, EventArgs e)
        {
            if (txt_ap_name.Text == null || txt_ap_name.Text == "")
            {
                err_worker.SetError(txt_ap_name, "The wireless access point has to have a name!");
            }
            else
            {
                err_worker.Clear();
                nameEmpty = false;
            }
            if (!nameEmpty && !passEmpty)
            {
                btn_start_ap.Enabled = true;
            }
        }

        private void txt_ap_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_ap_password.Text == null || txt_ap_password.Text == "")
            {
                err_worker.SetError(txt_ap_password, "The wireless access point has to have a password!");
            }
            else if (txt_ap_password.Text.Length <= 6)
            {
                err_worker.SetError(txt_ap_password, "The wireless access point has to have a password longer than 6 characters!");
            }
            else
            {
                err_worker.Clear();
                passEmpty = false;
            }

            if (!nameEmpty && !passEmpty)
            {
                btn_start_ap.Enabled = true;
            }
        }

        private void UI_Load(object sender, EventArgs e)
        {
            txt_ap_name.Focus();
        }

        private void btn_start_ap_Click(object sender, EventArgs e)
        {
            string temp = "";
            foreach (char letter in txt_ap_name.Text)
            {
                if (letter.Equals(' '))
                {
                    temp = temp + "_";
                }
                else
                {
                    temp = temp + letter;
                }
            }
            ap_name = temp;
        }

        private void btn_stop_ap_Click(object sender, EventArgs e)
        {

        }
    }
}
