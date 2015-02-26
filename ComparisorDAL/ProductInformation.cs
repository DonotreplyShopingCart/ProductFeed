using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessClasses;
using EntityProject;

namespace ComparisorDAL
{
    public class ProductInformation
    {
        /// <summary>
        /// Used to get all the products.
        /// </summary>
        /// <returns></returns>
        public static List<ProductModel> GetAllProducts()
        {
            try
            {
                using (var pce = new ProductBaseEntities())
                {
                    return pce.ProductInformations.Where(m => m.IsActive).Select(m => new ProductModel()
                    {
                        PDesc = m.ProductDesc,
                        PId = m.Id,
                        PImageUrl = m.ProductImgUrl,
                        PName = m.ProductName,
                        CategoryId = m.CategoryId,
                        IsActive = m.IsActive,
                        Price = m.Price
                    }).ToList();
                }

            }
            catch (Exception ex)
            {
                return new List<ProductModel>();
            }
        }



    }
}
