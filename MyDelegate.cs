using System;
namespace MyDelegate{
     class Product
    {
        public string Name{get;set;}
        public double Price{get;set;}
    }
    class Logger
    {
        public void Log(Product product){
        Console.WriteLine("Product '{0}' created at {1}.Price is {2}.",product.Name,DateTime.UtcNow,product.Price);
        }
    }
    class Box
    {
        public Product Product{get;set;}
    }
    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct,Action<Product> logCallBack)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            if(product.Price >= 50)
            {
                logCallBack(product);
            }
            box.Product = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }
        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product;
        }
    }

}