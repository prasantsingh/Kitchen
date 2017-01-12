using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class ItemCategoryFactory : BaseEntity
    {
        #region Mapper


        private ItemCategoryEntity Mapper(Kojin_Item_Category source, ItemCategoryEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Item_Cat_id = source.Item_Cat_id;
            target.Item_Cat_Name = source.Item_Cat_Name;
            target.Item_Cat_Desc1 = source.Item_Cat_Desc1;
            target.Item_Cat_Desc2 = source.Item_Cat_Desc2;
            target.Item_Cat_Desc3 = source.Item_Cat_Desc3;
            target.Item_Cat_Status = source.Item_Cat_Status;
            target.Item_Cat_DateTime = source.Item_Cat_DateTime;
            return target;
        }
        private List<ItemCategoryEntity> MapperList(List<Kojin_Item_Category> source, List<ItemCategoryEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Item_Category itemCat in source)
            {
                target.Add(Mapper(itemCat, new ItemCategoryEntity()));
            }
            return target;
        }
        #endregion


        #region CREATE

        public void InsertItemCategory(String Item_Cat_id, String Item_Cat_Name, String Item_Cat_Desc1, String Item_Cat_Desc2, String Item_Cat_Desc3)
        {
            try
            {
                db.PROC_Kojin_InsertUpdateItemCategory(Item_Cat_id, Item_Cat_Name, Item_Cat_Desc1, Item_Cat_Desc2, Item_Cat_Desc3);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region GET

        public List<ItemCategoryEntity> GetItemCategory()
        {
            try
            {
                var result = db.Kojin_Item_Category.ToList();
                return MapperList(result, new List<ItemCategoryEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ItemCategoryEntity GetItemCategoryDetails(string Item_Cat_id)
        {
            try
            {
                var result = db.Kojin_Item_Category.Where(x => x.Item_Cat_id == Item_Cat_id).FirstOrDefault();
                return result != null ? Mapper(result, new ItemCategoryEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}