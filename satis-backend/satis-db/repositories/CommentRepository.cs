using System;
using satis_db.models;
using satis_db.repository;

namespace satis_db.repositories
{
    public interface ICommentRepository: IBaseRepository<Comment> { }

    public class CommentRepository: BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository()
        {
        }
    }
}
