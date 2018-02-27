using System;

namespace AsyncCoinMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin");
            var miningManager = new AsyncCoinMiningManager();
            miningManager.Execute();
            Console.ReadKey();
        }
    }
}
