using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int x, y, max;
            max = (int)Math.Pow(2, 31);
            Console.WriteLine("请输入第一个乘数：");
            s = Console.ReadLine();
            x = Int32.Parse(s);
            Console.WriteLine("请输入第二个乘数：");
            s = Console.ReadLine();
            y = Int32.Parse(s);
            if ((x * y > 0 && x * y < max - 1 && x * 1.0 / max * y / max > 0)
                || (x * y < 0 && x * y > -max && x * 1.0 / max * y / max < 0))//判断是否超出范围
            {
                Console.WriteLine("{0} x {1} = {2}", x, y, x * y);
            }
            else
            {
                Console.WriteLine("超出计算范围！");
            }
        }
    }
}
