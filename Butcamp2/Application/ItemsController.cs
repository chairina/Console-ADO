using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2
{
    class ItemsController : DataInformation, IItems
    {
        public static myContext myContext = new myContext();
        DataInformation information = new DataInformation(myContext);
        TB_M_Items item = new TB_M_Items();
        bool status = false;

        public List<TB_M_Items> Get()
        {
           // throw new NotImplementedException();
            var get = myContext.TB_M_Items.Where(x => x.isDelete == false).ToList();
            Console.WriteLine("======================================");
            Console.WriteLine("\t   Data Items");
            Console.WriteLine("======================================");
            foreach (var list in get)
            {
                Console.Write("Id            : ");
                Console.WriteLine(list.Id);
                Console.Write("Item Name     : ");
                Console.WriteLine(list.name);
                Console.WriteLine("--------------------------------------");
            }
            return get;
        }

        public TB_M_Items Get(int id)
        {
           // throw new NotImplementedException();
            var get = myContext.TB_M_Items.Find(id);
            
            return get;
        }

        public bool Insert(TB_M_Items items)
        {
            //throw new NotImplementedException();
            Console.Write("Insert items name : ");
            string Name = Console.ReadLine();

            Console.Write("Insert Supplier ID : ");
            int Supplier_id = Convert.ToInt16(Console.ReadLine());
            var getSupplier = myContext.TB_M_Supplier.Find(Supplier_id);

            if (getSupplier != null)
            {
                Console.Write("Insert price : ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Insert stock : ");
                int stock = Convert.ToInt32(Console.ReadLine());
                item.name = Name;
                item.TB_M_Supplier = getSupplier;
                item.Price = price;
                item.Stock = stock;
                myContext.TB_M_Items.Add(item);
                //var result = myContext.SaveChanges();
                return information.Save();
            }
            else
            {
                Console.Write("No data found");
            }

            return status;
        }

        public bool Update(int id, TB_M_Items items)
        {
            //throw new NotImplementedException();
            Console.Write("Insert your id : ");
            id = Convert.ToInt16(Console.ReadLine());
            item = Get(id);
            if (item != null)
            {
                Console.Write("Insert your name : ");
                String name = Console.ReadLine();
                item.name = name;
                myContext.Entry(item).State = EntityState.Modified;
                var result = myContext.SaveChanges();
                return information.Save();
            }
            else
            {
                Console.Write("No data found");
            }
            return status;
        }

        public bool Delete(int id)
        {
           // throw new NotImplementedException();
            Console.Write("Insert your id : ");
            id = Convert.ToInt16(Console.ReadLine());
            item = Get(id);
            if (item != null)
            {
                myContext.Entry(item).State = EntityState.Deleted;
                var result = myContext.SaveChanges();
                return information.Save();
            }
            else
            {
                Console.Write("No data found");
            }
            return status;
        }
    }
}
