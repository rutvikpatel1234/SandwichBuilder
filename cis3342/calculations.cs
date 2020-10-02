using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342
{
    public class Calculations
    {
       private  double total = 0.0;

        
        public void calculateSize(string size)
        {
            double cost = 0;
            switch (size)
            {
                case "6inch $4.00":
                    cost = 4.00;
                    break;
                case "12inch $8.00":
                    cost = 8.00;
                    break;
            }
            total += cost;
            //return cost;
        }

        public void calculatetoast(string toast)
        {
            double cost = 0;
            if (toast == "toasted")
            {
                cost = 0;
                total += cost;
            }
            else
            {
                total += cost;
            }
        }

        public void calculatesauces(string sauces)
        {
            double cost = 0;
            total += cost;
        }

        public void calaculateveggies(string veggies)
        {
            double cost = 1.00;
            total+= cost;
        }
        public void calaculatemeat(string meat)
        {
            double cost = 2.00;
            total+= cost;
        }
        public void calaculateextra(string extra)
        {
            double cost = 0;
            switch (extra)
            {
                case "Extra Meat $1.50 ":
                    cost = 1.50;
                    break;
                case "Guacamole $2.00 ":
                    cost = 2.00;
                    break;
                case "Extra Cheese $1.00 ":
                    cost = 1.00;
                    break;
            }
            total+= cost;
        }

        public void calaculateslide(string slide)
        {
            double cost = 0;
            switch (slide)
            {
                case "Chips $1.49 ":
                    cost = 1.49;
                    break;
                case "Cookie $2.00 ":
                    cost = 2.00;
                    break;
                case "Apple Sauce $1.50 ":
                    cost = 1.50;
                    break;
                case "Coke $1.40 ":
                    cost = 1.40;
                    break;
                case "Sprite $1.40 ":
                    cost = 1.40;
                    break;
            }
            total+= cost;
        }

     

        public double calculatesubtotal()
        {
           
            return total;
        }
        public double calculatetax()
        {
            return total * 0.08;
        }
        
        public double calculatetotal(string tips)
        {
            double tax = calculatetax();
            total = total + tax + double.Parse(tips);
            return total;
        }



    }
}