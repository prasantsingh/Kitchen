using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class VendorFactory : BaseEntity
    {
        #region Mapper

        private VendorEntity Mapper(kojin_Vendor_Details source, VendorEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Ven_Code = source.Ven_Code;
            target.Ven_Name = source.Ven_Name;
            target.Ven_Address1 = source.Ven_Address1;
            target.Ven_Address2 = source.Ven_Address2;
            target.Ven_Address3 = source.Ven_Address3;
            target.Ven_City = source.Ven_City;
            target.Ven_State = source.Ven_State;
            target.Ven_Country = source.Ven_Country;
            target.Ven_Pincode = source.Ven_Pincode;
            target.Ven_Phone = source.Ven_Phone;
            target.Ven_Email = source.Ven_Email;
            target.Ven_Status = source.Ven_Status;
            target.Ven_DateTime = source.Ven_DateTime;
            return target;
        }

        private kojin_Vendor_Details Mapper(VendorEntity source, kojin_Vendor_Details target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Ven_Code = source.Ven_Code;
            target.Ven_Name = source.Ven_Name;
            target.Ven_Address1 = source.Ven_Address1;
            target.Ven_Address2 = source.Ven_Address2;
            target.Ven_Address3 = source.Ven_Address3;
            target.Ven_City = source.Ven_City;
            target.Ven_State = source.Ven_State;
            target.Ven_Country = source.Ven_Country;
            target.Ven_Pincode = source.Ven_Pincode;
            target.Ven_Phone = source.Ven_Phone;
            target.Ven_Email = source.Ven_Email;
            target.Ven_Status = source.Ven_Status;
            target.Ven_DateTime = source.Ven_DateTime;
            return target;
        }

        private List<VendorEntity> MapperList(List<kojin_Vendor_Details> source, List<VendorEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (kojin_Vendor_Details vendor in source)
            {
                target.Add(Mapper(vendor, new VendorEntity()));
            }
            return target;
        }

        #endregion

        #region CREATE

        public void InsertVendor(VendorEntity oVendorEntity)
        {
            try
            {
                oVendorEntity.Ven_DateTime = DateTime.Now;
                var objInsert = Mapper(oVendorEntity,new kojin_Vendor_Details());
                db.kojin_Vendor_Details.Add(objInsert);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region UPDATE

        public void UpdateVendor(VendorEntity oVendorEntity, String StrCode)
        {
            try
            {                
                oVendorEntity.Ven_DateTime = DateTime.Now;
                var objUpdate = db.kojin_Vendor_Details.Where(x => x.Ven_Code == StrCode).FirstOrDefault();
                Mapper(oVendorEntity, objUpdate);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region GET

        public List<VendorEntity> GetVendor()
        {
            try
            {
                var result = db.kojin_Vendor_Details.ToList();
                return MapperList(result, new List<VendorEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VendorEntity GetVendorDetails(String strCode)
        {
            try
            {
                var result = db.kojin_Vendor_Details.Where(x => x.Ven_Code == strCode).FirstOrDefault();
                return result != null ? Mapper(result, new VendorEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}