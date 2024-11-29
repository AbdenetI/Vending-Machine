using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;

namespace VendingMachineNew
{
    class VendingMachine
    {
        private List<Product> products;
        public static CoinBox coins;  // main coin box
        public static CoinBox currentCoins;// temp for inserted coins

        public bool AreItems
        {
            get
            {
                if (products.Count > 0) return true;
                else return false;
            }

        }

        /*
           Constructs a VendingMachine object.
        */
        public VendingMachine(List<Product> p)
        {
            products = p;           
            coins = new CoinBox();
            currentCoins = new CoinBox();
            
        }

        /*
           Gets the type of products in the vending machine.
           @return an array of products sold in this machine.
        */
        //public List<Product> getProductTypes()
        //{
        //    List<Product> types = new List<Product>();

        //    for (int i = 0; i < products.Count; i++)
        //    {
        //        Product entry = products[i];
        //        types.Add(entry);
        //    }

        //    var sortedList = types.OrderBy(o => o.Description).ToList();
        //    return sortedList;
        //}

        /*
           Adds a product to the vending machine.
           @param p the product to add
           @param quantity the quantity
        */
        //public void addProduct(Product p, int quantity)
        //{
        //    for (int i = 0; i < quantity; i++)
        //        products.Add(p);
        //}


        /*
         * public double PickCoin()
         * {
         * c  = listBox1.SelectedItem.ToString();
         * }
         * 
        /*
           Adds the coin to the vending machine.
           @param c the coin to add
        */
        public void AddCoin(Coin c)
        {
            currentCoins.AddCoin(c);
            
        }

        /*
           Buys a product from the vending machine.
           @param p the product to buy
        */
        public static double BuyProduct(Product p)
        {
            p.Count =- 1;
            
            double change = (currentCoins.GiveChange(Math.Round(currentCoins.GetValue() - p.Price, 2))).GetValue();
            coins.AddCoins(currentCoins);
            currentCoins.RemoveAllCoins();
            Console.WriteLine(change);
            return change; //change;
        }

        //public static string BuyProduct(Product p)
        //{
        //    for (int i = 0; i < products.Count; i++)
        //    {
        //        Product prod = products[i];
        //        if (prod.equals(p))
        //        {
        //            double payment = currentCoins.GetValue();
        //            if (p.Price <= payment)
        //            {
        //                products.RemoveAt(i);
        //                GiveChange(coins, p.Price);
        //                coins.AddCoins(currentCoins);
        //                currentCoins.RemoveAllCoins();
        //                return "OK";
        //            }
        //            else
        //            {
        //                return "Insufficient money";
        //            }
        //        }
        //    }
        //    return "No such product";
        //}

        public double CancelTransaction()
        {
            double money = currentCoins.GetValue();
            currentCoins.RemoveAllCoins();

            return money;
        }
        /*
           Removes the money from the vending machine.
           @return the amount of money removed
        */
        public double removeMoney()
        {
            double r = coins.GetValue();
            coins.RemoveAllCoins();
            return r;
        }
    }
}
