using Blog.Data;
using Blog.Data.FileManager;
using Blog.Data.Repository;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileMgr;

        public HomeController(IRepository Repo, IFileManager fileMgr)
        {
            _repo = Repo;
            _fileMgr = fileMgr;
        }

        public IActionResult Index(int PageNumber, string Category)
        {
            if (PageNumber < 1)
            {
                return RedirectToAction("Index", new { PageNumber = 1, Category });
            }

            var vm = _repo.GetAllPost(PageNumber, Category);

            return View(vm);
        }
        public IActionResult Post(int id)
        {
            var post = _repo.GetPost(id);
            return View(post);
        }
        [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.') +1);
            return new FileStreamResult(_fileMgr.ImageStream(image), $"image/{mime}");
        }
    }
}
