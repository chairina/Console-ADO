using Butcamp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butcamp2
{
    class DataInformation
    {
        public static myContext myContext = new myContext();

        public DataInformation (myContext _myContext)
        {
            myContext = _myContext;
        }

        public DataInformation()
        {

        }
        public bool Save()
        {
            bool status;
            var result = myContext.SaveChanges();
            if (result > 0)
            {
                status = true;
                Console.Write("Operation Success");
            }
            else
            {
                status = false;
                Console.Write("Operation Failed");
            }
            return status;
        }

    }
}
