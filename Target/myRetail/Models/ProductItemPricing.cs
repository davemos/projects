using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myRetail.Models
{
    public class ProductItemPricing
    {
        public ObjectId _id { get; set; }
        public UInt64 prod_id { get; set; }
        public ItemPrice current_price { get; set; }
    }
}