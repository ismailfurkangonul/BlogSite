using AriBilgi.Blog.Data.Abstract;
using AriBilgi.Blog.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AriBilgi.Blog.Mvc.Controllers
{
    public class CategoryController : Controller

        
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public bool AddCategory([FromBody]Category category)
        {


            try
            {
                _unitOfWork.Categories.AddAsync(category);
                _unitOfWork.SaveAsync();

                return true;
            }
            catch(System.Exception)
            {

                return false;

            }
        }
    }
}
