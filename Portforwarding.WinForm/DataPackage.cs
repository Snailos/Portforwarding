using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portforwarding.WinForm
{
    class DataPackage
    {
        DataPackageType type;

        internal DataPackageType Type
        {
            get { return type; }
            //set { type = value; }
        }

        DateTime datetime;

        public DateTime Datetime
        {
            get { return datetime; }
            //set { datetime = value; }
        }
        string fromAddress;

        public string FromAddress
        {
            get { return fromAddress; }
            //set { fromAddress = value; }
        }
        string toAddress;

        public string ToAddress
        {
            get { return toAddress; }
            //set { toAddress = value; }
        }
        byte[] data;


        public byte[] Data
        {
            get { return data; }
            //set { data = value; }
        }

        public DataPackage(string fromAddress, string toAddress, byte[] data, DataPackageType type,DateTime datetime)
        {
            this.fromAddress = fromAddress;
            this.toAddress = toAddress;
            this.data = data;
            this.type = type;
            this.datetime = datetime;
            
        }
    }
}
