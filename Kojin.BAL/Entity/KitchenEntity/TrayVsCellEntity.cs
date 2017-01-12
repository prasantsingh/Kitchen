using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Entity.KitchenEntity
{
    public class TrayVsCellEntity
    {
        public string Kit_id { get; set; }
        public string Tray_Id { get; set; }
        public Nullable<int> No_Of_Cell { get; set; }
        public string D_Cell_1 { get; set; }
        public string D_Cell_2 { get; set; }
        public string D_Cell_3 { get; set; }
        public string D_Cell_4 { get; set; }
        public string D_Cell_5 { get; set; }
        public string D_Temp_1 { get; set; }
        public Nullable<int> D_Status { get; set; }
        public Nullable<System.DateTime> D_DateTime { get; set; }
    }
}