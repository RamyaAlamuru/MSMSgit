using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSMSGit.Repository;
using MSMSGit.Irepository;

namespace MSMSGit.BusinessAccessLayer
{
    public class BAL
    {
        Ireposit obj1;
        public BAL(Reposit obj2)
        {
            obj1 = obj2;
        }
    }
}