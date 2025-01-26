
namespace ShopRavenDB.Infrastructure.CrossCutting.Ioc
{
    public static class ServicesCollectionExtensions
    {
        public static IServiceCollection AddRavenDb(this IServiceCollection ServicesCollection)
        {

            ServicesCollection.TryAddSingleton<IDocumentStore>(ctx =>
            {
                var store = new DocumentStore
                {
                    Urls = new[] { "http://loc alhost:8080" },
                    Database = "Shop"
                };
                store.Initialize();
                return store;
            });

            return ServicesCollection;
        }
    }
}
