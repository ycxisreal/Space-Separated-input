using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace app
{
    class newproject
    {
        //Separate your input by Space
        //实现用空格将各输入数据分隔开
        static void Main(string[] args)
        {
            Console.WriteLine("输入一行数字：");
            string line=Console.ReadLine();
            string[] afterlines = line.Split(' ');//表示字符串中数据用' '相间隔。
            foreach (string afterline in afterlines)
            {
                Console.WriteLine(afterline);
            }
            Console.WriteLine("=============");
            Console.WriteLine(afterlines.Count());//为剪切的字符串计数
            Console.ReadKey();
        }
    }
}