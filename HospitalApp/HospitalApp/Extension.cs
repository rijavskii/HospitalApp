using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EntityDb.Context;

namespace HospitalApp
{
    public static class Extension
    {
        public static DbSet<Manufacturer> AddIfNoExists(this DbSet<Manufacturer> source, Manufacturer item)
        {
            if (!source.Any(x => x.Country == item.Country && x.FactoryName == item.FactoryName))
            {
                source.Add(item);
            }
            return source;
        }

        
    }
}