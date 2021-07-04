using PMSEntity;
using PMSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSRepository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public List<Product> Search(string keyword)
        {
            return this.GetAll().Where(p => p.Name.Contains(keyword)).ToList();
        }
    }
}
