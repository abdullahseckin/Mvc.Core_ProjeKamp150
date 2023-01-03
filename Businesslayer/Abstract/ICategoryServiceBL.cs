using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface ICategoryServiceBL
    {
        void CategoryInsertBl(Category category);
        void CategoryDeleteBl(Category category);
        void CategoryUpdateBl(Category category);

        List<Category> CategoryGetListBl();

        Category CategoryGetByIdBL(int id);
    }
}
