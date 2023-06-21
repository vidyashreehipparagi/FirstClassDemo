using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date date1= new Date();
            date1.AcceptData(16, "june", 2023);
            string data=date1.PrintDate();
            Console.WriteLine(data);
            Console.WriteLine(date1.PrintDate());
            int y=date1.PrintYear();
            Console.WriteLine(y);
           // Console.WriteLine(date1.GetMonth();
        }
    }
}
