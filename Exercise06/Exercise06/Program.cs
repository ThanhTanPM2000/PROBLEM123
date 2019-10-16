using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            QuanLy ql = new QuanLy(200000);
            while (true)
            {
                ql.Showmenu();
            } 
        }
    }
}
