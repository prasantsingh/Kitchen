using Kojin.BAL.Entity.KitchenEntity;
using Kojin.BAL.Factory;
using Kojin.BAL.Factory.KitchenFactory;
using Kojin.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kojin.KitchenAdmin
{
    public partial class CellVsItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                BindCellVsItem();
                CommanHelper.BindCustomer(drpCustomerId);
                CommanHelper.BindTrayId(drpTrayId);
                CommanHelper.BindItemCategory(drpItemCategory);
                CommanHelper.BindVendor(drpDefaultSMBVendor);
            }
        }

        #region Helper

        private void BindCellVsItem()
        {
            try
            {
                CellVsItemFactory oCellVsItemFactory = new CellVsItemFactory();
                List<CellVsItemEntity> oCellVsItemEntity = oCellVsItemFactory.GetCellVsItem();
                Repeater1.DataSource = oCellVsItemEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void FillCellVsItemDetails(int Sno)
        {
            try
            {
                CellVsItemFactory oCellVsItemFactory = new CellVsItemFactory();
                CellVsItemEntity oCellVsItemEntity = oCellVsItemFactory.GetCellVsItemDetails(Sno);
                drpCustomerId.Text = oCellVsItemEntity.Cust_Id.ToString();
                txtkitchenId.Text = oCellVsItemEntity.Kit_Id.ToString();
                drpTrayId.Text = oCellVsItemEntity.Tray_Id.ToString();
                drpCellId.Text = oCellVsItemEntity.Cell_Id.ToString();
                drpItemCategory.Text = oCellVsItemEntity.Item_Cate.ToString();
                drpItemCode.Text = oCellVsItemEntity.Item_Code.ToString();
                txtItemDetails.Text = oCellVsItemEntity.Item_Details.ToString();
                txtUnitofMeasure.Text = oCellVsItemEntity.Unit_Of_Measure.ToString();
                txtMinimumQty.Text = oCellVsItemEntity.Min_Qty.ToString();
                txtMaxQty.Text = oCellVsItemEntity.Max_Qty.ToString();
                txtReorderQty.Text = oCellVsItemEntity.Re_Order_Qty.ToString();
                drpDefaultSMBVendor.Text = oCellVsItemEntity.DSMB_Vendor.ToString();
                txtMaxValuforSMBVendor.Text = oCellVsItemEntity.Max_V_SMB_Vendor.ToString();
                drpDefaultBigRetailor.Text = oCellVsItemEntity.D_Big_Ret.ToString();
                txtDefaultBigRetailor.Text = oCellVsItemEntity.Min_V_Big_Ret.ToString();

            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void ClearControl()
        {
            try
            {
                BindCellVsItem();
                drpCustomerId.SelectedIndex = 0;
                txtkitchenId.Text = String.Empty;
                drpKitchen.Items.Clear();
                drpTrayId.SelectedIndex = 0;
                drpCellId.SelectedIndex = 0;
                drpItemCategory.SelectedIndex = 0;
                drpItemCode.SelectedIndex = 0;
                txtItemDetails.Text = String.Empty;
                txtUnitofMeasure.Text = String.Empty;
                txtMinimumQty.Text = String.Empty;
                txtMaxQty.Text = String.Empty;
                txtReorderQty.Text = String.Empty;
                drpDefaultSMBVendor.SelectedIndex = 0;
                txtMaxValuforSMBVendor.Text = String.Empty;
                drpDefaultBigRetailor.SelectedIndex = 0;
                txtDefaultBigRetailor.Text = String.Empty;
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        #endregion

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CellVsItemFactory oCellVsItemFactory = new CellVsItemFactory();
                CellVsItemEntity oCellVsItemEntity = new CellVsItemEntity();
                oCellVsItemEntity.Cust_Id = drpCustomerId.Text.Trim();
                oCellVsItemEntity.Kit_Id = txtkitchenId.Text.Trim();
                oCellVsItemEntity.Tray_Id = drpTrayId.Text.Trim();
                oCellVsItemEntity.Cell_Id = drpCellId.Text.Trim();
                oCellVsItemEntity.Item_Cate = drpItemCategory.Text.Trim();
                oCellVsItemEntity.Item_Code = drpItemCode.Text.Trim();
                oCellVsItemEntity.Item_Details = txtItemDetails.Text.Trim();
                oCellVsItemEntity.Unit_Of_Measure = txtUnitofMeasure.Text.Trim();
                oCellVsItemEntity.Min_Qty =Conversion.ConToDec5( txtMinimumQty.Text.Trim());
                oCellVsItemEntity.Max_Qty =Conversion.ConToDec5( txtMaxQty.Text.Trim());
                oCellVsItemEntity.Re_Order_Qty = Conversion.ConToDec5(txtReorderQty.Text.Trim());
                oCellVsItemEntity.DSMB_Vendor = drpDefaultSMBVendor.Text.Trim();
                oCellVsItemEntity.Max_V_SMB_Vendor = txtMaxValuforSMBVendor.Text.Trim();
                oCellVsItemEntity.D_Big_Ret = drpDefaultBigRetailor.Text.Trim();
                oCellVsItemEntity.Min_V_Big_Ret = txtDefaultBigRetailor.Text.Trim();
                oCellVsItemEntity.CI_Status = 1;

                if (Session["litID"] != null)
                {
                    oCellVsItemFactory.UpdateCellVsItem(oCellVsItemEntity, Conversion.ConToInt(Session["litID"].ToString()));
                }
                else
                {
                    oCellVsItemFactory.InsertCellvsItem(oCellVsItemEntity);
                }
                ClearControl();
                lblMsg.Text = "Cell Vs Item Mapping Done !!";

               
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ClearControl();
                lblMsg.Text = "";
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void drpItemCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                drpItemCode.Items.Clear();
                ItemCodeFactory oItemCodeFactory = new ItemCodeFactory();
                List<ItemCodeEntity> oItemCodeEntity = oItemCodeFactory.GetItemCodeMasterDetailsCateWise(drpItemCategory.Text.Trim());
                if (oItemCodeEntity != null && oItemCodeEntity.Count() > 0)
                {
                    drpItemCode.DataSource = oItemCodeEntity;
                    drpItemCode.DataTextField = "Item_Name";
                    drpItemCode.DataValueField = "Item_id";
                    drpItemCode.DataBind();
                    drpItemCode.Items.Insert(0, new ListItem("--Select--", "0"));
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void drpTrayId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                drpCellId.Items.Clear();
                if (drpTrayId.SelectedIndex > 0)
                {
                    TrayVsCellFactory oTrayVsCellFactory = new TrayVsCellFactory();
                    TrayVsCellEntity oTrayVsCellEntity = oTrayVsCellFactory.GetTrayVsCellDetails(drpTrayId.Text.Trim());
                    drpCellId.Items.Insert(0, new ListItem("--Select--", "0"));
                 
                    if (oTrayVsCellEntity.D_Cell_1.ToString().Trim() != "")
                    {
                        drpCellId.Items.Insert(1, new ListItem(oTrayVsCellEntity.D_Cell_1.ToString().Trim(), oTrayVsCellEntity.D_Cell_1.ToString().Trim()));
                    }
                    if (oTrayVsCellEntity.D_Cell_2.ToString().Trim() != "")
                    {
                        drpCellId.Items.Insert(2, new ListItem(oTrayVsCellEntity.D_Cell_2.ToString().Trim(), oTrayVsCellEntity.D_Cell_2.ToString().Trim()));
                    }
                    if (oTrayVsCellEntity.D_Cell_3.ToString().Trim() != "")
                    {
                        drpCellId.Items.Insert(3, new ListItem(oTrayVsCellEntity.D_Cell_3.ToString().Trim(), oTrayVsCellEntity.D_Cell_3.ToString().Trim()));
                    }
                    if (oTrayVsCellEntity.D_Cell_4.ToString().Trim() != "")
                    {
                        drpCellId.Items.Insert(4, new ListItem(oTrayVsCellEntity.D_Cell_4.ToString().Trim(), oTrayVsCellEntity.D_Cell_4.ToString().Trim()));
                    }
                    if (oTrayVsCellEntity.D_Cell_5.ToString().Trim() != "")
                    {
                        drpCellId.Items.Insert(5, new ListItem(oTrayVsCellEntity.D_Cell_5.ToString().Trim(), oTrayVsCellEntity.D_Cell_5.ToString().Trim()));
                    } 
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void drpKitchen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtkitchenId.Text = drpKitchen.Text.Trim();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void drpItemCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtItemDetails.Text = String.Empty;
                txtItemDetails.Text = String.Empty;

                if (drpItemCode.SelectedIndex > 0)
                {
                    ItemCodeFactory oItemCodeFactory = new ItemCodeFactory();
                    ItemCodeEntity oItemCodeEntity = oItemCodeFactory.GetItemCodeMasterDetails(drpItemCode.Text.Trim());
                    txtItemDetails.Text = oItemCodeEntity.Item_Desc1.ToString();
                    txtUnitofMeasure.Text = oItemCodeEntity.Item_UnitMeasure.ToString();
                }
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                String litID = (e.Item.FindControl("litID") as Literal).Text;
                Session["litID"] = litID;
                FillCellVsItemDetails(Conversion.ConToInt(litID));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void drpCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpCustomerId.SelectedIndex > 0)
            {
                CommanHelper.BindKitchenCustomerWise(drpKitchen, drpCustomerId.Text.Trim());
            }
        }
    }
}