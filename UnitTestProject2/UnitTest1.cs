using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Tax_amount()
        {      
            var tax = Start.Tax_Amount(20, 20.25, 2); // takes tax percentage and product price and number of digits 
            Assert.AreEqual(tax, 4.05); //pass

        }
        [TestMethod]
        public void Discount_amount()
        {
            var discounts = Start.Discounts_Amount(15, 7,20.25,"additive", 2); // takes universal discount , upc discount and product price  and number of digits 
            Assert.AreEqual(discounts, 4.46); //pass
            var discounts2 = Start.Discounts_Amount(15, 7, 20.25, "multiplicative", 2); // takes universal discount , upc discount and product price  and number of digits 
            Assert.AreEqual(discounts2, 4.24); //pass

        }
        [TestMethod]
        public void new_price()
        {
            var newprice = Start.new_price(20.25,20, 15, 7, "+upcdiscount"); // takes universal discount , upc discount and product price  and number of digits 
            Assert.AreEqual(newprice, 19.84); //pass
           

        }
    }
}
