using PMSEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSInterface
{
    public interface ICompanyRepository : IRepository<Company>
    {
        List<Company> Search(string keyword);
    }
}
