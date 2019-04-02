using Butcamp2.Interface;
using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2.Application
{
    class TransactionItemController : ITransaction
    {
        private myContext myContext = new myContext();
        DataInformation information = new DataInformation();
        TB_M_Sell sell = new TB_M_Sell();
        TB_T_TransactionItem TransactionItem = new TB_T_TransactionItem();
        ISell isell = new SellController();
        bool status = false;

        public List<TB_T_TransactionItem> Get()
        {
           // throw new NotImplementedException();
            var get = myContext.TB_T_TransactionItem.ToList();
            Console.WriteLine("======================================");
            Console.WriteLine("\t   Data Transaction");
            Console.WriteLine("======================================");
            foreach (var list in get)
            {
                Console.Write("Id            : ");
                Console.WriteLine(list.Id);
                Console.Write("Transaction Name     : ");
                Console.WriteLine(list.TB_M_Items);
                Console.WriteLine("--------------------------------------");
            }
            return get;
        }

        public TB_T_TransactionItem Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_T_TransactionItem TransactionItem)
        {
            throw new NotImplementedException();
            int Quantity, Sell_id, Items_id;
            string date;
            sell.OrderDate = DateTime.Now;
            isell.Insert(sell);

            Console.Write("insert Quantity : ");
            Quantity = Convert.ToInt16(Console.ReadLine());
            Console.Write("insert item ID  : ");
            Items_id = Convert.ToInt16(Console.ReadLine());
            Sell_id = sell.Id;

            TransactionItem.Quantity = Quantity;
            TransactionItem.TB_M_Items_Id = Items_id;
            TransactionItem.TB_M_Sell_Id = Sell_id;

            myContext.TB_T_TransactionItem.Add(TransactionItem);

            return information.Save();
            
        }

        public bool Update(TB_T_TransactionItem TransactionItem)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TB_T_TransactionItem TransactionItem)
        {
            throw new NotImplementedException();
        }
    }
}
