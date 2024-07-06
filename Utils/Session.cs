using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UI_winform.utils
{
    public partial class Session
    {
        // Fields for user settings
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public OracleConnection OracleConnection { get; set; }

        // Singleton instance
        private static Session _instance;

        // Private constructor to prevent external instantiation
        private Session() { }

        // Public static property to access the singleton instance
        public static Session Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Session();
                }
                return _instance;
            }
        }
    }
}
