using Kojin.DAL;
using Kojin.BAL.Entity.KitchenEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class CustmerMasterFactory : BaseEntity
    {
        #region Mapper

        private CustmerMasterEntity Mapper(Kojin_Cust_Master source, CustmerMasterEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Cust_id = source.Cust_id;
            target.Name1 = source.Name1;
            target.Name2 = source.Name2;
            target.Name3 = source.Name3;
            target.Gender = source.Gender;
            target.Address1 = source.Address1;
            target.Address2 = source.Address2;
            target.Address3 = source.Address3;
            target.City = source.City;
            target.State = source.State;
            target.Country = source.Country;
            target.Pincode = source.Pincode;
            target.UserType = source.UserType;
            target.Name1 = source.Name1;
            target.Status = source.Status;
            target.DateTime = source.DateTime;
            return target;
        }

        private Kojin_Cust_Master Mapper(CustmerMasterEntity source, Kojin_Cust_Master target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Cust_id = source.Cust_id;
            target.Name1 = source.Name1;
            target.Name2 = source.Name2;
            target.Name3 = source.Name3;
            target.Gender = source.Gender;
            target.Address1 = source.Address1;
            target.Address2 = source.Address2;
            target.Address3 = source.Address3;
            target.City = source.City;
            target.State = source.State;
            target.Country = source.Country;
            target.Pincode = source.Pincode;
            target.UserType = source.UserType;
            target.Name1 = source.Name1;
            target.Status = source.Status;
            target.DateTime = source.DateTime;
            return target;
        }

        private List<CustmerMasterEntity> MapperList(List<Kojin_Cust_Master> source, List<CustmerMasterEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Cust_Master head in source)
            {
                target.Add(Mapper(head, new CustmerMasterEntity()));
            }
            return target;
        }


        #endregion

        #region CREATE


        public void InsertCustomerMaster(String Cust_id, String Name1, String Name2, String Name3, String Gender, String Address1, String Address2, String Address3, String City, String State, String Country, String Pincode, String UserType)
        {
            try
            {
                db.PROC_Kojin_InsertUpdateCustomer(Cust_id, Name1, Name2, Name3, Gender, Address1, Address2, Address3, City, State, Country, Pincode, UserType);             
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region GET

        public List<CustmerMasterEntity> GetCustomer()
        {
            try
            {
                var result = db.Kojin_Cust_Master.ToList();
               return MapperList(result, new List<CustmerMasterEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public CustmerMasterEntity GetCustomerDetail(String Cust_id)
        {
            try
            {
                try
                {
                    var result = db.Kojin_Cust_Master.Where(x => x.Cust_id == Cust_id && x.Status == 1).FirstOrDefault();
                    return result != null ? Mapper(result, new CustmerMasterEntity()) : null;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion
    }
}