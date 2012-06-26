using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAMLService
{
    public class AppSettings
    {
        private string _assertionConsumerServiceUrl;
        private string _issuer;

        public string AssertionConsumerServiceUrl
        {
            get
            {
                return _assertionConsumerServiceUrl;
            }
            set
            {
                _assertionConsumerServiceUrl = value;
            }
        }

        public string Issuer
        {
            get
            {
                return _issuer;
            }
            set
            {
                _issuer = value;
            }
        }
    }

}
