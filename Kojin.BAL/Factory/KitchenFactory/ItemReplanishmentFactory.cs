using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class ItemReplanishmentFactory : BaseEntity
    {
        #region Mapper

        private ItemReplanishmentEntity Mapper(Kojin_Item_Replanishment source, ItemReplanishmentEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Cust_Id = source.Cust_Id;
            target.Kit_Id = source.Kit_Id;
            target.Rep_Window = source.Rep_Window;
            target.Reorder_value = source.Reorder_value;
            target.Item_Rep_Status = source.Item_Rep_Status;
            target.Item_Rep_DateTime = source.Item_Rep_DateTime;
            target.Item_Rep_Sno = source.Item_Rep_Sno;
            return target;
        }

        private Kojin_Item_Replanishment Mapper(ItemReplanishmentEntity source, Kojin_Item_Replanishment target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Cust_Id = source.Cust_Id;
            target.Kit_Id = source.Kit_Id;
            target.Rep_Window = source.Rep_Window;
            target.Reorder_value = source.Reorder_value;
            target.Item_Rep_Status = source.Item_Rep_Status;
            target.Item_Rep_DateTime = source.Item_Rep_DateTime;
            target.Item_Rep_Sno = source.Item_Rep_Sno;
            return target;
        }


        private List<ItemReplanishmentEntity> MapperList(List<Kojin_Item_Replanishment> source, List<ItemReplanishmentEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Item_Replanishment itemCat in source)
            {
                target.Add(Mapper(itemCat, new ItemReplanishmentEntity()));
            }
            return target;
        }


        #endregion 


        #region CREATE 

        public void InsertItemReplanishment(ItemReplanishmentEntity oItemReplanishmentEntity)
        {
            try
            {
                oItemReplanishmentEntity.Item_Rep_DateTime = DateTime.Now;
                var objInsert = Mapper(oItemReplanishmentEntity, new Kojin_Item_Replanishment());
                db.Kojin_Item_Replanishment.Add(objInsert);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region UPDATE

        public void UpdateItemReplanishment(ItemReplanishmentEntity oItemReplanishmentEntity, int Item_Rep_Sno)
        {
            try
            {
                oItemReplanishmentEntity.Item_Rep_DateTime = DateTime.Now;
                var objUpdate = db.Kojin_Item_Replanishment.Where(x => x.Item_Rep_Sno == Item_Rep_Sno).FirstOrDefault();
                oItemReplanishmentEntity.Item_Rep_Sno = Item_Rep_Sno;
                Mapper(oItemReplanishmentEntity, objUpdate);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region GET

        public List<ItemReplanishmentEntity> GetItemReplanishment()
        {
            try
            {
                var result = db.Kojin_Item_Replanishment.ToList();
                return MapperList(result, new List<ItemReplanishmentEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ItemReplanishmentEntity GetItemReplatnishmentDetails(int Sno)
        {
            try
            {
                var result = db.Kojin_Item_Replanishment.Where(x => x.Item_Rep_Sno == Sno).FirstOrDefault();
                return result != null ? Mapper(result, new ItemReplanishmentEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}