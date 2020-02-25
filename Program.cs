using System;
using MyDelegate;
namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();
            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            Logger logger= new Logger();
            Action<Product> log = new Action<Product>(logger.Log);

            Box box1 = wrapFactory.WrapProduct(func1,log);
            Box box2 = wrapFactory.WrapProduct(func2,log);
            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);
            
        }
    }
   
}

