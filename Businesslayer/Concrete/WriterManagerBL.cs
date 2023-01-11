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
    public class WriterManagerBL : IWriterServiceBL
    {
        IWriterDAL _writerDAL;

		public WriterManagerBL(IWriterDAL writerDAL)
		{
			_writerDAL = writerDAL;
		}

		public void WriterDeleteBl(Writer writer)
        {
            throw new NotImplementedException();
        }

        public Writer WriterGetByIdBL(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> WriterGetListBl()
        {
            throw new NotImplementedException();
        }

        public void WriterInsertBl(Writer writer)
        {
            _writerDAL.InsertDAL(writer);
        }

        public void WriterUpdateBl(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
