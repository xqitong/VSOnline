using System;
using System.Collections.Generic;
using System.Threading;
namespace MulticastDelegate{
class Student
{
    public int ID{get;set;}
    public ConsoleColor PenColor {get;set;}

     public void DoHomeWork()
     {
        //Console.ForegroundColor = this.PenColor;
        for(int i = 0; i < 5; ++i)
        {
            Console.ForegroundColor = this.PenColor;
            Console.WriteLine("Student {0} doing homework {1} hour(s).",this.ID,i);
            Thread.Sleep(500);
        }
     }
}

}