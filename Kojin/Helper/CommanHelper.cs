using Kojin.BAL.Entity;
using Kojin.BAL.Entity.KitchenEntity;
using Kojin.BAL.Factory;
using Kojin.BAL.Factory.KitchenFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Kojin.Helper
{
    public static class CommanHelper
    {
        public static void BindCountry(DropDownList drp)
        {
            try
            {
                CountryFactory oCountryFactory = new CountryFactory();
                drp.DataSource = oCountryFactory.Country();
                drp.DataTextField = "cou_name";
                drp.DataValueField = "cou_code";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem("--Select--", "0"));

            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }


        public static void BindState(DropDownList drp)
        {
            try
            {
                StateFactory oStateFactory = new StateFactory();
                List<StateEntity> oStateEntity = oStateFactory.State();
                if (oStateEntity != null && oStateEntity.Count() > 0)
                {
                    drp.DataSource = oStateEntity;
                    drp.DataTextField = "province_name";
                    drp.DataValueField = "province_code";
                    drp.DataBind();
                    drp.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        public static void BindCustomer(DropDownList drp)
        {
            try
            {

                CustmerMasterFactory oCustmerMasterFactory = new CustmerMasterFactory();
                drp.DataSource = oCustmerMasterFactory.GetCustomer();
                drp.DataTextField = "Name1";
                drp.DataValueField = "Cust_id";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        public static void BindKitchen(DropDownList drp)
        {
            try
            {
                KitchenFactory oKitchenFactory = new KitchenFactory();
                drp.DataSource = oKitchenFactory.GetKitchen();
                drp.DataTextField = "Kit_id";
                drp.DataValueField = "Kit_id";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        public static void BindKitchenCustomerWise(DropDownList drp,String Cust_id)
        {
            try
            {
                KitchenFactory oKitchenFactory = new KitchenFactory();
                List<KitchenEntity> oKitchenEntity = oKitchenFactory.GetKitchenCustomerWise(Cust_id);
                drp.Items.Clear();
                if (oKitchenEntity != null && oKitchenEntity.Count() > 0)
                {
                    drp.DataSource = oKitchenEntity;
                    drp.DataTextField = "Kit_id";
                    drp.DataValueField = "Kit_id";
                    drp.DataBind();
                    drp.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        public static void BindItemCategory(DropDownList drp)
        {
            try
            {

                ItemCategoryFactory oItemCategoryFactory = new ItemCategoryFactory();
                List<ItemCategoryEntity> oItemCategoryEntity = oItemCategoryFactory.GetItemCategory();
                if (oItemCategoryEntity != null && oItemCategoryEntity.Count() > 0)
                {
                    drp.DataSource = oItemCategoryEntity;
                    drp.DataTextField = "Item_Cat_Name";
                    drp.DataValueField = "Item_Cat_id";
                    drp.DataBind();
                    drp.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        
        public static void BindItemCode(DropDownList drp)
        {
            try
            {

                ItemCodeFactory oItemCodeFactory = new ItemCodeFactory();
                List<ItemCodeEntity> oItemCodeEntity = oItemCodeFactory.GetItemCodeMaster();
                if (oItemCodeEntity != null && oItemCodeEntity.Count() > 0)
                {
                    drp.DataSource = oItemCodeEntity;
                    drp.DataTextField = "Item_Name";
                    drp.DataValueField = "Item_Cat_id";
                    drp.DataBind();
                    drp.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        public static void BindTrayId(DropDownList drp)
        {
            try
            {

                TrayVsCellFactory oTrayVsCellFactory = new TrayVsCellFactory();
                drp.DataSource = oTrayVsCellFactory.GetTrayVsCell();
                drp.DataTextField = "Tray_Id";
                drp.DataValueField = "Tray_Id";
                drp.DataBind();
                drp.Items.Insert(0, new ListItem("--Select--", "0"));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }


        public static void BindVendor(DropDownList drp)
        {
            try
            {


                VendorFactory oVendorFactory = new VendorFactory();
                List<VendorEntity> oVendorEntity = oVendorFactory.GetVendor();
                if (oVendorEntity != null && oVendorEntity.Count() > 0)
                {
                    drp.DataSource = oVendorEntity;
                    drp.DataTextField = "Ven_Name";
                    drp.DataValueField = "Ven_Code";
                    drp.DataBind();
                    drp.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}