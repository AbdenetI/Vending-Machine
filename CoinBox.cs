using System.Collections.Generic;
using System;
namespace VendingMachineNew
{
    class CoinBox
    {
        private List<Coin> box;

        /*
           Constructs a CoinBox object.
        */
        public CoinBox()
        {
            box = new List<Coin>();
        }

        /*
           Adds a coin.
           @param c the coin to add
        */
        public void AddCoin(Coin c)
        {
            box.Add(c);
        }

        /*
           Adds coins from one coinbox to another.
           @param other the box of coins
        */
        public void AddCoins(CoinBox other)
        {
            box.AddRange(other.box);
        }

        /*
           Gets the value of all the coins.
           @return total the total value of all the coins
        */
        public double GetValue()
        {
            double total = 0;
            foreach (Coin c in box)
            {

                total += c.Value;

            }


            return total;
        }

        /*
           Removes all the coins.
        */
        public void RemoveAllCoins()
        {
            box.Clear();
        }

        /*
          Removes one coin.
        */
        public void Remove(Coin ex)
        {
            box.Remove(ex);
        }

        /*
          Gives change and removes coins from current coin box.
          @return CoinBox of change
        */
        
        public CoinBox GiveChange(double moneyChange)
        {
            CoinBox change = new CoinBox();
            
                
                    
                    
            
            FigureOutChange(moneyChange, change);
                    
                

            
            return change;
        }
        private CoinBox FigureOutChange(double money, CoinBox box)
        {
            while (money >= 0.05)
            {
                if (money / 5.0 >= 1)
                {
                    box.AddCoin(Coin.FIVE_DOLLAR);
                    money -= 5;
                }
                else if (money / 1.0 >= 1)
                {
                    box.AddCoin(Coin.DOLLAR);
                    money -= 1;
                }
                else if (money / 0.25 >= 1)
                {
                    box.AddCoin(Coin.QUARTER);
                    money -= 0.25;
                }
                else if (money / 0.10 >= 1)
                {
                    box.AddCoin(Coin.DIME);
                    money -= 0.10;
                }
                else if (money / 0.05 >= 1)
                {
                    box.AddCoin(Coin.NICKEL);
                    money -= 0.05;
                }
                money = Math.Round(money, 2);
            }
            return box;
        }
    }
}
