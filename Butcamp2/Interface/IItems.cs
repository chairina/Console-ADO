using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2
{
    interface IItems
    {
        List<TB_M_Items> Get();
        TB_M_Items Get(int id);
        bool Insert(TB_M_Items items);
        bool Update(int id, TB_M_Items items);
        bool Delete(int id);
    }
}
