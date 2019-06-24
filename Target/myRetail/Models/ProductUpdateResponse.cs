using System;

namespace myRetail.Models
{
    public class ProductUpdateResponse
    {
        public UInt64 prod_id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}