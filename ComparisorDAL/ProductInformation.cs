using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
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


        public static ProductModel GetProductInfoById(int productId)
        {
            try
            {
                using (var pce = new ProductBaseEntities())
                {

                    var productInfo = pce.ProductInformations.FirstOrDefault(m => m.Id == productId && m.IsActive);

                    if (productInfo != null)
                        return new ProductModel()
                        {
                            PDesc = productInfo.ProductDesc,
                            PId = productInfo.Id,
                            PImageUrl = productInfo.ProductImgUrl,
                            PName = productInfo.ProductName,
                            CategoryId = productInfo.CategoryId,
                            IsActive = productInfo.IsActive,
                            Price = productInfo.Price
                        };
                }
            }
            catch (Exception ex)
            {
                return new ProductModel();
            }

        }

    }
}
