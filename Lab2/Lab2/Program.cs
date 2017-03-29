using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace na_PR2
{
    class Program
    {

        private static readonly CountdownEvent Countdown1 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown2 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown3 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown4 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown5 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown6 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown7 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown8 = new CountdownEvent(1);
        private static readonly CountdownEvent Countdown9 = new CountdownEvent(1);


        static void Main(string[] args)
        {
            Thread thread1 = new Thread(firstThread);
            Thread thread2 = new Thread(secondThread);
            Thread thread3 = new Thread(thirdThread);
            Thread thread4 = new Thread(fourThread);
            Thread thread5 = new Thread(fiveThread);
            Thread thread6 = new Thread(sixThread);
            Thread thread7 = new Thread(sevenThread);
            Thread thread8 = new Thread(eightThread);
            Thread thread9 = new Thread(nineThread);


            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
            thread6.Start();
            thread7.Start();
            thread8.Start();
            thread9.Start();


            Console.ReadKey();
        }


        static void firstThread()
        {
            Console.WriteLine(" thread  1");
            Countdown1.Signal();

        }
        static void secondThread()
        {
            Console.WriteLine(" thread  2");
            Countdown2.Signal();
        }
        static void thirdThread()
        {
            Console.WriteLine(" thread  3");
            Countdown3.Signal();
        }
        static void fourThread()
        {
            Countdown1.Wait();
            Countdown2.Wait();
            Countdown3.Wait();
            Console.WriteLine(" thread  4");
            Countdown4.Signal();
        }
        static void fiveThread()
        {
            Countdown4.Wait();
            Countdown8.Wait();
            Countdown9.Wait();
            Console.WriteLine(" thread  5");

        }
        static void sixThread()
        {
            Countdown4.Wait();
            Countdown8.Wait();
            Countdown9.Wait();
            Console.WriteLine(" thread  6");

        }
        static void sevenThread()
        {
            Countdown4.Wait();
            Countdown8.Wait();
            Countdown9.Wait();
            Console.WriteLine(" thread  7");

        }
        static void eightThread()
        {
            Console.WriteLine(" thread  8");
            Countdown8.Signal();
        }
        static void nineThread()
        {
            Console.WriteLine(" thread  9");
            Countdown9.Signal();
        }

    }
}
