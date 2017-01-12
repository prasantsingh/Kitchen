using Kojin.BAL.Entity;
using Kojin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kojin.BAL.Factory
{
    public class CountryFactory : BaseEntity
    {
        #region Mapper

        private CountryEntity Mapper(Kojin_Country source, CountryEntity target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            target.cou_code = source.cou_code;
            target.name = source.name;
            target.cou_name = source.cou_name;
            target.iso3 = source.iso3;
            target.numcode = source.numcode;
            return target;
        }


        private List<CountryEntity> MapperList(List<Kojin_Country> source, List<CountryEntity> target)
        {
            if (source == null) throw new ArgumentNullException("source");
            if (target == null) throw new ArgumentNullException("target");

            foreach (Kojin_Country country in source)
            {
                target.Add(Mapper(country, new CountryEntity()));
            }
            return target;
        }
        
        #endregion

        #region GET

        public List<CountryEntity> Country()
        {
            try
            {
                var result = db.Kojin_Country.OrderBy(x => x.cou_name).ToList();
                return MapperList(result, new List<CountryEntity>());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}