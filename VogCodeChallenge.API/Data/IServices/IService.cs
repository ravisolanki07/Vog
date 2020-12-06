using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Data.IServices
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        List<T> ListAll();
    }
}