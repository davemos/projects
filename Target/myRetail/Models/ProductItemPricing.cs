using MongoDB.Bson;
using System;

namespace myRetail.Models
{
    public class ProductItemPricing
    {
        public ObjectId _id { get; set; }
        public UInt64 prod_id { get; set; }
        public ItemPrice current_price { get; set; }
    }
}