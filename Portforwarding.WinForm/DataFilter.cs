using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portforwarding.WinForm
{
    class DataFilter
    {
        protected DataFilterType dataFilterType;

        public DataFilterType DataFilterType
        {
            get { return dataFilterType; }
        }
        protected string fromAddress;

        public string FromAddress
        {
            get { return fromAddress; }
        }
        protected string toAddress;

        public string ToAddress
        {
            get { return toAddress; }
        }
        protected byte[] content;

        public byte[] Content
        {
            get { return content; }
        }

        protected ContentFilterType contentFilterType;

        protected ContentFilterType ContentFilterType
        {
            get { return contentFilterType; }
        }

        protected DataFilter()
        {

        }

        public DataFilter(string fromAddress, string toAddress, byte[] content, ContentFilterType contentFilterType, DataFilterType dataFilterType)
        {
            this.fromAddress = fromAddress;
            this.toAddress = toAddress;
            this.content = content;
            this.contentFilterType = contentFilterType;
            this.dataFilterType = dataFilterType;
        }
    }
}
