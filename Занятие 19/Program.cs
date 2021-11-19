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
            new Comp() { Code = "001", Name = "ASUS", Type="i7", Frequency = 3200, RAM=8,VolHdd=256,VolMemGpu=2,Cost=50000, Number=120},
           
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
