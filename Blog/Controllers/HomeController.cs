using Blog.Data;
using Blog.Data.FileManager;
using Blog.Data.Repository;
using Blog.Models;
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

        public IActionResult Index(string Category)
        {
            var posts = string.IsNullOrEmpty(Category)? _repo.GetAllPost(): _repo.GetAllPost(Category);
            return View(posts);
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
