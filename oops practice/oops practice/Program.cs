using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice
{
    class Billing
    {
        private int itemid, itemqty;
        private string itemname;
        private double price, total, disc, totalamount;

        public void GetBillingDetails()
        {
            Console.WriteLine("Enter Item id & Item Name: ");
            itemid = Convert.ToInt32(Console.ReadLine());
            itemname = Console.ReadLine();
            Console.WriteLine("Enter Price & Quantity: ");
            price = Convert.ToDouble(Console.ReadLine());
            itemqty = Convert.ToInt32(Console.ReadLine());
        }
        public void Getcalc()
        {
            total = itemqty * price;
            disc = total * 15 / 100;
            totalamount = total - disc;
        }
        public void DispBill()
        {
            Console.WriteLine("itemid: " + itemid + "itemname: " + itemname);
            Console.WriteLine("price: {0},\n itemqty: {1} \n total: {2}", itemqty, price, total);
            Console.WriteLine("Discount: {0} \n TotalAmount: {1} ", disc, totalamount);
        }


    }
    }

        
  