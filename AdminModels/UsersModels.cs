using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminModels
{
    public class UserModels
    {
        private static string ?_rank;
        private static string? _username;
        private static string? _password;
        private static string? _email;
        
        public string username {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string password {
            get
            {
                return _password;
            }
            set
            {
                    _password = value; 
            }
        }
        /*
        public string name { get; set; }
        public string email {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }*/
        public  string rank{
            get{
                return _rank;
            }
            set
            {
                _rank = value;
            }
        }

    }
   
}
