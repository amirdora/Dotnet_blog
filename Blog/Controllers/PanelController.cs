using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data.FileManager;
using Blog.Data.Repository;
using Blog.Models;
using Blog.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PanelController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileMgr;

        public PanelController(IRepository Repo, IFileManager fileMgr)
        {
            _repo = Repo;
            _fileMgr = fileMgr;

        }

        public IActionResult Index()
        {
            var posts = _repo.GetAllPost();
            return View(posts);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {

            if (id == null)
            {
                return View(new PostViewModel());
            }
            else
            {
                var post = _repo.GetPost((int)id);
                return View(new PostViewModel
                {
                    Id = post.Id,
                    Title = post.Title,
                    Body = post.Body,
                    Description = post.Description,
                    Tags = post.Tags,
                    Category = post.Category,
                    CurrentImage = post.Image

                });
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PostViewModel vm)
        {
            var post = new Post
            {
                Id = vm.Id,
                Title = vm.Title,
                Description = vm.Description,
                Tags = vm.Tags,
                Category = vm.Category,
                Body = vm.Body,
            };

            if (vm.Image == null)
            {
                post.Image = vm.CurrentImage;
            } else
            {
                post.Image = await _fileMgr.SaveImage(vm.Image);
            }

            if (post.Id > 0)
                _repo.UpdatePost(post);
            else
                _repo.AddPost(post);

            if (await _repo.SaveChangesAsync())
                return RedirectToAction("Index");
            else
                return View(post);
        }
        [HttpGet]
        public async Task<IActionResult> Remove(int id)
        {
            _repo.RemovePost(id);

            await _repo.SaveChangesAsync();
            return RedirectToAction("Index");

        }
    }
}
