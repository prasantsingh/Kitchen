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
    public partial class ItemCode : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                CommanHelper.BindItemCategory(drpItemCategory);
                BindItemCodeMaster();
            }

        }

        #region Helper


        private void BindItemCodeMaster()
        {
            try
            {
                ItemCodeFactory oItemCodeFactory = new ItemCodeFactory();
                List<ItemCodeEntity> oItemCodeEntity = oItemCodeFactory.GetItemCodeMaster();
                Repeater1.DataSource = oItemCodeEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void FillItemCodeMasterDetails(String str)
        {
            try
            {
                ItemCodeFactory oItemCodeFactory = new ItemCodeFactory();
                ItemCodeEntity oItemCodeEntity = oItemCodeFactory.GetItemCodeMasterDetails(str);
                drpItemCategory.Text = oItemCodeEntity.Item_Cat_id.ToString();
                txtItemName.Text = oItemCodeEntity.Item_Name.ToString();
                txtDescription1.Text = oItemCodeEntity.Item_Desc1.ToString();
                txtDescription2.Text = oItemCodeEntity.Item_Desc2.ToString();
                drpUnitOfMeasure.Text = oItemCodeEntity.Item_UnitMeasure.ToString();
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
                Session["Item_id"] = null;
                drpItemCategory.SelectedIndex = 0;
                txtDescription1.Text = String.Empty;
                txtDescription2.Text = String.Empty;
                txtItemName.Text = String.Empty;
                drpUnitOfMeasure.SelectedIndex = 0;
                BindItemCodeMaster();
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
                String Item_id = String.Empty;
                if (Session["Item_id"] != null)
                {
                    Item_id = Session["Item_id"].ToString();
                }

                ItemCodeFactory oItemCodeFactory = new ItemCodeFactory();
                oItemCodeFactory.InsertItemCode(drpItemCategory.Text.Trim(),Item_id,txtItemName.Text.Trim(),txtDescription1.Text.Trim(), txtDescription2.Text.Trim(), drpUnitOfMeasure.Text);
                if (Item_id != "")
                {
                    lblMsg.Text = "Item Code Sucsessfully Update !!";
                }
                else
                {
                    lblMsg.Text = "Item Code Sucsessfully Create !!";
                }
                ClearControl();
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
                lblMsg.Text = "";
                ClearControl();
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
                String Item_id = (e.Item.FindControl("lnkItem_id") as LinkButton).Text;
                Session["Item_id"] = Item_id;
                FillItemCodeMasterDetails(Session["Item_id"].ToString());
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }

        }
    }
}