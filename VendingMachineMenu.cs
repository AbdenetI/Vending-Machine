using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineNew
{
    class VendingMachineMenu
    {
            //private static readonly Coin[] COINS = {
            //Coin.NICKEL, Coin.DIME, Coin.QUARTER, Coin.DOLLAR };

            /*
               Runs the vending machine system.
               @param machine the vending machine
            */
            public void Run(VendingMachine machine)
            {
                bool more = true;

                while (more)
                {
                    //    Write("S)how products A)dd B)uy product I)nsert R)emove coins Q)uit: ");
                    //    String command = ReadLine().ToUpper();

                    //    if (command.Equals("S"))
                    //    {               
                    //        int num = 0;
                    //        List<Product> types = machine.getProductTypes();
                    //        Product temp;

                    //        for (int i = 0; i < types.Count;)
                    //        {
                    //            temp = types[i];
                    //            foreach (Product x in types)
                    //            {
                    //                if (x.equals(temp))
                    //                {
                    //                    num++;  
                    //                }
                    //            }                   
                    //            WriteLine(temp + ": Amount: " + num);
                    //            i += num;
                    //            num = 0;
                    //        }
                    //    }
                    //    else if (command.Equals("A"))
                    //    {
                    //        Write("Description: ");
                    //        string description = ReadLine();
                    //        Write("Price: ");
                    //        double price = Convert.ToDouble(ReadLine());
                    //        Write("Quantity: ");
                    //        int quantity = Convert.ToInt32(ReadLine());
                    //        machine.addProduct(new Product(description, price), quantity);
                    //    }
                    //    else if (command.Equals("I"))
                    //    {
                    //        Coin chosen = PickCoin();
                    //        WriteLine("Current " + machine.AddCoin(chosen).ToString("C"));
                    //    }
                    //    else if (command.Equals("B"))
                    //    {
                    //        if (machine.AreItems)
                    //        {
                    //            Product p = PickProduct(machine.getProductTypes());
                    //            string result = machine.BuyProduct(p);
                    //            if (result == "OK")
                    //            {
                    //                WriteLine("Purchased: " + p);
                    //            }
                    //            else
                    //            {
                    //                WriteLine("Sorry: " + result);
                    //            }
                    //        }
                    //        else
                    //        {
                    //            WriteLine("Sorry. The Vending Machine is currently empty. Please come again!");
                    //        }               
                    //    }
                    //    else if (command.Equals("R"))
                    //    {
                    //        double totalInCoinBox = machine.removeMoney();

                    //        WriteLine("Removed: " + totalInCoinBox.ToString("C"));
                    //    }
                    //    else if (command.Equals("Q"))
                    //    {
                    //        more = false;
                    //    }
                }
            }

            // Pick a coin from the list of all coins
            //private Coin PickCoin()
            //{
            //    while (true)
            //    {
            //        char c = 'A';
            //        foreach (Coin choice in COINS)
            //        {

            //            WriteLine(c + ") " + choice);
            //            c++;

            //        }
            //        char input = Convert.ToChar(ReadLine());
            //        int n = char.ToUpper(input) - 'A';

            //        if (0 <= n && n < COINS.Length)
            //        {
            //            return COINS[n];
            //        }

            //    }
            //}

            // Pick a product from all products
            //private Product PickProduct(List<Product> allProducts)
            //{
            //    Product temp = null;
            //    while (true)
            //    {
            //        char c = 'A';
            //        foreach (Product choice in allProducts)
            //        {
            //            if (!choice.equals(temp))
            //            {
            //                WriteLine(c + ") " + choice);
            //                c++;
            //            }
            //            temp = choice;

            //        }
            //        char input = Convert.ToChar(ReadLine());
            //        int n = char.ToUpper(input) - 'A';
            //        if (0 <= n && n < allProducts.Distinct().Count())
            //        {
            //            var p = allProducts.Distinct().ToList();
            //            return p[n];
            //        }
            //    }
            //}

            
    }
}


