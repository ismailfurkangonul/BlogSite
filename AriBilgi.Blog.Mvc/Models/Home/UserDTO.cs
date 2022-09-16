namespace AriBilgi.Blog.Mvc.Models.Home
{
    public class UserDTO
    {
        public int Id { get; set; } 
        public string NameSurname { get; set; }    
        public int CommentCount { get; set; }
        public int ArticleCount { get; set; }
        public string Role { get; set; }

    }
}
