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
    public partial class ItemCategory : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindItemCategory();
            }
        }

        #region Helper
        private void FillItemCategoryDetails(String str)
        {
            try
            {
                ItemCategoryFactory oItemCategoryFactory = new ItemCategoryFactory();
                ItemCategoryEntity oItemCategoryEntity = oItemCategoryFactory.GetItemCategoryDetails(str);
                txtItemCategoryName.Text = oItemCategoryEntity.Item_Cat_Name.ToString();
                txtDescription1.Text = oItemCategoryEntity.Item_Cat_Desc1.ToString();
                txtDescription2.Text = oItemCategoryEntity.Item_Cat_Desc2.ToString();
                txtDescription3.Text = oItemCategoryEntity.Item_Cat_Desc3.ToString();

            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void BindItemCategory()
        {
            try
            {
                ItemCategoryFactory oItemCategoryFactory = new ItemCategoryFactory();
                List<ItemCategoryEntity> oItemCategoryEntity = oItemCategoryFactory.GetItemCategory();
                Repeater1.DataSource = oItemCategoryEntity;
                Repeater1.DataBind();
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }

        private void ClearControl()
        {
            txtItemCategoryName.Text = String.Empty;
            txtDescription1.Text = String.Empty;
            txtDescription2.Text = String.Empty;
            txtDescription3.Text = String.Empty;
            BindItemCategory();
        }

        #endregion

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                String Item_Cat_id = String.Empty;
                if (Session["Item_Cat_id"] != null)
                {
                    Item_Cat_id = Session["Item_Cat_id"].ToString();
                }
                ItemCategoryFactory oItemCategoryFactory = new ItemCategoryFactory();
                oItemCategoryFactory.InsertItemCategory(Item_Cat_id, txtItemCategoryName.Text.Trim(), txtDescription1.Text.Trim(), txtDescription2.Text.Trim(), txtDescription3.Text.Trim());

                if (Item_Cat_id != "")
                {
                    lblMsg.Text = "Item Category Successfully Update !!!";
                }
                else
                {
                    lblMsg.Text = "Item Category Successfully Create !!!";
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
                String Item_Cat_id = (e.Item.FindControl("lnkItem_Cat_id") as LinkButton).Text;
                Session["Item_Cat_id"] = Item_Cat_id;
                FillItemCategoryDetails(Session["Item_Cat_id"].ToString());
            }
            catch (Exception ex)
            {
                ExceptionLogging.SendExcepToDB(ex);
            }
        }
    }
}