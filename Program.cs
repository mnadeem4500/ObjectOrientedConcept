using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ItemRecorde
{
    class Program
    {
        public int itemid { get; set; }
        public string itemname { get; set; }
        public string itemcompany { get; set; }
        public double itemprice { get; set; }
        public int itemqty { get; set; }

        public Program (int id, string name, string comapany, double price, int qty ){

            itemid = id;
            itemname = name;
            itemcompany = comapany;
            itemprice = price; 
            itemqty = qty;           
}
        public void show()
        {
            Console.WriteLine(itemid);
            Console.WriteLine(itemname);
            Console.WriteLine(itemcompany);
            Console.WriteLine(itemprice);
            Console.WriteLine(itemqty);
        }
        public double Amount() {
            return itemqty* itemprice;
           
        }
        public void owner()
        {
            Console.WriteLine("CFG Group & Comapanies ");
        }

        static void Main(string[] args)
        {
            Program p = new Program(1001, "Steel", "Mugal", 200, 100);
            p.show();
            p.owner();
            double Avg=p.Amount();
            Console.WriteLine("Your Price is "+ Avg);
           
            Console.ReadLine();
        }
    }
}
