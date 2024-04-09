using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp_Training
{
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static List<Product> GetAllProducts()
        {
            try
            {
                var products = new List<Product>()
                {
                    new Product { ProductID = 1, Name = "Football", Brand = "Nike", Price = 20.00 },
                    new Product { ProductID = 2, Name = "Basketball", Brand = "Adidas", Price = 25.00 },
                    new Product { ProductID = 3, Name = "Tennis Racket", Brand = "Wilson", Price = 50.00 }
                };
                return products;
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
            return null;
        }
    }
}

public class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
}
