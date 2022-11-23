using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory peoples = new Inventory();
            //Console.WriteLine(peoples.ItemNum);
            //peoples.ItemNum = "405064";
            string respo = peoples.getItemNum();
            Console.WriteLine(respo);
            //Console.WriteLine(peoples.ItemNum);
            Console.ReadLine();
            
        }
    }
}
