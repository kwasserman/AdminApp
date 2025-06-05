using AdminModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp.AdminBL
{
    public interface IAdminBL
    {
        //<Summary>
        // Looks all users and saves them
        //<summary>

        List<UserModels> GetAllUsers();
    }
}
