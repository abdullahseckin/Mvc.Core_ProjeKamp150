using Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Abstract
{
    public interface IWriterServiceBL
    {
        void WriterInsertBl(Writer writer);
        void WriterDeleteBl(Writer writer);
        void WriterUpdateBl(Writer writer);

        List<Writer> WriterGetListBl();

        Writer WriterGetByIdBL(int id);
    }
}
