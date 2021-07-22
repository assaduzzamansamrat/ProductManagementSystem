using PMSEntity;
using PMSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSRepository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public List<Category> Search(string keyword)
        {
            try
            {
                return this.GetAll().Where(c => c.Name.Contains(keyword)).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

    }
}
