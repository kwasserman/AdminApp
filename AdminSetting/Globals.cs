using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdminSetting
{

    public class Globals
    {
        //this parameter is used globally. Do not change its settings unless you know what you are doing.
        //this setting is used to store information about a user to see if there are allowed to use this app/.
        //This app is only used by admins of the VA no body else.
        /*------------------------------------------------------------------------------------------------------------*/
        /* This mod is for making sure that the user that is logging in is autherized to use the application */
        
        private static bool _isValid;

        public static bool IsValid
        {
            get
            {
                return _isValid;
            }
            set
            {
                _isValid = value;
            }
        }

        /*end of autherized */
        /*----------------------------------------------------------------------------------------------------------------*/

        
    }
}
