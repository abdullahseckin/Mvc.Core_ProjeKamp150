using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IAboutServiceBL
    {
        void AboutInsertBl(About about);
        void AboutDeleteBl(About about);
        void AboutUpdateBl(About about);

        List<About> AboutgetListBl();

        About AboutGetByIdBL(int id);

    }
}
