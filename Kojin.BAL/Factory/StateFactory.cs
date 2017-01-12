using Kojin.BAL.Entity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory
{
    public class StateFactory : BaseEntity
    {
        #region Mapper

        private StateEntity Mapper(Kojin_province source, StateEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");
            
            target.id = source.id;
            target.province_name = source.province_name;
            target.province_code = source.province_code;
            target.cou_code = source.cou_code;
            return target;
        }


        private List<StateEntity> MapperList(List<Kojin_province> source, List<StateEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_province state in source)
            {
                target.Add(Mapper(state, new StateEntity()));
            }
            return target;
        }

        #endregion


        #region GET
        public List<StateEntity> State()
        {
            try
            {
                var result = db.Kojin_province.OrderBy(x => x.province_name).ToList();
                return MapperList(result, new List<StateEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}