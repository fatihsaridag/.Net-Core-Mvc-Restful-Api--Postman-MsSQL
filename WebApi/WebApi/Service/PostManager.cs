using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Repository;

namespace WebApi.Service
{
    public class PostManager : IPostService
    {
        private readonly IGenericRepository<Posts> _repository;

        public PostManager(IGenericRepository<Posts> repository)
        {
            _repository = repository;
        }

        public Posts Create(Posts post)
        {
            //Bir çok işlem olabilir.
            return _repository.Add(post);
        }

        public Posts DeletePost(int id)
        {
            var deletePost = _repository.GetById(id);
            return _repository.Delete(deletePost);
        }

        public List<Posts> GetAll()
        {
            return _repository.GetAll();
        }

        public Posts GetPost(int id)
        {
            return _repository.GetById(id);
        }

        public Posts Update(int id, Posts post)
        {
            return _repository.UpdateById(post, id);
        }
    }
}
