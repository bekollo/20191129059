using System.Collections.Generic;
using System.Threading.Tasks;
using satis_db.dtos;
using satis_db.repositories;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using satis_core.Helpers;
using satis_db.models;

namespace satis_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostController
    {
        private readonly IPostRepository _postRepository;

        public PostController(
            IPostRepository postRepository
            )
        {
            _postRepository = postRepository;
        }

        [HttpGet]
        [Route("")]
        public async Task<List<PostDto>> GetPosts()
        {
            var posts = (await _postRepository.GetAllActive()).ToList();

            var result = AppMapper.Map<List<PostDto>>(posts);

            return result;
        }

        [HttpPost]
        [Route("")]
        public async Task<PostDto> CreatePost([FromBody]PostDto postDto)
        {
            var entity = AppMapper.Map<Post>(postDto);

            var result = await _postRepository.Insert(entity);

            postDto.Id = result;

            return postDto;
        }
    }
}
