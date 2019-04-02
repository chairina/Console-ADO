using Butcamp2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Butcamp2.Models;

namespace Butcamp2.Application
{
    class SellController : ISell
    {
        public static myContext myContext = new myContext();
        TB_M_Sell sell = new TB_M_Sell();
        DataInformation information = new DataInformation(myContext);
        bool status = false;
        public List<TB_M_Sell> Get()
        {
            throw new NotImplementedException();
        }

        public TB_M_Sell Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_M_Sell sell)
        {
            //throw new NotImplementedException();
            myContext.TB_M_Sell.Add(sell);
            return information.Save();
        }
    }
}
