using OrchardCore.Modules;

namespace OrchardCore.Environment.Cache
{
    public static class ModularServicesBuilderExtensions
    {
        /// <summary>
        /// Adds tenant level caching services.
        /// </summary>
        public static ModularServicesBuilder AddCaching(this ModularServicesBuilder builder)
        {
            builder.Services.ConfigureTenantServices((collection) =>
            {
                collection.AddCaching();
            });

            return builder;
        }
    }
}
