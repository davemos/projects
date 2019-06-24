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

        public ProductUpdateResponse UpdateProductPrice(ProductItem itemPrice)
        {
            var filter = Builders<ProductItem>.Filter.Eq(Settings.Default.ProductIdFieldName, itemPrice.id);
            var collection = Database.GetCollection<ProductItem>(Settings.Default.ProductPricingCollectionName);
            var update = Builders<ProductItem>.Update.Set("current_price", itemPrice.current_price);
            var result = collection.UpdateOne(filter, update);
            ProductUpdateResponse resp  = new ProductUpdateResponse();
            resp.prod_id = itemPrice.id;
            resp.Status = result.ModifiedCount == 1 ? "Success" : "Failure";
            resp.Message = result.ModifiedCount == 1 ? "Updated Product Price" : "Failed to Update Product Price";
            return resp;
        }
    }
}