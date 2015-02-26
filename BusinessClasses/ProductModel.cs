using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessClasses
{
    public class ProductModel
    {
        public Int64 PId { set; get; }
        public string PName { set; get; }
        public string PDesc { set; get; }
        public string PImageUrl { set; get; }
        public int CategoryId { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
