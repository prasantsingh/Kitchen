using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class ItemCodeFactory : BaseEntity
    {

        #region Mapper


        private ItemCodeEntity Mapper(Kojin_Item_Master source, ItemCodeEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");
            
            target.Item_Cat_id = source.Item_Cat_id;
            target.Item_id = source.Item_id;
            target.Item_Name = source.Item_Name;
            target.Item_Desc1 = source.Item_Desc1;
            target.Item_Desc2 = source.Item_Desc2;
            target.Item_UnitMeasure = source.Item_UnitMeasure;
            target.Item_Status = source.Item_Status;
            target.Item_DateTime = source.Item_DateTime;
            return target;
        }

        private List<ItemCodeEntity> MapperList(List<Kojin_Item_Master> source, List<ItemCodeEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Item_Master ItemMaster in source)
            {
                target.Add(Mapper(ItemMaster, new ItemCodeEntity()));
            }
            return target;
        }


        #endregion


        #region INSERT

        public void InsertItemCode(String Item_Cat_id, String Item_id, String Item_Name, String Item_Desc1, String Item_Desc2 , String Item_UnitMeasure)
        {
            try
            {
                db.PROC_Kojin_InsertUpdateItemCode(Item_Cat_id, Item_id, Item_Name, Item_Desc1, Item_Desc2, Item_UnitMeasure);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region GET


        public List<ItemCodeEntity> GetItemCodeMaster()
        {
            try
            {
                var result = db.Kojin_Item_Master.ToList();
                return MapperList(result, new List<ItemCodeEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ItemCodeEntity GetItemCodeMasterDetails(string Item_id)
        {
            try
            {
                var result = db.Kojin_Item_Master.Where(x => x.Item_id == Item_id).FirstOrDefault();
                return result != null ? Mapper(result, new ItemCodeEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ItemCodeEntity> GetItemCodeMasterDetailsCateWise(string Item_Cat_id)
        {
            try
            {
                var result = db.Kojin_Item_Master.Where(x => x.Item_Cat_id == Item_Cat_id).ToList();
                return MapperList(result, new List<ItemCodeEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }
}