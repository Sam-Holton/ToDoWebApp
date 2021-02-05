using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Models;
using ToDoWebApp.Models.DALModels;
using ToDoWebApp.Services;

namespace ToDoWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ToDoWebAppContext _toDoWebAppContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ToDoWebAppContext toDoWebAppContext)
        {
            _toDoWebAppContext = toDoWebAppContext;
            _logger = logger;
        }

        public IActionResult Login()
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            ToDoUsersDAL toDoUsersDAL = _toDoWebAppContext.ToDoUsers
                .Where(toDoUsersDAL => toDoUsersDAL.UserName == loginViewModel.UserName && toDoUsersDAL.UserPassword == loginViewModel.UserPassword)
                .FirstOrDefault();

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private ToDoUsersDAL GetUserWhereIdIsFirstOrDefault(int id)
        {
            ToDoUsersDAL toDoUsersDAL = _toDoWebAppContext.ToDoUsers
                .Where(toDoUsersDAL => toDoUsersDAL.UserID == id)
                .FirstOrDefault();            

            return toDoUsersDAL;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
