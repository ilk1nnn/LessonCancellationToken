using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LessonCancellationToken
{
    public class Program
    {

        //static CancellationToken token;
        //static void Foo1()
        //{
        //    while (true)
        //    {
        //        if (token.IsCancellationRequested)
        //        {
        //            Console.WriteLine("Stop foo1");
        //            break;
        //        }
        //        Console.WriteLine("Salam\n");
        //        Thread.Sleep(100);
        //    }
        //}


        //static void Foo2()
        //{
        //    while (true)
        //    {
        //        if (token.IsCancellationRequested)
        //        {
        //            Console.WriteLine("Stoped from foo2");
        //            break;
        //        }
        //        Console.WriteLine("Hello\n");
        //        Thread.Sleep(100);
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    var cancelSource = new CancellationTokenSource();
        //    token = cancelSource.Token;

        //    Thread th1 = new Thread(Foo1);
        //    th1.Start();
        //    Thread th2 = new Thread(Foo2);
        //    th2.Start();

        //    while (true)
        //    {
        //        if(Console.ReadKey().Key == ConsoleKey.Enter)
        //        {
        //            cancelSource.Cancel();
        //        }
        //    }

        //}



        // --------------------------------------------------------------------------











    }
}
