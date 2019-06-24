﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;

namespace myRetail.Models
{
    public class ProductItem
    {
        public UInt64 id { get; set; }
        public string name { get; set; }
        public ItemPrice current_price { get; set; }
    }

}