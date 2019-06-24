using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myRetail.Models
{
    public class ProductUpdateResponse
    {
        public UInt64 prod_id { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
    }
}