using BlogProje.DataAccess;
using BlogProje.DataAccess.Repository.Abstract;
using BlogProje.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProje.Controllers
{
    public class PostController : Controller
    {
        IPostRepository postRepository;
        public PostController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<PostVM> GetPostVMList(List<Post> posts)
        {
            //List<Post> posts = postRepository.GetPosts();
            List<PostVM> postVMs = new List<PostVM>();
            PostVM postVM;

            foreach (Post item in posts)
            {
                postVM = new PostVM()
                {
                    PostId = item.PostId,
                    Title = item.Title,
                    DataOfWriting = item.DateOfWriting.Value,
                    ContentText = item.ContentText,
                    Summary = item.Summary,
                    ReadTime = item.ReadTime.Value,
                    ReadCount = item.ReadCount.Value,
                    UserId = item.UserId.Value,
                    CatId = item.CatId.Value
                };
                postVMs.Add(postVM);
            }
            return postVMs;
        }
        
        public IActionResult GetProducts()
        {
            return Json(GetPostVMList(postRepository.GetPosts()));
        }

        public IActionResult GetPost (int id)
        {
            return Json(postRepository.GetPost(id));
        }
    }
}
