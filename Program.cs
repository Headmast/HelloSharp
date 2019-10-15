using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Hellow
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // var mPerf = new MegaPerfomance();

            // Console.WriteLine(mPerf.flag);

            // 1 try
            // Stopwatch time = new Stopwatch();
            // time.Start();
            // Console.WriteLine("Start work " + time.Elapsed);
            // Coffee.PourCoffee();
            // Console.WriteLine("Coffee ready " + time.Elapsed);
            // Toast.ToastBread(2);
            // Console.WriteLine("End work " + time.Elapsed);
            // time.Stop();

            // Start work 00:00:00.0000095
            // Coffee ready 00:00:01.0312038
            // End work 00:00:03.0330169

            // 2 try await
            Stopwatch time = new Stopwatch();
            time.Start();
            Console.WriteLine("Start work " + time.Elapsed);
            //object p1 = await Coffee.PourCoffee();
            Console.WriteLine("Coffee ready " + time.Elapsed);
            //object p = await Toast.ToastBread(2);
            Console.WriteLine("End work " + time.Elapsed);
            time.Stop();

        }
    }

    class MegaPerfomance {
        public bool flag = true;

        public MegaPerfomance() {
            
        }
    }

    public class Foo {
        public void first() {  Console.WriteLine("first"); }
        public void second() {  Console.WriteLine("second"); }
        public void third() {  Console.WriteLine("third"); }
    }

    public class Coffee {
        public static async Task<Coffee> PourCoffee() {
            
            var coffee = /*await*/ new Coffee();
            return coffee;
        }

        // public async Coffee() {
        //     System.Threading.Thread.Sleep(1000);
        // }
    }

    public class Toast {
        public static void ToastBread(Int32 second) {
            System.Threading.Thread.Sleep(second * 1000);
        }
    }
}
