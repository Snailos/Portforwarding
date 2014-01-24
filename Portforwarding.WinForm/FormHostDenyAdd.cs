using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace Portforwarding.WinForm
{
    public partial class FormHostDenyAdd : Form
    {
        public FormHostDenyAdd()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                IPAddress ip = IPAddress.Parse(txtIPAddress.Text);
                FormMain mainForm = ((FormMain)this.Owner);
                bool isExist = false;
                lock (mainForm.CheckedListBoxHostDeny)
                {
                    foreach (IPAddress item in mainForm.CheckedListBoxHostDeny.Items)
                    {
                        if (item.ToString() == ip.ToString())
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (!isExist)
                        mainForm.CheckedListBoxHostDeny.Items.Add(ip);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
