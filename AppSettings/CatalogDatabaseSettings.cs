using Catalog.API.AppSettings.Interfaces;
using System;

namespace Catalog.API.AppSettings
{
    public class CatalogDatabaseSettings : ICatalogDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CollectionName { get; set; }
    }
}
