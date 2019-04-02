using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2.Interface
{
    interface ITransaction
    {
        List<TB_T_TransactionItem> Get();
        TB_T_TransactionItem Get(int id);
        bool Insert(TB_T_TransactionItem TransactionItem);
        bool Update(TB_T_TransactionItem TransactionItem);
        bool Delete(TB_T_TransactionItem TransactionItem);
    }
}
