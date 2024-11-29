using System;

namespace VendingMachineNew
{
    class Product
    {
        public string Row { get; private set; }
        public double Price { get; private set; }
        public double Count { get; set; }


        /*
           Constructs a Product object
           @param aDescription the description of the product
           @param aPrice the price of the product
        */
        public Product(string theRow, double thePrice, int theCount)
        {
            Row = theRow;
            Price = thePrice;
            Count = theCount;

        }
        /*
           Determines of this product is the same as the other product.
           @param other the other product
           @return true if the products are equal, false otherwise
        */
        //public bool equals(object other)
        //{
        //    if (other == null)
        //    {
        //        return false;
        //    }
        //    Product b = (Product)other;
        //    return Description.Equals(b.Description) && Price == b.Price;
        //}
        /*
           Formats the product's description and price.
        */
        //public override string ToString()
        //{

        //    String priceString = Price.ToString("C");
        //    return Description + " @ " + priceString;
        //}
    }
}

