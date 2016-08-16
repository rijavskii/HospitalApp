using System.Data.Entity;
using System.Linq;
using EntityDb.Context;

namespace HospitalApp
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Extension'
    public static class Extension
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Extension'
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member 'Extension.AddIfNoExists(DbSet<Manufacturer>, Manufacturer)'
        public static DbSet<Manufacturer> AddIfNoExists(this DbSet<Manufacturer> source, Manufacturer item)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member 'Extension.AddIfNoExists(DbSet<Manufacturer>, Manufacturer)'
        {
            if (!source.Any(x => x.Country == item.Country && x.FactoryName == item.FactoryName))
            {
                source.Add(item);
            }
            return source;
        }
    }
}