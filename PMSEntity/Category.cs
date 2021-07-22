using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSEntity
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public string ProductCategoryDetails { get; set; }
        public long CompanyId { get; set; }
    }
}
