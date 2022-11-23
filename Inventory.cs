using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Inventory
    {
        private string itemNum;
        private string desc;
        private double pricePerItem;
        private int quantity;
        private double ourCost;
        private double totalValue;
       
        public string ItemNum
        {
            get { return itemNum; }
            set { itemNum = value; }
        }
        public string getItemNum()
        {
            if (ItemNum == null)
            {
                return "That item doesn't exist.";
            }
            else
            {
                return ItemNum;
            }


        }

        public void setItemNum()
        {
            Console.Write("What is the item #? ");
            itemNum = Console.ReadLine();
            
        }





    }
}
