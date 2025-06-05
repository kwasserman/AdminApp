using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminModels;
using DL;

namespace AdminApp.AdminBL
{
    public class AdminBL : IAdminBL
    {
        /// Summary 
        /// The injection below allows functions to do what i need them to do
        /// Summary
        /// 
        private readonly IRepository _repo;
        public AdminBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public List<UserModels> GetAllUsers()
        {
            return _repo.GetAllUsers();
        }
    }
}
