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
    public class CategoryController : Controller
    {
        ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        private List<CategoryVM> GetCategoryVMList()
        {
            List<PostCategory> postCategories = categoryRepository.GetPostCategories();
            List<CategoryVM> categoryVMList = new List<CategoryVM>();
            CategoryVM categoryVM;
            foreach (PostCategory item in postCategories)
            {
                categoryVM = new CategoryVM()
                {
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName,
                    PostId = item.PostId
                };
                categoryVMList.Add(categoryVM);
            }
            return categoryVMList;
        }
    }
}
