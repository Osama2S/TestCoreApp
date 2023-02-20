﻿using Microsoft.AspNetCore.Mvc;
using TestCoreApp.Models;
using TestCoreApp.Repository.Base;

namespace TestCoreApp.Controllers
{
    public class CategoryController : Controller
    {
        public CategoryController(IRepository<Category> repository) 
        {
           _repository = repository;
        }

        private IRepository<Category> _repository;

        public IActionResult Index()
        {
            return View(_repository.FindAll());
        }
    }
}
