using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using myRetail.Models;
using myRetail.Properties;
using Microsoft.Ajax.Utilities;
using MongoDB.Bson.IO;
using MongoDB.Driver;
using Newtonsoft.Json;

namespace myRetail.Controllers
{
    public class ProductsController : ApiController
    {
        public ProductContext _Context = new ProductContext();

        // GET: api/Products
        public IHttpActionResult Get()
        {
            return BadRequest("Not Implemented");
        }

        // GET: api/Products/5
        public ProductItem Get(string id)
        {

            RedSkyApi redSkyApi = new RedSkyApi();
            string name = redSkyApi.GetProductName(id);
            ProductItemPricing itemPrice = _Context.GetProductPrice(id);
            ProductItem item = new ProductItem
            {
                id = UInt64.Parse(id),
                name = name,
                current_price = itemPrice.current_price
            };
            return item;
        }

        // POST: api/Products
        public IHttpActionResult Post([FromBody]string value)
        {
            return BadRequest("Not Implemented");
        }

        // PUT: api/Products/5
        public IHttpActionResult Put(int id, [FromBody]ProductItem value)
        {
            ProductUpdateResponse resp = _Context.UpdateProductPrice(value);
            if (resp.Status == "Success")
            {
                return Ok(resp);
            }
            else
            {
                return BadRequest(resp.Message);
            }
        }

        // DELETE: api/Products/5
        public IHttpActionResult Delete(int id)
        {
            return BadRequest("Not Implemented");
        }
    }
}
