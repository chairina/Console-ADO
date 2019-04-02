using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu1;
            //Isupplier isupplier;
            TB_M_Supplier supplier = new TB_M_Supplier();
            TB_M_Items items = new TB_M_Items();
            //isupplier = new SupplierController();

            Menu menu = new Menu();

            Console.WriteLine("");
            Console.WriteLine("======================================");
            Console.WriteLine("\t|| Menu Transaction || ");
            Console.WriteLine("======================================");
            Console.WriteLine(" \n Make your choice: \n");
            Console.WriteLine(" 1. Supplier");
            Console.WriteLine(" 2. Items");
            Console.WriteLine(" 3. Sell");
            Console.WriteLine(" 4. TransactionItems");
            Console.WriteLine("--------------------------------------");
            Console.Write(" Your choice :  ");
            int n = Convert.ToInt16(Console.ReadLine());
            switch (n)
            {
                case 1:
                    menu1 = menu.MenuSupplier();
                    break;
                case 2:
                    menu1 = menu.MenuItems();
                    break;



            }
            Console.Read();
        }
        public class Menu
        {
            public int MenuSupplier()
            {
                int n;
                int id = 0;
                Isupplier isupplier;
                TB_M_Supplier supplier = new TB_M_Supplier();
                isupplier = new SupplierController();

                Console.WriteLine("");
                Console.WriteLine("======================================");
                Console.WriteLine("\t|| Menu Supplier|| ");
                Console.WriteLine("======================================");
                Console.WriteLine(" \n Make your choice: \n");
                Console.WriteLine(" 1. View All ");
                Console.WriteLine(" 2. Insert new data ");
                Console.WriteLine(" 3. Edit data ");
                Console.WriteLine(" 4. Delete data ");
                Console.WriteLine("--------------------------------------");
                Console.Write(" Your choice :  ");
                n = Convert.ToInt16(Console.ReadLine());
                if (n == 1)
                {
                    isupplier.GetData();
                }
                else if (n == 2)
                {
                    isupplier.InsertSupplier(supplier);
                }
                else if (n == 3)
                {
                    isupplier.UpdateSupplier(id, supplier);
                }
                else if (n == 4)
                {
                    isupplier.DeleteSupplier(id);
                }
                else
                {
                    Console.Write("Only 1 - 4");
                }
                return n;
            }

            public int MenuItems()
            {
                int n;
                int id = 0;
                IItems iitem;
                TB_M_Items items = new TB_M_Items();
                iitem = new ItemsController();

                Console.WriteLine("");
                Console.WriteLine("======================================");
                Console.WriteLine("\t   || Menu Items|| ");
                Console.WriteLine("======================================");
                Console.WriteLine(" \n Make your choice: \n");
                Console.WriteLine(" 1. View All ");
                Console.WriteLine(" 2. Insert new data ");
                Console.WriteLine(" 3. Edit data ");
                Console.WriteLine(" 4. Delete data ");
                Console.WriteLine("--------------------------------------");
                Console.Write(" Your choice :  ");
                n = Convert.ToInt16(Console.ReadLine());
                if (n == 1)
                {
                    iitem.Get();
                }
                else if (n == 2)
                {
                    iitem.Insert(items);
                }
                else if (n == 3)
                {
                    iitem.Update(id, items);
                }
                else if (n == 4)
                {
                    iitem.Delete(id);
                }
                else
                {
                    Console.Write("Only 1 - 4");
                }
                return n;
            }

        }
    }
    }

