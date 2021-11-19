using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие_19
{
    class Program
    {
        // список компьютеров с набором параметров
        static void Main(string[] args)
        {
           List<Comp>comps = new List<Comp>()
            {
            new Comp() { Code = "001", Name = "ASUS", Type="i7", Frequency = 3500, RAM=8,HDD=256,VideoCard=2,Price=245,Quantity=8},
            new Comp() { Code = "002", Name = "ACER", Type="Pentium", Frequency = 3200, RAM=16,HDD=512,VideoCard=2,Price=300,Quantity=10},
            new Comp() { Code = "003", Name = "APPLE", Type="AM1", Frequency = 3000, RAM=32,HDD=1024,VideoCard=2,Price=450,Quantity=12},
            new Comp() { Code = "004", Name = "DELL", Type="i5", Frequency = 2400, RAM=8,HDD=256,VideoCard=2,Price=390,Quantity=11},
            new Comp() { Code = "005", Name = "LENOVO", Type="Celeron", Frequency = 4200, RAM=16,HDD=512,VideoCard=2,Price=180,Quantity=9},
            new Comp() { Code = "006", Name = "HP", Type="Xeon", Frequency = 3200, RAM=32,HDD=1024,VideoCard=2,Price=290,Quantity=7},
            };
        }
        class Comp
        {
            public string Code { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public int Frequency { get; set; }
            public int RAM { get; set; }
            public int HDD { get; set; }
            public int VideoCard { get; set; }
            public int Price { get; set; }
            public int Quantity { get; set; }



        }
                
        
    }
}
