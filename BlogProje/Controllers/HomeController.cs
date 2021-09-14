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
    public class HomeController : Controller
    {
        ICategoryRepository categoryRepository;
        IUserRepository userRepository;
        IPostRepository postRepository;
        public HomeController(ICategoryRepository categoryRepository, IPostRepository postRepository, IUserRepository userRepository)
        {
            this.categoryRepository = categoryRepository;
            this.userRepository = userRepository;
            this.postRepository = postRepository;
        }
        public IActionResult Index(int? id = null)
        {
            List<PostVM> postListe = new List<PostVM>();
            if (id == null)
            {
                postListe = GetPostVMList(postRepository.GetPosts());
            }
            PostListVM postListVM = new PostListVM();
            postListVM.Posts = postListe;
            return View(postListVM);
        }

        public IActionResult About()
        {
            return View();
        }

        private List<PostVM> GetPostVMList (List<Post> postList)
        {
            List<PostVM> postVMList = new List<PostVM>();
            PostVM postVM;
            foreach (Post item in postList)
            {
                postVM = new PostVM()
                {
                    PostId = item.PostId,
                    Title = item.Title,
                    ContentText = item.ContentText,
                    Summary = item.Summary
                    
                };
                postVMList.Add(postVM);

            }
            return postVMList;
        }

       
    }
}
