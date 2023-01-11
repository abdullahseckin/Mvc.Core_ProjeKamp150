using Businesslayer.Concrete;
using DataAccessLayer.Entityframework;
using Microsoft.AspNetCore.Mvc;

namespace A_MvcProje_UI.Controllers
{
    public class BlogController : Controller
    {
		BlogManagerBL bm = new BlogManagerBL(new EfBlogRepositoryDAL());
		public IActionResult Index()
        {
           
            var valBlg=bm.GetListWithCategoryBL();

            return View(valBlg);
        }
        public IActionResult BlogReadAll(int id)
        {

            ViewBag.i=id;
            var valblog = bm.BlogGetByIdListBl(id);

            return View(valblog);
        }
    }
}
