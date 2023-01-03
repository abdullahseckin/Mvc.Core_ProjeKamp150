using Businesslayer.Abstract;
using DataAccessLayer.Entityframework;
using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Concrete
{
    public class CategoryManagerBL : ICategoryServiceBL
    {
        // 20.video ilk görev tamamlandı
        EfCategoryRepositoryDAL _efCategoryRepositoryDAL;
        public CategoryManagerBL()
        {
            _efCategoryRepositoryDAL= new EfCategoryRepositoryDAL();
        }

        public void CategoryDeleteBl(Category category)
        {
            throw new NotImplementedException();
        }

        public Category CategoryGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> CategoryGetListBl()
        {
            throw new NotImplementedException();
        }

        public void CategoryInsertBl(Category category)
        {
            _efCategoryRepositoryDAL.InsertDAL(category);
        }

        public void CategoryUpdateBl(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
