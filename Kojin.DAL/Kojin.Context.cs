﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kojin.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class KojinEntities : DbContext
    {
        public KojinEntities()
            : base("name=KojinEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ErrorInfo> ErrorInfoes { get; set; }
        public DbSet<Kojin_Country> Kojin_Country { get; set; }
        public DbSet<Kojin_Cust_Master> Kojin_Cust_Master { get; set; }
        public DbSet<Kojin_Item_Category> Kojin_Item_Category { get; set; }
        public DbSet<Kojin_Item_Master> Kojin_Item_Master { get; set; }
        public DbSet<Kojin_Item_Replanishment> Kojin_Item_Replanishment { get; set; }
        public DbSet<Kojin_Item_Unit_Master> Kojin_Item_Unit_Master { get; set; }
        public DbSet<Kojin_Kitchen_Item_Master> Kojin_Kitchen_Item_Master { get; set; }
        public DbSet<Kojin_Kitchen_Master> Kojin_Kitchen_Master { get; set; }
        public DbSet<Kojin_Kitchen_Tray_Master> Kojin_Kitchen_Tray_Master { get; set; }
        public DbSet<Kojin_operational_country> Kojin_operational_country { get; set; }
        public DbSet<Kojin_province> Kojin_province { get; set; }
        public DbSet<kojin_Vendor_Details> kojin_Vendor_Details { get; set; }
    
        public virtual int ExceptionLoggingToDataBase(string exceptionMsg, string exceptionType, string exceptionSource, string exceptionURL, string iPAdd)
        {
            var exceptionMsgParameter = exceptionMsg != null ?
                new ObjectParameter("ExceptionMsg", exceptionMsg) :
                new ObjectParameter("ExceptionMsg", typeof(string));
    
            var exceptionTypeParameter = exceptionType != null ?
                new ObjectParameter("ExceptionType", exceptionType) :
                new ObjectParameter("ExceptionType", typeof(string));
    
            var exceptionSourceParameter = exceptionSource != null ?
                new ObjectParameter("ExceptionSource", exceptionSource) :
                new ObjectParameter("ExceptionSource", typeof(string));
    
            var exceptionURLParameter = exceptionURL != null ?
                new ObjectParameter("ExceptionURL", exceptionURL) :
                new ObjectParameter("ExceptionURL", typeof(string));
    
            var iPAddParameter = iPAdd != null ?
                new ObjectParameter("IPAdd", iPAdd) :
                new ObjectParameter("IPAdd", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ExceptionLoggingToDataBase", exceptionMsgParameter, exceptionTypeParameter, exceptionSourceParameter, exceptionURLParameter, iPAddParameter);
        }
    
        public virtual int PROC_Kojin_InsertUpdateCustomer(string cust_id, string name1, string name2, string name3, string gender, string address1, string address2, string address3, string city, string state, string country, string pincode, string userType)
        {
            var cust_idParameter = cust_id != null ?
                new ObjectParameter("Cust_id", cust_id) :
                new ObjectParameter("Cust_id", typeof(string));
    
            var name1Parameter = name1 != null ?
                new ObjectParameter("Name1", name1) :
                new ObjectParameter("Name1", typeof(string));
    
            var name2Parameter = name2 != null ?
                new ObjectParameter("Name2", name2) :
                new ObjectParameter("Name2", typeof(string));
    
            var name3Parameter = name3 != null ?
                new ObjectParameter("Name3", name3) :
                new ObjectParameter("Name3", typeof(string));
    
            var genderParameter = gender != null ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(string));
    
            var address1Parameter = address1 != null ?
                new ObjectParameter("Address1", address1) :
                new ObjectParameter("Address1", typeof(string));
    
            var address2Parameter = address2 != null ?
                new ObjectParameter("Address2", address2) :
                new ObjectParameter("Address2", typeof(string));
    
            var address3Parameter = address3 != null ?
                new ObjectParameter("Address3", address3) :
                new ObjectParameter("Address3", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var countryParameter = country != null ?
                new ObjectParameter("Country", country) :
                new ObjectParameter("Country", typeof(string));
    
            var pincodeParameter = pincode != null ?
                new ObjectParameter("Pincode", pincode) :
                new ObjectParameter("Pincode", typeof(string));
    
            var userTypeParameter = userType != null ?
                new ObjectParameter("UserType", userType) :
                new ObjectParameter("UserType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_Kojin_InsertUpdateCustomer", cust_idParameter, name1Parameter, name2Parameter, name3Parameter, genderParameter, address1Parameter, address2Parameter, address3Parameter, cityParameter, stateParameter, countryParameter, pincodeParameter, userTypeParameter);
        }
    
        public virtual int PROC_Kojin_InsertUpdateItemCategory(string item_Cat_id, string item_Cat_Name, string item_Cat_Desc1, string item_Cat_Desc2, string item_Cat_Desc3)
        {
            var item_Cat_idParameter = item_Cat_id != null ?
                new ObjectParameter("Item_Cat_id", item_Cat_id) :
                new ObjectParameter("Item_Cat_id", typeof(string));
    
            var item_Cat_NameParameter = item_Cat_Name != null ?
                new ObjectParameter("Item_Cat_Name", item_Cat_Name) :
                new ObjectParameter("Item_Cat_Name", typeof(string));
    
            var item_Cat_Desc1Parameter = item_Cat_Desc1 != null ?
                new ObjectParameter("Item_Cat_Desc1", item_Cat_Desc1) :
                new ObjectParameter("Item_Cat_Desc1", typeof(string));
    
            var item_Cat_Desc2Parameter = item_Cat_Desc2 != null ?
                new ObjectParameter("Item_Cat_Desc2", item_Cat_Desc2) :
                new ObjectParameter("Item_Cat_Desc2", typeof(string));
    
            var item_Cat_Desc3Parameter = item_Cat_Desc3 != null ?
                new ObjectParameter("Item_Cat_Desc3", item_Cat_Desc3) :
                new ObjectParameter("Item_Cat_Desc3", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_Kojin_InsertUpdateItemCategory", item_Cat_idParameter, item_Cat_NameParameter, item_Cat_Desc1Parameter, item_Cat_Desc2Parameter, item_Cat_Desc3Parameter);
        }
    
        public virtual ObjectResult<PROC_Kojin_InsertUpdateItemCode_Result> PROC_Kojin_InsertUpdateItemCode(string item_Cat_id, string item_id, string item_Name, string item_Desc1, string item_Desc2, string item_UnitMeasure)
        {
            var item_Cat_idParameter = item_Cat_id != null ?
                new ObjectParameter("Item_Cat_id", item_Cat_id) :
                new ObjectParameter("Item_Cat_id", typeof(string));
    
            var item_idParameter = item_id != null ?
                new ObjectParameter("Item_id", item_id) :
                new ObjectParameter("Item_id", typeof(string));
    
            var item_NameParameter = item_Name != null ?
                new ObjectParameter("Item_Name", item_Name) :
                new ObjectParameter("Item_Name", typeof(string));
    
            var item_Desc1Parameter = item_Desc1 != null ?
                new ObjectParameter("Item_Desc1", item_Desc1) :
                new ObjectParameter("Item_Desc1", typeof(string));
    
            var item_Desc2Parameter = item_Desc2 != null ?
                new ObjectParameter("Item_Desc2", item_Desc2) :
                new ObjectParameter("Item_Desc2", typeof(string));
    
            var item_UnitMeasureParameter = item_UnitMeasure != null ?
                new ObjectParameter("Item_UnitMeasure", item_UnitMeasure) :
                new ObjectParameter("Item_UnitMeasure", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PROC_Kojin_InsertUpdateItemCode_Result>("PROC_Kojin_InsertUpdateItemCode", item_Cat_idParameter, item_idParameter, item_NameParameter, item_Desc1Parameter, item_Desc2Parameter, item_UnitMeasureParameter);
        }
    
        public virtual int PROC_Kojin_InsertUpdateKitchen(string cust_id, string kit_id, string kit_Loc1, string kit_Loc2, string kit_Type, Nullable<decimal> app_Small_V, Nullable<decimal> act_Small_V, Nullable<decimal> app_Meduim_V, Nullable<decimal> act_Meduim_V, Nullable<decimal> app_Larger_V, Nullable<decimal> act_Larger_V, Nullable<decimal> app_Extra_LV, Nullable<decimal> act_Extra_LV)
        {
            var cust_idParameter = cust_id != null ?
                new ObjectParameter("Cust_id", cust_id) :
                new ObjectParameter("Cust_id", typeof(string));
    
            var kit_idParameter = kit_id != null ?
                new ObjectParameter("Kit_id", kit_id) :
                new ObjectParameter("Kit_id", typeof(string));
    
            var kit_Loc1Parameter = kit_Loc1 != null ?
                new ObjectParameter("Kit_Loc1", kit_Loc1) :
                new ObjectParameter("Kit_Loc1", typeof(string));
    
            var kit_Loc2Parameter = kit_Loc2 != null ?
                new ObjectParameter("Kit_Loc2", kit_Loc2) :
                new ObjectParameter("Kit_Loc2", typeof(string));
    
            var kit_TypeParameter = kit_Type != null ?
                new ObjectParameter("Kit_Type", kit_Type) :
                new ObjectParameter("Kit_Type", typeof(string));
    
            var app_Small_VParameter = app_Small_V.HasValue ?
                new ObjectParameter("App_Small_V", app_Small_V) :
                new ObjectParameter("App_Small_V", typeof(decimal));
    
            var act_Small_VParameter = act_Small_V.HasValue ?
                new ObjectParameter("Act_Small_V", act_Small_V) :
                new ObjectParameter("Act_Small_V", typeof(decimal));
    
            var app_Meduim_VParameter = app_Meduim_V.HasValue ?
                new ObjectParameter("App_Meduim_V", app_Meduim_V) :
                new ObjectParameter("App_Meduim_V", typeof(decimal));
    
            var act_Meduim_VParameter = act_Meduim_V.HasValue ?
                new ObjectParameter("Act_Meduim_V", act_Meduim_V) :
                new ObjectParameter("Act_Meduim_V", typeof(decimal));
    
            var app_Larger_VParameter = app_Larger_V.HasValue ?
                new ObjectParameter("App_Larger_V", app_Larger_V) :
                new ObjectParameter("App_Larger_V", typeof(decimal));
    
            var act_Larger_VParameter = act_Larger_V.HasValue ?
                new ObjectParameter("Act_Larger_V", act_Larger_V) :
                new ObjectParameter("Act_Larger_V", typeof(decimal));
    
            var app_Extra_LVParameter = app_Extra_LV.HasValue ?
                new ObjectParameter("App_Extra_LV", app_Extra_LV) :
                new ObjectParameter("App_Extra_LV", typeof(decimal));
    
            var act_Extra_LVParameter = act_Extra_LV.HasValue ?
                new ObjectParameter("Act_Extra_LV", act_Extra_LV) :
                new ObjectParameter("Act_Extra_LV", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_Kojin_InsertUpdateKitchen", cust_idParameter, kit_idParameter, kit_Loc1Parameter, kit_Loc2Parameter, kit_TypeParameter, app_Small_VParameter, act_Small_VParameter, app_Meduim_VParameter, act_Meduim_VParameter, app_Larger_VParameter, act_Larger_VParameter, app_Extra_LVParameter, act_Extra_LVParameter);
        }
    
        public virtual int PROC_Kojin_InsertUpdateKitchenTrayMaster(string kit_id, string tray_Id, Nullable<int> no_Of_Cell, string d_Cell_1, string d_Cell_2, string d_Cell_3, string d_Cell_4, string d_Cell_5, string d_Temp_1)
        {
            var kit_idParameter = kit_id != null ?
                new ObjectParameter("Kit_id", kit_id) :
                new ObjectParameter("Kit_id", typeof(string));
    
            var tray_IdParameter = tray_Id != null ?
                new ObjectParameter("Tray_Id", tray_Id) :
                new ObjectParameter("Tray_Id", typeof(string));
    
            var no_Of_CellParameter = no_Of_Cell.HasValue ?
                new ObjectParameter("No_Of_Cell", no_Of_Cell) :
                new ObjectParameter("No_Of_Cell", typeof(int));
    
            var d_Cell_1Parameter = d_Cell_1 != null ?
                new ObjectParameter("D_Cell_1", d_Cell_1) :
                new ObjectParameter("D_Cell_1", typeof(string));
    
            var d_Cell_2Parameter = d_Cell_2 != null ?
                new ObjectParameter("D_Cell_2", d_Cell_2) :
                new ObjectParameter("D_Cell_2", typeof(string));
    
            var d_Cell_3Parameter = d_Cell_3 != null ?
                new ObjectParameter("D_Cell_3", d_Cell_3) :
                new ObjectParameter("D_Cell_3", typeof(string));
    
            var d_Cell_4Parameter = d_Cell_4 != null ?
                new ObjectParameter("D_Cell_4", d_Cell_4) :
                new ObjectParameter("D_Cell_4", typeof(string));
    
            var d_Cell_5Parameter = d_Cell_5 != null ?
                new ObjectParameter("D_Cell_5", d_Cell_5) :
                new ObjectParameter("D_Cell_5", typeof(string));
    
            var d_Temp_1Parameter = d_Temp_1 != null ?
                new ObjectParameter("D_Temp_1", d_Temp_1) :
                new ObjectParameter("D_Temp_1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_Kojin_InsertUpdateKitchenTrayMaster", kit_idParameter, tray_IdParameter, no_Of_CellParameter, d_Cell_1Parameter, d_Cell_2Parameter, d_Cell_3Parameter, d_Cell_4Parameter, d_Cell_5Parameter, d_Temp_1Parameter);
        }
    
        public virtual int PROC_Kojin_SelectItemMaster()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_Kojin_SelectItemMaster");
        }
    
        public virtual int PROC_Kojin_SelectItemUnitMaster()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PROC_Kojin_SelectItemUnitMaster");
        }
    }
}
