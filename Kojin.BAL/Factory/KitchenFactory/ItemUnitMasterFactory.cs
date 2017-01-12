using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class ItemUnitMasterFactory : BaseEntity
    {
        #region Mapper

        private ItemUnitMasterEntity Mapper(Kojin_Item_Unit_Master source, ItemUnitMasterEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");
            
            target.Unit_Name = source.Unit_Name;
            target.Unit_Status = source.Unit_Status;
            target.Unit_DateTime = source.Unit_DateTime;
            return target;
        }


        private Kojin_Item_Unit_Master Mapper(ItemUnitMasterEntity source, Kojin_Item_Unit_Master target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Unit_Name = source.Unit_Name;
            target.Unit_Status = source.Unit_Status;
            target.Unit_DateTime = source.Unit_DateTime;
            return target;
        }


        private List<ItemUnitMasterEntity> MapperList(List<Kojin_Item_Unit_Master> source, List<ItemUnitMasterEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Item_Unit_Master ItemUnitMaster in source)
            {
                target.Add(Mapper(ItemUnitMaster, new ItemUnitMasterEntity()));
            }
            return target;
        }



        #endregion

        #region CREATE

        public void InsertItemUnitMaster(ItemUnitMasterEntity oItemUnitMasterEntity, String Unit_Name)
        {
            try
            {
                oItemUnitMasterEntity.Unit_Name = Unit_Name;
                oItemUnitMasterEntity.Unit_Status = 1;
                oItemUnitMasterEntity.Unit_DateTime = DateTime.Now;
                var result = db.Kojin_Item_Unit_Master.Where(x => x.Unit_Name == Unit_Name).FirstOrDefault();
                if (result != null)
                {
                    var objUpdate = db.Kojin_Item_Unit_Master.Where(x => x.Unit_Name == Unit_Name).FirstOrDefault();
                    Mapper(oItemUnitMasterEntity, objUpdate);
                    db.SaveChanges();
                }
                else
                {
                    var objInsert = Mapper(oItemUnitMasterEntity, new Kojin_Item_Unit_Master());
                    db.Kojin_Item_Unit_Master.Add(objInsert);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region GET

        public List<ItemUnitMasterEntity> GetItemUnitMaster()
        {
            try
            {
                var result = db.Kojin_Item_Unit_Master.ToList();
                return MapperList(result, new List<ItemUnitMasterEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemUnitMasterEntity GetItemUnitMasterDetails(String unit_Name)
        {
            try
            {
                var result = db.Kojin_Item_Unit_Master.Where(x => x.Unit_Name == unit_Name).FirstOrDefault();
                return result != null ? Mapper(result, new ItemUnitMasterEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}