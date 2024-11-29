using System;
using System.Collections.Generic;
using System.Linq;
namespace VendingMachineNew
{
    class Coin
    {

        public double Value { get; private set; }
        public string Name { get; private set; }

        public static Coin NICKEL = new Coin(.05, "nickel");
        public static Coin DIME = new Coin(.10, "dime");
        public static Coin QUARTER = new Coin(.25, "quarter");
        public static Coin DOLLAR = new Coin(1.0, "dollar");
        public static Coin FIVE_DOLLAR = new Coin(5.0, "five dollar");

        /*
           Constructs a coin.
           @param aValue the monetary value of the coin.
           @param aName the name of the coin
        */
        public Coin(double aValue, String aName)
        {
            Value = aValue;
            Name = aName;
        }
        public override string ToString()
        {
            return Name + " @ " + Value.ToString("C");
        }
    }
}

