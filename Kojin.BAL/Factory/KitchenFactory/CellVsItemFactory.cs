using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class CellVsItemFactory : BaseEntity
    {
        #region Mapper

        private CellVsItemEntity Mapper(Kojin_Kitchen_Item_Master source, CellVsItemEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Sno = source.Sno;
            target.Cust_Id = source.Cust_Id;
            target.Kit_Id = source.Kit_Id;
            target.Tray_Id = source.Tray_Id;
            target.Cell_Id = source.Cell_Id;
            target.Item_Cate = source.Item_Cate;
            target.Item_Code = source.Item_Code;
            target.Item_Details = source.Item_Details;
            target.Unit_Of_Measure = source.Unit_Of_Measure;
            target.Min_Qty = source.Min_Qty;
            target.Max_Qty = source.Max_Qty;
            target.Re_Order_Qty = source.Re_Order_Qty;
            target.DSMB_Vendor = source.DSMB_Vendor;
            target.Max_V_SMB_Vendor = source.Max_V_SMB_Vendor;
            target.D_Big_Ret = source.D_Big_Ret;
            target.Min_V_Big_Ret = source.Min_V_Big_Ret;
            target.CI_Status = source.CI_Status;
            target.CI_DateTime = source.CI_DateTime;
            return target;
        }


        private Kojin_Kitchen_Item_Master Mapper(CellVsItemEntity source, Kojin_Kitchen_Item_Master target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Sno = source.Sno;
            target.Cust_Id = source.Cust_Id;
            target.Kit_Id = source.Kit_Id;
            target.Tray_Id = source.Tray_Id;
            target.Cell_Id = source.Cell_Id;
            target.Item_Cate = source.Item_Cate;
            target.Item_Code = source.Item_Code;
            target.Item_Details = source.Item_Details;
            target.Unit_Of_Measure = source.Unit_Of_Measure;
            target.Min_Qty = source.Min_Qty;
            target.Max_Qty = source.Max_Qty;
            target.Re_Order_Qty = source.Re_Order_Qty;
            target.DSMB_Vendor = source.DSMB_Vendor;
            target.Max_V_SMB_Vendor = source.Max_V_SMB_Vendor;
            target.D_Big_Ret = source.D_Big_Ret;
            target.Min_V_Big_Ret = source.Min_V_Big_Ret;
            target.CI_Status = source.CI_Status;
            target.CI_DateTime = source.CI_DateTime;
            return target;
        }

        private List<CellVsItemEntity> MapperList(List<Kojin_Kitchen_Item_Master> source, List<CellVsItemEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Kitchen_Item_Master cellVsItem in source)
            {
                target.Add(Mapper(cellVsItem, new CellVsItemEntity()));
            }
            return target;
        }


        #endregion

        #region GET

        public List<CellVsItemEntity> GetCellVsItem()
        {
            try
            {
                var result = db.Kojin_Kitchen_Item_Master.ToList();
                return MapperList(result, new List<CellVsItemEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CellVsItemEntity GetCellVsItemDetails(int Sno)
        {
            try
            {
                var result = db.Kojin_Kitchen_Item_Master.Where(x => x.Sno == Sno).FirstOrDefault();
                return result != null ? Mapper(result, new CellVsItemEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region CREATE

        public void InsertCellvsItem(CellVsItemEntity oCellVsItemEntity)
        {
            try
            {
                oCellVsItemEntity.CI_DateTime = DateTime.Now;
                var objInsert = Mapper(oCellVsItemEntity, new Kojin_Kitchen_Item_Master());
                db.Kojin_Kitchen_Item_Master.Add(objInsert);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region UPDATE

        public void UpdateCellVsItem(CellVsItemEntity oCellVsItemEntity, int Sno)
        {
            try
            {
                oCellVsItemEntity.CI_DateTime = DateTime.Now;
                var objUpdate = db.Kojin_Kitchen_Item_Master.Where(x => x.Sno == Sno).FirstOrDefault();
                oCellVsItemEntity.Sno = Sno;
                Mapper(oCellVsItemEntity, objUpdate);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}