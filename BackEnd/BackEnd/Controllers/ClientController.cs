using BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            List<Client> clientsList = new List<Client>();

            // Connect to Mysql.
            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root=database="))

            return View();
        }
    }
}
