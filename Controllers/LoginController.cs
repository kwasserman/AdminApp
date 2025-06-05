using System;
using AdminModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Drawing;
using AdminSetting;
using AdminApp.AdminBL;
namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]


    public class LoginController : ControllerBase
    {
        private readonly IAdminBL repo;
        //<summary>
        // Gets all users and thier rank
        //<summary>
        public LoginController(IAdminBL p_isAdminBL)
        {
            repo = p_isAdminBL;
        }
        [HttpGet("GetAllUsers")]
        public IActionResult GetAllUsers([FromQuery] string username, string password)
        {

            return Ok(repo.GetAllUsers());
        }
    }
}
