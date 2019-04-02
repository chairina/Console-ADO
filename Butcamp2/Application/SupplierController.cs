using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2
{
    class SupplierController : DataInformation, Isupplier
    {
        public static myContext myContext = new myContext();
        TB_M_Supplier supplier = new TB_M_Supplier();
        DataInformation information = new DataInformation(myContext);
        bool status = false;
        //Isupplier isupplier;

        public bool DeleteSupplier(int id)
        {
            //throw new NotImplementedException();
            Console.Write("Insert your ID : ");
            id = Convert.ToInt16(Console.ReadLine());
            supplier = Get(id);
            if (supplier != null)
            {
                myContext.Entry(supplier).State = EntityState.Deleted;
                //var result = mycontext.SaveChanges();
                return information.Save();
            }
            else
            {
                Console.Write("No data found");
            }
            return status;
        }

        public TB_M_Supplier Get (int id)
        {
           // throw new NotImplementedException();
            var get = myContext.TB_M_Supplier.Find(id);

            return get;
        }

        public List<TB_M_Supplier> GetData()
        {
          //  throw new NotImplementedException();
            var get = myContext.TB_M_Supplier.Where(x => x.isDelete == false).ToList();
            Console.WriteLine("======================================");
            Console.WriteLine("\t   Data Supplier");
            Console.WriteLine("======================================");
            foreach (var list in get)
            {
                Console.Write("Id            : ");
                Console.WriteLine(list.Id);

                Console.Write("Supplier Name : ");
                Console.WriteLine(list.name);
                Console.WriteLine("-----------------------------------");
            }
            return get;
        }

        public bool InsertSupplier (TB_M_Supplier supplier)
        {
            //throw new NotImplementedException();
            Console.Write("Insert supplier name : ");
            string Name = Console.ReadLine();
            supplier.name = Name;
            myContext.TB_M_Supplier.Add(supplier);
            //var result = (mycontext.SaveChanges());
            return information.Save();
            return status;
        }

        public bool UpdateSupplier(int id, TB_M_Supplier supplier)
        {
            //throw new NotImplementedException();
            Console.Write("Insert your ID : ");
            id = Convert.ToInt16(Console.ReadLine());
            supplier = Get(id);
            if (supplier != null)
            {
                Console.Write("Insert your name : ");
                String name = Console.ReadLine();
                supplier.name = name;
                myContext.Entry(supplier).State = EntityState.Modified;
                //var result = mycontext.SaveChanges();
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
