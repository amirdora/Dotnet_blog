using Blog.Models;
using Blog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _ctx;

        public Repository(AppDbContext ctx)
        {
            _ctx = ctx;

        }

        public void AddPost(Post post)
        {
            _ctx.Posts.Add(post);
        }

        public List<Post> GetAllPost()
        {
            return _ctx.Posts.ToList();
        }

        public IndexViewModel GetAllPost(int PageNumber, string Category)
        {
            Func<Post, bool> InCategory = (post) => { return post.Category.ToLower().Equals(Category.ToLower()); };

            int pageSize = 2;
         
            int skipAmount = pageSize * (PageNumber - 1);
            var query = _ctx.Posts.AsQueryable(); // take only 2 posts

            if (!String.IsNullOrEmpty(Category))
            {
                query = query.Where(x => InCategory(x));
            }

            int postsCount = query.Count();

            return new IndexViewModel
            {
                PageNumber = PageNumber,
                PageCount = (int) Math.Ceiling( (Double) postsCount / pageSize),
                NextPage = postsCount > skipAmount + pageSize,
                Category = Category,
                Posts = query
                    .Skip(skipAmount)
                    .Take(pageSize)
                    .ToList()
            };
    }
    public Post GetPost(int id)
    {
        return _ctx.Posts.FirstOrDefault(m => m.Id == id);
    }

    public void RemovePost(int id)
    {
        _ctx.Posts.Remove(GetPost(id));
    }

    public void UpdatePost(Post post)
    {
        _ctx.Posts.Update(post);
    }
    public async Task<bool> SaveChangesAsync()
    {
        if (await _ctx.SaveChangesAsync() > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
}
