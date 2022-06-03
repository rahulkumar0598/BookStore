using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class HomeController1 : Controller
    {
        public string GetAllBooks()
        {
            return "these are all books";
        }
        public string GetBook(int id)
        {
            return $"book with id {id}";
        }

    }
}
