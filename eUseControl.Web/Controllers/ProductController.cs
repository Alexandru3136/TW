using System.Collections.Generic;
using System.Web.Mvc;
using eUseControl.BusinessLogic;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Product;

namespace eUseControl.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _product;

        public ProductController()
        {
            var bl = new BussinesLogic();
            _product = bl.GetProductBL();
        }

        // GET: Product
        public ActionResult Index()
        {
            List<ProductData> products = _product.GetProductList();
            return View();
        }

        public ActionResult MyOrder()
        {
            int UserId = 1;
            List<ProductData> products = _product.GetOrdersByUser(UserId);
            return View();
        }
    }
}