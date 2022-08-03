using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Service
{
    public interface IPostService
    {
        Posts Create(Posts post);
        Posts GetPost(int id);
        List<Posts> GetAll();
        Posts DeletePost(int id);
        Posts Update(int id, Posts post);
    }
}
