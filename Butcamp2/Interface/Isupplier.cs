using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butcamp2.Models;

namespace Butcamp2
{
    public interface Isupplier
    {
        List<TB_M_Supplier> GetData();
        TB_M_Supplier Get(int id);
        bool InsertSupplier( TB_M_Supplier supplier);
        bool UpdateSupplier( int id, TB_M_Supplier supplier);
        bool DeleteSupplier( int id);
    }
}
