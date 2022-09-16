using AriBilgi.Blog.Data.Abstract;
using AriBilgi.Blog.Entities.Concrete;
using AriBilgi.Blog.Mvc.Models.Home;
using AriBilgi.Blog.Shared.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AriBilgi.Blog.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            _unitOfWork.UserRoles.AddAsync(new UserRole
            { 
                


                });
           
            return View();
        }
        [HttpPost]
        public List<UserDTO>GetUserList()
        {
            List<User> userList = _unitOfWork.Users.GetAllAsync();
            List<UserDTO> userDTOList = new();
            foreach (User item in userList)
            {
                userDTOList.Add(new UserDTO
                {

                    Id =(int)item.Id,
                    ArticleCount = _unitOfWork.Articles.CountAsync(x => x.UserId == item.Id),
                    CommentCount = _unitOfWork.Comments.CountAsync(x => x.UserId == item.Id),
                    NameSurname = item.Name + "" + item.Surname,
                    Role = _unitOfWork.UserRoles.GetAsync(x => x.Id == item.UserRoleId).Title



                });

            }
            userList = null;
            return userDTOList;


        }
        [HttpPost]
        public List<CategoryDTO> GetCategoryList()
        {
            List<Category> categoryList = _unitOfWork.Categories.GetAllAsync();
            List<CategoryDTO> categoryDTOList = new();
            foreach (Category item in categoryList)
            {
                categoryDTOList.Add(new CategoryDTO
                {
                    Id = (int) item.Id,
                    ArticleCount = _unitOfWork.Articles.CountAsync(x => x.CategoryId == item.Id),
                    Name = item.Title


                });


            }

            categoryList = null;

            return categoryDTOList;


        }
        [HttpPost]
        public List<ArticleDTO> GetArticleList()
        {
            List<Article> articleList = _unitOfWork.Articles.GetAllAsync();
            List<ArticleDTO> articleDTOList = new();
            foreach (Article item in articleList)
            {
                articleDTOList.Add(new ArticleDTO
                {
                    Id = (int)item.Id,
                    CommentCount= _unitOfWork.Comments.CountAsync(x => x.ArticleId == item.Id),
                    CategoryName= _unitOfWork.Categories.GetAsync(x => x.Id == item.CategoryId).Title,
                    Name = item.Title


                });


            }
            articleList = null;

            return articleDTOList;


        }
    }
}
