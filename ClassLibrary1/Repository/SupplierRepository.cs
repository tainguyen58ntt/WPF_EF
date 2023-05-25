using ClassLibrary1.BussinessObject;
using ClassLibrary1.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Repository
{
    public class SupplierRepository : ISupplier
    {
        public List<Supplier> GetSuppliers()
        {
            return SupplierManagement.Instance.GetSuppliers();
        }
    }
}
