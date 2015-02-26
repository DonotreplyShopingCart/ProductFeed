using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BusinessClasses;

namespace ProductComparisor
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ProductCatalogService : IProductCatalogService
    {

        public List<ProductModel> GetProducts()
        {
            return new List<ProductModel>()
            {
                new ProductModel(){PDesc = "DESC",PId = 1,PImageUrl = "www.google.com",PName = "P1"},
                new ProductModel(){PDesc = "DESC2",PId = 2,PImageUrl = "www.yahoo.com",PName = "P2"},
                new ProductModel(){PDesc = "DESC3",PId = 3,PImageUrl = "www.Amazon.com",PName = "P3"}
            };
        }

        public ProductModel GetProductInfoById(string pId)
        {
           return new ProductModel() {PDesc = "DESC", PId = 1, PImageUrl = "www.google.com", PName = "P1"};
        }
    }
}
