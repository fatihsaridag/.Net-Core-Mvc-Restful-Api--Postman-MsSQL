using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Service;

namespace WebApi.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost]
        public ActionResult Create(Posts post)
        {
            var response = _postService.Create(post);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public ActionResult GetPost(int id)
        {
            var response = _postService.GetPost(id);
            return Ok(response);
        }

        public ActionResult GetAll()
        {
            var response = _postService.GetAll();
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePost(int id)
        {
            return Ok(_postService.DeletePost(id));
        }


        [HttpPut("{id}")]
        public ActionResult UpdatePost(int id, Posts post)
        {
            var response = _postService.Update(id, post);
            return Ok(response);
        }
    }
}
