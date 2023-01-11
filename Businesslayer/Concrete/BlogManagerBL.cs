using Businesslayer.Abstract;
using DataAccessLayer.Abstract;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Concrete
{
    public class BlogManagerBL : IBlogServiceBL
    {
        IBlogDAL _blogDAL;

		public BlogManagerBL(IBlogDAL blogDAL)
		{
			_blogDAL = blogDAL;
		}

		public void BlogDeleteBl(Blog blog)
        {
            _blogDAL.DeleteDAL(blog);
        }

        public Blog BlogGetByIdBL(int id)
        {
            return _blogDAL.GetByIdDAL(id);
        }

        public List<Blog> BlogGetListBl()
        {
            return _blogDAL.GetListAllDAL();
        }

		public List<Blog> BlogGetByIdListBl(int id)//aynı ısım old ıcın BlogServicede karsılıgı yok
		{
			return _blogDAL.GetListAllDAL(x=>x.BlogId==id);
		}

		public void BlogInsertBl(Blog blog)
        {
            _blogDAL.InsertDAL(blog);
        }

        
        public void BlogUpdateBl(Blog blog)
        {
            _blogDAL.UpdateDAL(blog);
        }

		public List<Blog> GetListWithCategoryBL()
		{
			return _blogDAL.GetListWithCategoryDAL();
		}

		public List<Blog> GetListByWriterBL(int id)
		{
            //37v
            return _blogDAL.GetListAllDAL(x=>x.WriterID==id);
		}
	}
}
