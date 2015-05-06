using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinJar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Tests
            CoinJar jar = new CoinJar();
            jar.Insert(USDCoin.Dime);
            jar.Insert(USDCoin.Quarter);
            jar.Insert(USDCoin.Nickel);
            jar.Insert(USDCoin.Penny);
            jar.Insert(USDCoin.HalfDollar);
            jar.Insert(USDCoin.Dollar);
            Console.WriteLine("Jar has " + jar.currency + " USD");
            try
            {
                jar.Insert(CADCoin.Toonie);
                Console.WriteLine("Test Failed : Excepted CoinJar only accept USD");
            }
            catch (Exception e)
            {
            }
            try
            {
                for (int i = 0; i < 1000; i++)
                {
                    jar.Insert(USDCoin.Dollar);
                }
                Console.WriteLine("Test Failed : Excepted CoinJar to be full");
            }
            catch (Exception e)
            {
            }
            jar.Clear();
            jar.Insert(USDCoin.Dime);
            jar.Insert(USDCoin.Quarter);
            Console.WriteLine("Jar has " + jar.currency + " USD");

            //Test jar that accept different currency
            CoinJar jar2 = new CoinJar(32, true);
            jar2.Insert(USDCoin.Dollar);
            jar2.Insert(CADCoin.Dollar);
            jar2.Insert(USDCoin.Quarter);
            jar2.Insert(CADCoin.Toonie);
            Console.WriteLine("Jar2 has " + jar2.currency + " USD");
            jar2.Clear();
            Console.WriteLine("Jar2 has " + jar2.currency + " USD");
            Console.Read();
        }
    }
}
