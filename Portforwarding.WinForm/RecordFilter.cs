using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portforwarding.WinForm
{
    class RecordFilter : DataFilter
    {
        private StringType stringType;

        protected StringType StringType
        {
            get { return stringType; }
        }
        private string contentString;

        protected string ContentString
        {
            get { return contentString; }
        }
        private bool split;

        protected bool Split
        {
            get { return split; }
        }

        protected string splitSymbol;

        protected string SplitSymbol
        {
            get { return splitSymbol; }
        }

        private int splitLength;


        protected int SplitLength
        {
            get { return splitLength; }
        }

        public RecordFilter(string fromAddress, string toAddress, DataFilterType filterType)
            : this(fromAddress, toAddress, null, ContentFilterType.None, filterType, StringType.Unknow, false, string.Empty, 0)
        {

        }

        public RecordFilter(string fromAddress, string toAddress, string contentString, ContentFilterType contentFilterType, DataFilterType filterType, StringType stringType)
            : this(fromAddress, toAddress, contentString, contentFilterType, filterType, stringType, false, string.Empty, 0)
        {

        }

        public RecordFilter(string fromAddress, string toAddress, string contentString, ContentFilterType contentFilterType, DataFilterType filterType, StringType stringType, bool split, string splitSymbol, int splitLength)
        {
            base.fromAddress = fromAddress;
            base.toAddress = toAddress;
            base.content = null;
            base.contentFilterType = contentFilterType;
            base.dataFilterType = filterType;
            this.contentString = contentString;
            this.stringType = stringType;
            this.split = split;
            this.splitSymbol = splitSymbol;
            this.splitLength = splitLength;
            this.ResolveBytes();
        }

        protected void ResolveBytes()
        {
            string tempString;
            if (this.split)
                tempString = StringHelper.RemoveSplitSymbol(this.contentString, this.splitSymbol, this.splitLength);
            else
                tempString = this.contentString;
            switch (stringType)
            { 
                case StringType.Bin:
                    break;
                case StringType.Oct:
                    break;
                case StringType.Dec:
                    break;
                case StringType.Hex:
                    break;
                case StringType.ASCII:
                    content = Encoding.ASCII.GetBytes(tempString);
                    break;
                case StringType.UTF8:
                    content = Encoding.UTF8.GetBytes(tempString);
                    break;
                case StringType.Unicode:
                    content = Encoding.Unicode.GetBytes(tempString);
                    break;
                case StringType.Base64:
                    content = Convert.FromBase64String(tempString);
                    break;
                default:
                    break;
            }
        }
        public int Filter(DataPackage dataPackage)
        {
            if (fromAddress == null || fromAddress.Length <= 0 || fromAddress.Contains(dataPackage.FromAddress.Split(':')[0]))
            {
                if (toAddress == null || toAddress.Length <= 0 || toAddress.Contains(dataPackage.ToAddress.Split(':')[0]))
                {
                    if (content == null || content.Length <= 0)
                        return (int)dataFilterType;

                    if (dataPackage.Data.Length >= content.Length)
                    {
                        if (dataPackage.Data == content)
                            return (int)dataFilterType;

                        for (int i = 0; i < dataPackage.Data.Length - content.Length; i++)
                        {
                            byte[] cmp = new byte[content.Length];
                            dataPackage.Data.CopyTo(cmp, i);
                            if (cmp == content)
                                return (int)dataFilterType;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
