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
    public partial class TrayVsCell : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMsg.Text = "";
            if (!IsPostBack)
            {
                CommanHelper.BindKitchen(drpKitchenId);
                BindTrayVsCell();
            }
        }

        #region Helper

        private void FillTrayVsCellDetails(String str)
        {
            try
            {
                TrayVsCellFactory oTrayVsCellFactory = new TrayVsCellFactory();
                TrayVsCellEntity oTrayVsCellEntity = oTrayVsCellFactory.GetTrayVsCellDetails(str);
                drpKitchenId.Text = oTrayVsCellEntity.Kit_id.ToString();
                txtTrayID.Text = oTrayVsCellEntity.Tray_Id.ToString();
                drpNoOfCell.Text = oTrayVsCellEntity.No_Of_Cell.ToString();
                txtCell1.Text = oTrayVsCellEntity.D_Cell_1.ToString();
                txtCell2.Text = oTrayVsCellEntity.D_Cell_2.ToString();
                txtCell3.Text = oTrayVsCellEntity.D_Cell_3.ToString();
                txtCell4.Text = oTrayVsCellEntity.D_Cell_4.ToString();
                txtCell5.Text = oTrayVsCellEntity.D_Cell_5.ToString();
                txtTempCell.Text = oTrayVsCellEntity.D_Temp_1.ToString();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void BindTrayVsCell()
        {
            try
            {
                TrayVsCellFactory oTrayVsCellFactory = new TrayVsCellFactory();
                List<TrayVsCellEntity> oTrayVsCellEntity = oTrayVsCellFactory.GetTrayVsCell();
                Repeater1.DataSource = oTrayVsCellEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void ClearControl()
        {
            BindTrayVsCell();
            drpKitchenId.SelectedIndex = 0;
            txtTrayID.Text = String.Empty;
            drpNoOfCell.SelectedIndex = 0;
            txtCell1.Text = String.Empty;
            txtCell2.Text = String.Empty;
            txtCell3.Text = String.Empty;
            txtCell4.Text = String.Empty;
            txtCell5.Text = String.Empty;
            txtTempCell.Text = String.Empty;
        }

        #endregion

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                TrayVsCellFactory oTrayVsCellFactory = new TrayVsCellFactory();
                oTrayVsCellFactory.InsertTrayVsCell(drpKitchenId.Text.Trim(), txtTrayID.Text.Trim(), Conversion.ConToInt16(drpNoOfCell.Text.Trim()), txtCell1.Text.Trim(), txtCell2.Text.Trim(), txtCell3.Text.Trim(), txtCell4.Text.Trim(), txtCell5.Text.Trim(), txtTempCell.Text.Trim());

                lblMsg.Text = "Tray Vs Cells Mapping Done !!";
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
                String Tray_Id = (e.Item.FindControl("lnkTray_Id") as LinkButton).Text;
                FillTrayVsCellDetails(Tray_Id);
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}