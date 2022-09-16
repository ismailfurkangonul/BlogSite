using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AriBilgi.Blog.Data.Abstract
{
    public interface IUnitOfWork
    {
        IArticleRepository Articles { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IUserRepository Users { get; }
        IUserRoleRepository UserRoles { get; }

        Task<int> SaveAsync();
    }
}
