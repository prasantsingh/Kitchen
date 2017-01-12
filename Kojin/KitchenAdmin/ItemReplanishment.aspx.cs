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
    public partial class ItemReplanishment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindItemReplanishment();
                CommanHelper.BindCustomer(drpCustomerId);
            }
        }

        #region Helper

        private void BindItemReplanishment()
        {
            try
            {
                ItemReplanishmentFactory oItemReplanishmentFactory = new ItemReplanishmentFactory();
                List<ItemReplanishmentEntity> oItemReplanishmentEntity = oItemReplanishmentFactory.GetItemReplanishment();
                Repeater1.DataSource = oItemReplanishmentEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }


        private void FillItemReplanishment(int Sno)
        {
            try
            {
                ItemReplanishmentFactory oItemReplanishmentFactory = new ItemReplanishmentFactory();
                ItemReplanishmentEntity oItemReplanishmentEntity = oItemReplanishmentFactory.GetItemReplatnishmentDetails(Sno);

                drpCustomerId.Text = oItemReplanishmentEntity.Cust_Id.ToString();
                drpCustomerId_SelectedIndexChanged(null, null);
                drpKitchen.Text = oItemReplanishmentEntity.Kit_Id.ToString();
                drpOrderValue.Text = oItemReplanishmentEntity.Reorder_value.ToString();
                drpRepWindow.Text = oItemReplanishmentEntity.Rep_Window.ToString();
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
                Session["litID"] = null;
                BindItemReplanishment();
                drpCustomerId.SelectedIndex = 0;
                drpKitchen.Items.Clear();
                drpOrderValue.SelectedIndex = 0;
                drpRepWindow.SelectedIndex = 0;
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
                ItemReplanishmentFactory oItemReplanishmentFactory = new ItemReplanishmentFactory();
                ItemReplanishmentEntity oItemReplanishmentEntity = new ItemReplanishmentEntity();
                oItemReplanishmentEntity.Cust_Id = drpCustomerId.Text.Trim();
                oItemReplanishmentEntity.Kit_Id = drpKitchen.Text.Trim();
                oItemReplanishmentEntity.Rep_Window = drpRepWindow.Text.Trim();
                oItemReplanishmentEntity.Reorder_value = drpOrderValue.Text.Trim();
                oItemReplanishmentEntity.Item_Rep_Status = 1;
                if (Session["litID"] != null)
                {
                    oItemReplanishmentFactory.UpdateItemReplanishment(oItemReplanishmentEntity, Conversion.ConToInt(Session["litID"].ToString()));
                }
                else
                {
                    oItemReplanishmentFactory.InsertItemReplanishment(oItemReplanishmentEntity);
                }
                ClearControl();
                lblMsg.Text = "Item Replanishment Done !!";
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        

        protected void btnReset_Click(object sender, EventArgs e)
        {
            ClearControl();
            lblMsg.Text = "";
        }

        protected void drpCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (drpCustomerId.SelectedIndex > 0)
                {
                    CommanHelper.BindKitchenCustomerWise(drpKitchen, drpCustomerId.Text.Trim());
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
                FillItemReplanishment(Conversion.ConToInt(litID));
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}