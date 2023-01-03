using Entitylayer.Concrete;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IBlogServiceBL
    {
        void BlogInsertBl(Blog blog);
        void BlogDeleteBl(Blog blog);
        void BlogUpdateBl(Blog blog);

        List<Blog> BloggetListBl();

        Blog BlogGetByIdBL(int id);

    }
}
