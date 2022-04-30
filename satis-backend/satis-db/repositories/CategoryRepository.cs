using System;
using satis_db.models;
using satis_db.repository;

namespace satis_db.repositories
{
    public interface ICategoryRepository: IBaseRepository<Category> { }

    public class CategoryRepository: BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository()
        {
        }
    }
}
