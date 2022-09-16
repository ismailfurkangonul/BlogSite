using AriBilgi.Blog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.Blog.Entities.Concrete
{
    public class Category:EntityBase,IEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
