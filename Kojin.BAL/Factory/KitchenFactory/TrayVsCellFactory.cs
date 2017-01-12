using Kojin.BAL.Entity.KitchenEntity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory.KitchenFactory
{
    public class TrayVsCellFactory : BaseEntity
    {
        #region Mapper

        private TrayVsCellEntity Mapper(Kojin_Kitchen_Tray_Master source, TrayVsCellEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.Kit_id = source.Kit_id;
            target.Tray_Id = source.Tray_Id;
            target.No_Of_Cell = source.No_Of_Cell;
            target.D_Cell_1 = source.D_Cell_1;
            target.D_Cell_2 = source.D_Cell_2;
            target.D_Cell_3 = source.D_Cell_3;
            target.D_Cell_4 = source.D_Cell_4;
            target.D_Cell_5 = source.D_Cell_5;
            target.D_Temp_1 = source.D_Temp_1;
            target.D_Status = source.D_Status;
            target.D_DateTime = source.D_DateTime;
            return target;
        }

        private List<TrayVsCellEntity> MapperList(List<Kojin_Kitchen_Tray_Master> source, List<TrayVsCellEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Kitchen_Tray_Master TrayVsCell in source)
            {
                target.Add(Mapper(TrayVsCell, new TrayVsCellEntity()));
            }
            return target;
        }


        #endregion

        #region CREATE

        public void InsertTrayVsCell(String Kit_id, String Tray_Id, Int32 No_Of_Cell, String D_Cell_1, String D_Cell_2, String D_Cell_3, String D_Cell_4, String D_Cell_5, String D_Temp_1)
        {
            try
            {
                db.PROC_Kojin_InsertUpdateKitchenTrayMaster(Kit_id, Tray_Id, No_Of_Cell, D_Cell_1, D_Cell_2, D_Cell_3, D_Cell_4, D_Cell_5, D_Temp_1);
            }
            catch (Exception eX)
            {
                throw eX;
            }
        }

        #endregion

        #region GET


        public List<TrayVsCellEntity> GetTrayVsCell()
        {
            try
            {
                var result = db.Kojin_Kitchen_Tray_Master.ToList();
                return MapperList(result, new List<TrayVsCellEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TrayVsCellEntity GetTrayVsCellDetails(String Tray_Id)
        {
            try
            {
                var result = db.Kojin_Kitchen_Tray_Master.Where(x => x.Tray_Id == Tray_Id).FirstOrDefault();
                return result != null ? Mapper(result, new TrayVsCellEntity()) : null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}