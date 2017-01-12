using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class KitchenFactory : BaseEntity
    {
        #region Mapper

        private KitchenEntity Mapper(Kojin_Kitchen_Master source, KitchenEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Cust_id = source.Cust_id;
            target.Kit_id = source.Kit_id;
            target.Kit_Loc1 = source.Kit_Loc1;
            target.Kit_Loc2 = source.Kit_Loc2;
            target.Kit_Type = source.Kit_Type;
            target.App_Small_V = source.App_Small_V;
            target.Act_Small_V = source.Act_Small_V;
            target.App_Meduim_V = source.App_Meduim_V;
            target.Act_Meduim_V = source.Act_Meduim_V;
            target.App_Larger_V = source.App_Larger_V;
            target.Act_Larger_V = source.Act_Larger_V;
            target.App_Extra_LV = source.App_Extra_LV;
            target.Act_Extra_LV = source.Act_Extra_LV;
            target.Kit_Status = source.Kit_Status;
            target.Kit_DateTime = source.Kit_DateTime;
            return target;
        }



        private List<KitchenEntity> MapperList(List<Kojin_Kitchen_Master> source, List<KitchenEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Kitchen_Master kitchen in source)
            {
                target.Add(Mapper(kitchen, new KitchenEntity()));
            }
            return target;
        }


      
      
        #endregion


        #region INSERT

        public void InsertKitchenMaster(String Cust_id, String Kit_id, String Kit_Loc1, String Kit_Loc2,  String Kit_Type, Decimal App_Small_V, Decimal Act_Small_V, Decimal App_Meduim_V, Decimal Act_Meduim_V, Decimal App_Larger_V, Decimal Act_Larger_V, Decimal App_Extra_LV, Decimal Act_Extra_LV)
        {
            try
            {
                db.PROC_Kojin_InsertUpdateKitchen(Cust_id, Kit_id, Kit_Loc1, Kit_Loc2, Kit_Type, App_Small_V, Act_Small_V, App_Meduim_V, Act_Meduim_V, App_Larger_V, Act_Larger_V, App_Extra_LV, Act_Extra_LV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion


        #region GET

        public List<KitchenEntity> GetKitchen()
        {
            try
            {
                var result = db.Kojin_Kitchen_Master.ToList();
                return MapperList(result, new List<KitchenEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<KitchenEntity> GetKitchenCustomerWise(String Cust_id)
        {
            try
            {
                var result = db.Kojin_Kitchen_Master.Where(x => x.Cust_id == Cust_id).ToList();
                return MapperList(result, new List<KitchenEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public KitchenEntity GetkitchenDetail(String Kit_id)
        {
            try
            {
                var result = db.Kojin_Kitchen_Master.Where(x => x.Kit_id == Kit_id && x.Kit_Status == 1).FirstOrDefault();
                return result != null ? Mapper(result, new KitchenEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}