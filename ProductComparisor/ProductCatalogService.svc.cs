using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessClasses;
using ComparisorDAL;

namespace ProductComparisor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ProductCatalogService : IProductCatalogService
    {
        /// <summary>
        /// used to get All products
        /// </summary>
        /// <returns></returns>
        public List<ProductModel> GetProducts()
        {
            try
            {
                return ProductInformation.GetAllProducts();
            }
            catch (Exception ex)
            {
                return new List<ProductModel>();
            }
        }

        /// <summary>
        /// used to get product by product ID
        /// </summary>
        /// <param name="pId"></param>
        /// <returns></returns>
        public ProductModel GetProductInfoById(string pId)
        {
            return new ProductModel() { PDesc = "DESC", PId = 1, PImageUrl = "www.google.com", PName = "P1" };
        }
    }
}
