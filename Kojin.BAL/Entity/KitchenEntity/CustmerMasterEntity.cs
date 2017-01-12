using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class CustmerMasterEntity
    {
        public string Cust_id { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string UserType { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}