using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebApp.Models.DALModels;

namespace ToDoWebApp.Services
{
    public class ToDoWebAppContext : DbContext
    {
        public ToDoWebAppContext(DbContextOptions<ToDoWebAppContext> options) : base(options)
        {

        }

        public DbSet<ToDoItemsDAL> ToDoItems { get; set; }
        public DbSet<ToDoUsersDAL> ToDoUsers { get; set; }
    }    
}
