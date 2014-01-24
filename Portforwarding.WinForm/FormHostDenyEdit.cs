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
    public partial class FormHostDenyEdit : Form
    {
        IPAddress oldIPAddress;
        IPAddress newIPAddress;
        FormMain formMain;

        public FormHostDenyEdit()
        {
            InitializeComponent();
        }

        private void FormHostDenyEdit_Load(object sender, EventArgs e)
        {
            formMain = ((FormMain)this.Owner);

            oldIPAddress = formMain.CheckedListBoxHostDeny.SelectedItem as IPAddress;

            txtIPAddress.Text = oldIPAddress.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                newIPAddress = IPAddress.Parse(txtIPAddress.Text);

                if (oldIPAddress.ToString() == newIPAddress.ToString())
                {
                    this.Close();
                    return;
                }

                lock (formMain.CheckedListBoxHostDeny)
                {
                    foreach (IPAddress ip in formMain.CheckedListBoxHostDeny.Items)
                    {
                        if (ip.ToString() == newIPAddress.ToString())
                        {
                            MessageBox.Show("地址已存在！");
                            return;
                        }
                    }

                    formMain.CheckedListBoxHostDeny.Items.Add(newIPAddress);
                    formMain.CheckedListBoxHostDeny.Items.Remove(oldIPAddress);

                    lock (formMain.ListHostDeny)
                    {
                        if (formMain.ListHostDeny.Contains(oldIPAddress))
                            formMain.ListHostDeny.Remove(oldIPAddress);

                    }
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
