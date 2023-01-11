using Businesslayer.Abstract;
using DataAccessLayer.Abstract;
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

        ICategoryDAL _categoryDAL;

        public CategoryManagerBL(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void CategoryDeleteBl(Category category)
        {
            _categoryDAL.DeleteDAL(category);
        }

        public Category CategoryGetByIdBL(int id)
        {
            return _categoryDAL.GetByIdDAL(id);
        }

        public List<Category> CategoryGetListBl()
        {
            return _categoryDAL.GetListAllDAL();
        }

        public void CategoryInsertBl(Category category)
        {
            _categoryDAL.InsertDAL(category);
        }

        public void CategoryUpdateBl(Category category)
        {
            _categoryDAL.UpdateDAL(category);
        }
    }
}
