using Kojin.BAL.Entity.KitchenEntity;
using Kojin.BAL.Factory;
using Kojin.BAL.Factory.KitchenFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kojin.KitchenAdmin
{
    public partial class UnitOfMeasure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                BindItemUnitMaster();
            }
        }

        #region Helper

        private void FillItemUnitMasterDetails(String str)
        {
            try
            {
                ItemUnitMasterFactory oItemUnitMasterFactory = new ItemUnitMasterFactory();
                ItemUnitMasterEntity oItemUnitMasterEntity = oItemUnitMasterFactory.GetItemUnitMasterDetails(str);
                txtUnitOfMeasure.Text = oItemUnitMasterEntity.Unit_Name.ToString();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void BindItemUnitMaster()
        {
            try
            {
                ItemUnitMasterFactory oItemUnitMasterFactory = new ItemUnitMasterFactory();
                List<ItemUnitMasterEntity> oItemUnitMasterEntity = oItemUnitMasterFactory.GetItemUnitMaster();
                Repeater1.DataSource = oItemUnitMasterEntity;
                Repeater1.DataBind();
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
                Session["Unit_Name"] = null;
                txtUnitOfMeasure.Text = String.Empty;
                BindItemUnitMaster();
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
                String Unit_Name = "";
                ItemUnitMasterEntity oItemUnitMasterEntity = new ItemUnitMasterEntity();
                if (Session["Unit_Name"] != null)
                {
                    Unit_Name = Session["Unit_Name"].ToString();
                }
                else
                {
                    Unit_Name = txtUnitOfMeasure.Text.Trim();
                }
                ItemUnitMasterFactory oItemUnitMasterFactory = new ItemUnitMasterFactory();
                oItemUnitMasterFactory.InsertItemUnitMaster(oItemUnitMasterEntity, Unit_Name);

                lblMsg.Text = "Item Unit Master Created !!!";
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
                String Unit_Name = (e.Item.FindControl("lnkUnit_Name") as LinkButton).Text;
                Session["Unit_Name"] = Unit_Name;
                FillItemUnitMasterDetails(Unit_Name);
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}