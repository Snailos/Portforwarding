using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Portforwarding.WinForm
{
    partial class FormMain
    {
        bool IsAllowEndPoint(EndPoint endPoint)
        {
            lock (listHostDeny)
            {
                foreach (IPAddress ip in listHostDeny)
                {
                    if (endPoint.ToString().Contains(ip.ToString()))
                        return false;
                }
            }
            return true;
        }

        bool IsSocketConnected(Socket s)
        {
            return !((s.Poll(1000, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }

        string ByteArrayToXString(byte[] bytes, XType x)
        {
            StringBuilder sb = new StringBuilder();

            int n = (int)x, l = 0; string s = string.Empty;

            foreach (byte b in bytes)
            {
                s = Convert.ToString(b, n);

                switch (x)
                {
                    case XType.Bin:
                        l = 8 - s.Length;
                        break;
                    case XType.Oct:
                        l = 3 - s.Length;
                        break;
                    case XType.Dec:
                        l = 3 - s.Length;
                        break;
                    case XType.Hex:
                        l = 2 - s.Length;
                        break;
                    default:
                        break;
                }

                for (int i = 0; i < l; i++)
                {
                    s = "0" + s;
                }

                sb.Append(s);
            }

            return sb.ToString();
        }

        string FormatToShowString(DataPackage dataPackage)
        {
            string retString = string.Empty;

            switch (showType)
            {
                case StringType.Bin:
                    retString = ByteArrayToXString(dataPackage.Data, XType.Bin);
                    break;
                case StringType.Oct:
                    retString = ByteArrayToXString(dataPackage.Data, XType.Oct);
                    break;
                case StringType.Dec:
                    retString = ByteArrayToXString(dataPackage.Data, XType.Dec);
                    break;
                case StringType.Hex:
                    retString = ByteArrayToXString(dataPackage.Data, XType.Hex);
                    break;
                case StringType.Base64:
                    retString = Convert.ToBase64String(dataPackage.Data);
                    break;
                case StringType.ASCII:
                    retString = Encoding.ASCII.GetString(dataPackage.Data);
                    break;
                case StringType.UTF8:
                    retString = Encoding.UTF8.GetString(dataPackage.Data);
                    break;
                case StringType.Unicode:
                    retString = Encoding.Unicode.GetString(dataPackage.Data);
                    break;
                default:
                    break;
            }

            return retString;
        }

        private bool IsFromExist(Form form)
        {
            if (form == null)
                return false;
            if (form.IsDisposed)
                return false;
            return true;
        }

        private void ShowSingleForm(Form form)
        {
            if (form.Visible == false)
            {
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Show(this);
            }
            form.Activate();
        }
    }
}
