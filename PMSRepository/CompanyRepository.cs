using PMSEntity;
using PMSInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSRepository
{
    class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        public List<Company> Search(string keyword)
        {
            try
            {
                return this.GetAll().Where(c => c.CompanyName.Contains(keyword)).ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
