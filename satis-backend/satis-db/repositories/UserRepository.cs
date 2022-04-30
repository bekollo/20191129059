using System;
using satis_db.models;
using satis_db.repository;

namespace satis_db.repositories
{
    public interface IUserRepository : IBaseRepository<User> { }

    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository()
        {
            
        }
    }
}
