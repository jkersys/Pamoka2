using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_054_DB_Mutation.Services
{
    public class BlogService
    {
        private readonly ManageDb _manageDb;

        private BlogService(ManageDb manageDb)
        {
            _manageDb = manageDb;
        }
        public List<Blog> GetBlogs()
        {
            var res = _manageDb.GetBlogs();
            return res
        }
    }
}
