using System;
using System.Timers;
namespace MyEvent{

    class Boy
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("timer is calling me");
            //throw new NotImplementedException();
        }
    }
    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("sing a song");
            //throw new NotImplementedException();
        }
    }
}