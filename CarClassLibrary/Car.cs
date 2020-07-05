using System;

namespace CarClassLibrary
{
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public decimal price { get; set; }
        //udusly prices are kept in dcimals

        public Car()
        {
            this.make = "nothing yet";
            this.model = " nothing yet";
            this.price = 00.00M;
            //M convert String to Decimal value
        }

        public Car(string mk, string md, decimal pr)
        {
           this.make = mk;
           this.model = md;
           this.price = pr;
        }

        public string ToStrings()
        {
            return make +" "+ model +" LKR " +price +" Million ";
        }

    }
}
