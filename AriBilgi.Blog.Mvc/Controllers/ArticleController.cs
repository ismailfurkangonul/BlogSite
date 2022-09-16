using AriBilgi.Blog.Data.Abstract;
using AriBilgi.Blog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AriBilgi.Blog.Mvc.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArticleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Add()
        {
            return View();
        }
        public List<Category> GetCategoryList()
        {
            return _unitOfWork.Categories.GetAllAsync();

        }
        [HttpPost]
        public bool AddArticle([FromBody] Article article)
        {


            try
            {
                _unitOfWork.Articles.AddAsync(article);
                _unitOfWork.SaveAsync();

                return true;
            }
            catch (System.Exception)
            {

                return false;

            }
        }
    }
}
