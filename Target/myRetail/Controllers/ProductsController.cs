using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using myRetail.Models;
using myRetail.Properties;
using MongoDB.Driver;

namespace myRetail.Controllers
{
    public class ProductsController : ApiController
    {
        public ProductContext _Context = new ProductContext();

        // GET: api/Products
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
