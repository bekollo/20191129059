using System;
using satis_db.models;
using satis_db.repository;

namespace satis_db.repositories
{
    public interface IPostRepository: IBaseRepository<Post> { }

    public class PostRepository: BaseRepository<Post>, IPostRepository
    {
        
    }
}
