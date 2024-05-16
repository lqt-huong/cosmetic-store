using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValueObject;

namespace BLL
{
    
    public class ProductDetailBLL
    {
        static ThongTinSanPhamDAL spdal;
        public ProductDetailBLL()
        {
            spdal = new ThongTinSanPhamDAL();
        }
        public List<ProductVariety> GetAllProductVariety()
        {
            return spdal.GetAllProductVariety();
        }
    }
    
}
