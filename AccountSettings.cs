using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAMLService
{
    public class AccountSettings
    {
        private string _certificate;
        private string _idp_sso_target_url;

        public string Certificate
        {
            get
            {
                return _certificate;
            }
            set
            {
                _certificate = value;
            }
        }

        public string IdpSSOTargetURL
        {
            get
            {
                return _idp_sso_target_url;
            }
            set
            {
                _idp_sso_target_url = value;
            }
        }
    }
}
