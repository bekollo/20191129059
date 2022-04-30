using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using satis_core.Helpers;
using satis_db.dtos;
using satis_db.models;
using satis_db.repositories;
using Microsoft.AspNetCore.Mvc;

namespace satis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(
            ICategoryRepository categoryRepository
            )
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<CategoryDto>> GetCategories()
        {
            var categories = (await _categoryRepository.GetAllActive()).ToList();

            var result = AppMapper.Map<List<CategoryDto>>(categories);

            return result;
        }

        [HttpPost]
        [Route("")]
        public async Task<CategoryDto> CreateCategory(CategoryDto dto)
        {
            var entity = AppMapper.Map<Category>(dto);

            var categoryId = await _categoryRepository.Insert(entity);

            dto.Id = categoryId;

            return dto;
        }
    }
}
