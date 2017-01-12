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
    public partial class Vendor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                BindVendor();
                CommanHelper.BindCountry(drpCountry);
                CommanHelper.BindState(drpState);

            }
        }

        #region Helper

        private void BindVendor()
        {
            try
            {
                VendorFactory oVendorFactory = new VendorFactory();
                List<VendorEntity> oVendorEntity = oVendorFactory.GetVendor();
                Repeater1.DataSource = oVendorEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void GetVendorDetails(String str)
        {
            try
            {
                VendorFactory oVendorFactory = new VendorFactory();
                VendorEntity oVendorEntity = oVendorFactory.GetVendorDetails(str);
                txtVendorCode.Text = oVendorEntity.Ven_Code.ToString();
                txtVendoreName.Text = oVendorEntity.Ven_Name.ToString();
                txtAddress1.Text = oVendorEntity.Ven_Address1.ToString();
                txtAddress2.Text = oVendorEntity.Ven_Address2.ToString();
                txtAddress3.Text = oVendorEntity.Ven_Address3.ToString();
                drpCity.Text = oVendorEntity.Ven_City.ToString();
                drpState.Text = oVendorEntity.Ven_State.ToString();
                drpCountry.Text = oVendorEntity.Ven_Country.ToString();
                txtPinCode.Text = oVendorEntity.Ven_Pincode.ToString();
                txtPhone.Text = oVendorEntity.Ven_Phone.ToString();
                txtEmailId.Text = oVendorEntity.Ven_Email.ToString();
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
                Session["Ven_Code"] = null;
                BindVendor();
                txtVendorCode.Text = String.Empty;
                txtVendoreName.Text = String.Empty;
                txtAddress1.Text = String.Empty;
                txtAddress2.Text = String.Empty;
                txtAddress3.Text = String.Empty;
                drpCity.SelectedIndex = 0;
                drpState.SelectedIndex = 0;
                drpCountry.SelectedIndex = 0;
                txtPinCode.Text = String.Empty;
                txtPhone.Text = String.Empty;
                txtEmailId.Text = String.Empty;
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        #endregion

        protected void btnCreation_Click(object sender, EventArgs e)
        {
            try
            {
                VendorFactory oVendorFactory = new VendorFactory();

                VendorEntity oVendorEntity = new VendorEntity();
                oVendorEntity.Ven_Code = txtVendorCode.Text.Trim();
                oVendorEntity.Ven_Name = txtVendoreName.Text.Trim();
                oVendorEntity.Ven_Address1 = txtAddress1.Text.Trim();
                oVendorEntity.Ven_Address2 = txtAddress2.Text.Trim();
                oVendorEntity.Ven_Address3 = txtAddress3.Text.Trim();
                oVendorEntity.Ven_City = drpCity.Text.Trim();
                oVendorEntity.Ven_State = drpState.Text.Trim();
                oVendorEntity.Ven_Country = drpCountry.Text.Trim();
                oVendorEntity.Ven_Pincode = txtPinCode.Text.Trim();
                oVendorEntity.Ven_Phone = txtPhone.Text.Trim();
                oVendorEntity.Ven_Email = txtEmailId.Text.Trim();
                if (Session["Ven_Code"] != null)
                {
                    oVendorFactory.UpdateVendor(oVendorEntity, Session["Ven_Code"].ToString().Trim());
                }
                else
                {
                    oVendorEntity.Ven_Status = 1;
                    oVendorFactory.InsertVendor(oVendorEntity);
                }
                ClearControl();
                lblMsg.Text = "Vendor Successfully Create !!";
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

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            try
            {
                String Ven_Code = (e.Item.FindControl("lnkVen_Code") as LinkButton).Text;
                Session["Ven_Code"] = Ven_Code;
                GetVendorDetails(Ven_Code);
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}