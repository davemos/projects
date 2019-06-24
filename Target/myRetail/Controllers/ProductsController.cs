using System;
using System.Web.Http;
using myRetail.Models;

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
            ProductItemPricing itemPrice = new ProductItemPricing();
            ProductItem item = new ProductItem();
            RedSkyApi redSkyApi = new RedSkyApi();
            string name = redSkyApi.GetProductName(id);
            if (!string.IsNullOrEmpty(name))
            {
                itemPrice = _Context.GetProductPrice(id);
                item.id = UInt64.Parse(id);
                item.name = name;
                item.current_price = itemPrice.current_price;
            }
           
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
