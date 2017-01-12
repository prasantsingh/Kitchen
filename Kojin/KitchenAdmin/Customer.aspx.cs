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
    public partial class Customer : System.Web.UI.Page
    {
        #region Declare Variables
        String Cust_id = String.Empty;

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                BindCustomer();
                CommanHelper.BindCountry(drpCountry);
                CommanHelper.BindState(drpState);

            }
        }

        #region Helper

        private void FillCustomerDetails(String str)
        {
            try
            {
                CustmerMasterFactory oCustmerMasterFactory = new CustmerMasterFactory();
                CustmerMasterEntity oCustmerMasterEntity = oCustmerMasterFactory.GetCustomerDetail(str);
                txtFName.Text = oCustmerMasterEntity.Name1.ToString();
                txtMName.Text = oCustmerMasterEntity.Name2.ToString();
                txtLName.Text = oCustmerMasterEntity.Name3.ToString();
                drpGender.Text = oCustmerMasterEntity.Gender.ToString();
                txtAddress1.Text = oCustmerMasterEntity.Address1.ToString();
                txtAddress2.Text = oCustmerMasterEntity.Address2.ToString();
                txtAddress3.Text = oCustmerMasterEntity.Address3.ToString();
                drpCity.Text = oCustmerMasterEntity.City.ToString();
                drpState.Text = oCustmerMasterEntity.State.ToString();
                drpCountry.Text = oCustmerMasterEntity.Country.ToString();
                txtPinCode.Text = oCustmerMasterEntity.Pincode.ToString();
                drpUserType.Text = oCustmerMasterEntity.UserType.ToString();

            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void BindCustomer()
        {
            try
            {
               
                CustmerMasterFactory oCustmerMasterFactory = new CustmerMasterFactory();
                List<CustmerMasterEntity> oCustmerMasterEntity = oCustmerMasterFactory.GetCustomer();

                Repeater1.DataSource = oCustmerMasterEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void AddCustomer( String Name1, String Name2, String Name3, String Gender, String Address1, String Address2, String Address3, String City, String State, String Country, String Pincode, String UserType)
        {
            try
            {
                if (Session["Cust_Id"] != null)
                {
                    Cust_id = Session["Cust_Id"].ToString();
                }
                CustmerMasterFactory oCustmerMasterFactory = new CustmerMasterFactory();
                oCustmerMasterFactory.InsertCustomerMaster(Cust_id, Name1, Name2, Name3, Gender, Address1, Address2, Address3, City, State, Country, Pincode, UserType);
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }


        private void ClearControl()
        {
            txtFName.Text = String.Empty;
            txtMName.Text = String.Empty;
            txtLName.Text = String.Empty;
            drpGender.SelectedIndex = 0;
            txtAddress1.Text = String.Empty;
            txtAddress2.Text = String.Empty;
            txtAddress3.Text = String.Empty;
            drpCity.SelectedIndex = 0;
            drpState.SelectedIndex = 0;
            drpCountry.SelectedIndex = 0;
            txtPinCode.Text = String.Empty;
            drpUserType.SelectedIndex = 0;

        }

        #endregion

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                AddCustomer(txtFName.Text.Trim(), txtMName.Text.Trim(), txtLName.Text.Trim(), drpGender.Text.Trim(), txtAddress1.Text.Trim(), txtAddress2.Text.Trim(), txtAddress3.Text.Trim(), drpCity.Text.Trim(), drpState.Text.Trim(), drpCountry.Text.Trim(), txtPinCode.Text.Trim(), drpUserType.Text.Trim());
                ClearControl();
                if (Session["Cust_Id"] != null)
                {
                    Session["Cust_Id"] = null;
                    Response.Redirect("~/KitchenAdmin/Customer.aspx", false);
                }
                lblMsg.Text = "Customer Successfully Save.!!";
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

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            String Cust_id = (e.Item.FindControl("lnkCust_Id") as LinkButton).Text;
            Session["Cust_Id"] = Cust_id;
            FillCustomerDetails(Session["Cust_Id"].ToString());
        }

        
    }
}