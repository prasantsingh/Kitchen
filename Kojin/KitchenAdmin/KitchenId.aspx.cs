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
    public partial class KitchenId : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CommanHelper.BindCustomer(drpCustomer);
                BindKitchen();
            }
        }

        #region Helper

        private void BindKitchen()
        {
            try
            {
                KitchenFactory oKitchenFactory = new KitchenFactory();
                List<KitchenEntity> oKitchenEntity = oKitchenFactory.GetKitchen();
                Repeater1.DataSource = oKitchenEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void FillkitchenDetails(String str)
        {
            try
            {
                KitchenFactory oKitchenFactory = new KitchenFactory();
                KitchenEntity oKitchenEntity = oKitchenFactory.GetkitchenDetail(str);
                drpCustomer.Text = txtCustomerId.Text = oKitchenEntity.Cust_id.ToString();
                drpKitchenLoaction1.Text = oKitchenEntity.Kit_Loc1.ToString();
                drpKitchenLoaction2.Text = oKitchenEntity.Kit_Loc2.ToString();
                drpKitchenType.Text = oKitchenEntity.Kit_Type.ToString();
                drpSmall.Text = Conversion.ConToInt16(oKitchenEntity.App_Small_V).ToString();
                drpMeduim.Text = Conversion.ConToInt16(oKitchenEntity.App_Meduim_V).ToString();
                drpLarge.Text = Conversion.ConToInt16(oKitchenEntity.App_Larger_V).ToString();
                drpExtraLarge.Text = Conversion.ConToInt16(oKitchenEntity.App_Extra_LV).ToString();

            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void ClearControl()
        {
            Session["Kit_Id"] = null;
            txtCustomerId.Text = String.Empty;
            drpCustomer.SelectedIndex = 0;
            drpKitchenLoaction1.SelectedIndex = 0;
            drpKitchenLoaction2.SelectedIndex = 0;
            drpKitchenType.SelectedIndex = 0;
            drpSmall.SelectedIndex = 0;
            drpMeduim.SelectedIndex = 0;
            drpLarge.SelectedIndex = 0;
            drpExtraLarge.SelectedIndex = 0;

            BindKitchen();

        }


        #endregion


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                String Kit_id = String.Empty;
                if (Session["Kit_Id"] != null)
                {
                    Kit_id = Session["Kit_Id"].ToString();
                }
                KitchenFactory oKitchenFactory = new KitchenFactory();
                oKitchenFactory.InsertKitchenMaster(txtCustomerId.Text.Trim(), Kit_id, drpKitchenLoaction1.Text.Trim(), drpKitchenLoaction2.Text.Trim(), drpKitchenType.Text.Trim(),
                    Conversion.ConToDec5(drpSmall.Text.Trim()), Conversion.ConToDec5(drpSmall.Text.Trim()), Conversion.ConToDec5(drpMeduim.Text.Trim()), Conversion.ConToDec5(drpMeduim.Text.Trim()),
                    Conversion.ConToDec5(drpLarge.Text.Trim()), Conversion.ConToDec5(drpLarge.Text.Trim()), Conversion.ConToDec5(drpExtraLarge.Text.Trim()), Conversion.ConToDec5(drpExtraLarge.Text.Trim()));

                ClearControl();
                if (Kit_id != "")
                {
                    lblMsg.Text = "kitchen Id Successfully Update !!!";
                }
                else
                {
                    lblMsg.Text = "kitchen Id Successfully Create !!!";
                }
                BindKitchen();
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
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        protected void drpCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCustomerId.Text = "";
            if (drpCustomer.SelectedIndex > 0)
            {
                txtCustomerId.Text = drpCustomer.Text.Trim();
            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                String lnkKit_id = (e.Item.FindControl("lnkKit_id") as LinkButton).Text;
                Session["Kit_Id"] = lnkKit_id;
                FillkitchenDetails(Session["Kit_Id"].ToString());
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}