using System;
using MyDelegate;
using MulticastDelegate;
using System.Threading;
using System.Threading.Tasks;
namespace workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ProductFactory productFactory = new ProductFactory();
            //WrapFactory wrapFactory = new WrapFactory();
            //Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            //Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            //Logger logger= new Logger();
            //Action<Product> log = new Action<Product>(logger.Log);

            //Box box1 = wrapFactory.WrapProduct(func1,log);
            //Box box2 = wrapFactory.WrapProduct(func2,log);
            //Console.WriteLine(box1.Product.Name);
            //Console.WriteLine(box2.Product.Name);
            //
            Student stu1 = new Student(){ID = 1, PenColor = ConsoleColor.Yellow};
            Student stu2 = new Student(){ID = 2, PenColor = ConsoleColor.Green};
            Student stu3 = new Student(){ID = 3, PenColor = ConsoleColor.Red};
            //Action action1 = new Action(stu1.DoHomeWork);
            //Action action2 = new Action(stu2.DoHomeWork);
            //Action action3 = new Action(stu3.DoHomeWork);
            // 在虚拟机上 action BeginInvoke 不好用
            //action1.BeginInvoke(null,null);
            //action2.BeginInvoke(null,null);
            //action3.BeginInvoke(null,null);
            
            // Thread 是好用的 
            //Thread th1 = new Thread(new ThreadStart(stu1.DoHomeWork));
            //Thread th2 = new Thread(new ThreadStart(stu2.DoHomeWork));
            //th1.Start();
            //th2.Start(); 
            //task
            //Task ts1 = new Task(new Action(stu1.DoHomeWork));
            //Task ts2 = new Task(new Action(stu2.DoHomeWork));
            //Task ts3 = new Task(new Action(stu3.DoHomeWork));
            //ts1.Start();
            //ts2.Start();
            //ts3.Start();

            //for(int i = 0; i <10; i++)
           // {
             //   Console.ForegroundColor = ConsoleColor.Cyan;
             //   Console.WriteLine("Main thread{0}",i);
             //   Thread.Sleep(1000);
           // }
            
        }
    }
   
}

