
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL
{
    public class BaseEntity
    {
        public KojinEntities db = null;

        public BaseEntity()
        {
            db = new KojinEntities();
        }
    }
}