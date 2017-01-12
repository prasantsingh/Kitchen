using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class VendorEntity
    {
        public string Ven_Code { get; set; }
        public string Ven_Name { get; set; }
        public string Ven_Address1 { get; set; }
        public string Ven_Address2 { get; set; }
        public string Ven_Address3 { get; set; }
        public string Ven_City { get; set; }
        public string Ven_State { get; set; }
        public string Ven_Country { get; set; }
        public string Ven_Pincode { get; set; }
        public string Ven_Phone { get; set; }
        public string Ven_Email { get; set; }
        public Nullable<int> Ven_Status { get; set; }
        public Nullable<System.DateTime> Ven_DateTime { get; set; }
    }
}