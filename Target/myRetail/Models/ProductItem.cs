using System;

namespace myRetail.Models
{
    public class ProductItem
    {
        public UInt64 id { get; set; }
        public string name { get; set; }
        public ItemPrice current_price { get; set; }
    }

}