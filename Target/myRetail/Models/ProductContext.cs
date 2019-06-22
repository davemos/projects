using System.Linq;
using MongoDB.Driver;
using myRetail.Properties;

namespace myRetail.Models
{
    public class ProductContext
    {
        public IMongoDatabase Database;
        public ProductContext()
        {
            var client = new MongoClient(Settings.Default.ProductPricingConnection);
            Database = client.GetDatabase(Settings.Default.ProductPricingDatabaseName);
            
        }

        public ProductItemPricing GetProductPrice(string id)
        {
            var filter = Builders<ProductItemPricing>.Filter.Eq(Settings.Default.ProductIdFieldName,id);
            var collection = Database.GetCollection<ProductItemPricing>(Settings.Default.ProductPricingCollectionName);
            var items = collection.Find(filter).ToList();
            return items[0];
        }
    }
}