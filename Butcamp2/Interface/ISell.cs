using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2.Interface
{
    interface ISell
    {
        List<TB_M_Sell> Get();
        TB_M_Sell Get(int id);
        bool Insert(TB_M_Sell sell);

    }
}
