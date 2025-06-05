using AdminModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DL
{
    public interface IRepository
    {
        List<UserModels> GetAllUsers();
    }
    

}
