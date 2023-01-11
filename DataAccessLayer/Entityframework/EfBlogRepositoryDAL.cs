using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using Entitylayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entityframework
{
	public class EfBlogRepositoryDAL : GenericRepositoryDAL<Blog>, IBlogDAL
	{
		public List<Blog> GetListWithCategoryDAL()
		{
			using(var db=new Context())
			{
				//return db.Blogs.ToList();  yerine İnclude Metodu gelecek

				return db.Blogs.Include(x=>x.Category).ToList();
			}
		}
	}
}
