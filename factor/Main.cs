using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace factor
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("終了するときは exit を実行してください");
            var sw = new System.Diagnostics.Stopwatch();

            while (true)
            {
                Console.WriteLine("数を入力してください:");

                string cin = Console.ReadLine();
                BigInteger n = 0;
                if (BigInteger.TryParse(cin, out n))
                {
                    sw.Start();
                    var cal = new Cal();
                    BigInteger factor = cal.Factor(n);
                    sw.Stop();

                    Console.WriteLine("かかった時間" + sw.ElapsedMilliseconds + " [ms]");
                    Console.WriteLine("因数:" + factor);
                    Console.WriteLine("数字:" + (factor*factor));
                    Console.WriteLine("元は:" + n);
                    sw.Reset();
                }
                else if(cin == "exit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("文字は入力できません");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("終了するには何かキーを押してください...");
            Console.ReadKey();
        }
    }
}
