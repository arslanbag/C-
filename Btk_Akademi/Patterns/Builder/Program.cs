using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var model= ProductDirector.GenerateProduct(new NewCustomerBuilder());
          /*  var builder = new NewCustomerBuilder();
            director.GenerateProduct(builder);
            var model = builder.GetModel();*/

            Console.WriteLine(model.Id);
            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.ProductName);   
            Console.WriteLine(model.UnitPrice);   
            Console.WriteLine(model.DiscountApplied);   
            Console.WriteLine(model.DiscountedPrice);   
   

            Console.ReadLine();

        }
    }

    class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }

    }
    abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();
        public abstract ProductViewModel GetModel();
    }

    class NewCustomerBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountApplied = true;
            model.DiscountedPrice = model.UnitPrice * (decimal)0.9;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
  
        }
    }
    class OldCustomer : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountApplied = false;
            model.DiscountedPrice = model.UnitPrice;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
   
        }
    }

    static class ProductDirector 
    {
        public static ProductViewModel GenerateProduct(ProductBuilder productBuilder) 
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
            return productBuilder.GetModel();
        }
    }
}
