using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CIS3342
{
    public partial class sandwich_backend : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Calculations calculations = new Calculations();


                lblname.Text = "Name: " + Request.Form["name"];
                lblphone.Text = "Phone: " + Request.Form["phone"];

                lblsize.Text = "Size: " + Request.Form["size"];
                lblsauces.Text = "Sauces: " + Request.Form["sauces"];
                lblVeggies.Text = "veggies: " + Request.Form["veggies"];
                lblpreference.Text = "tosted: " + Request.Form["toast"];
                lblmeat.Text = "meat: " + Request.Form["meat"];
                lblextra.Text = "Extra: " + Request.Form["extra"];
                lblsides.Text = "Slide: " + Request.Form["slide"];

                calculations.calculateSize(Request.Form["size"]);
                calculations.calaculateveggies(Request.Form["veggies"]);
                calculations.calaculateslide(Request.Form["slide"]);
                calculations.calaculatemeat(Request.Form["meat"]);
                calculations.calaculateextra(Request.Form["extra"]);
                calculations.calculatesauces(Request.Form["sauces"]);
                calculations.calculatetoast(Request.Form["toast"]);

                if (Request.Form["tip"].ToString() == "")
                {
                    lbltip.Text = 0.0.ToString();
                }
                else
                {
                    lbltip.Text = "Tip: " + Request.Form["tip"];
                }

                if (Request.Form["sauces"] == null)
                {

                }
                else
                {
                    string sauces = Request.Form["sauces"];
                    string[] sauce = sauces.Split(',');
                    lblsauces.Text = "Sauces: " + sauces;

                }


                if (Request.Form["veggies"] == null)
                {

                }
                else
                {
                    string veggies = Request.Form["veggies"];
                    string[] veggie = veggies.Split(',');

                }

                if (Request.Form["meat"] == null)
                {

                }
                else
                {
                    string meat = Request.Form["meat"];
                    string[] mea = meat.Split(',');

                }

                if (Request.Form["extra"] == null)
                {

                }
                else
                {
                    string extra = Request.Form["extra"];
                    string[] ext = extra.Split(',');

                }

                if (Request.Form["slide"] == null)
                {

                }
                else
                {
                    string sides = Request.Form["slide"];
                    string[] side = sides.Split(',');

                }






                double subtotal = calculations.calculatesubtotal();
                lblsubtotal.Text = "SubTotal: " + subtotal.ToString();

                double tax = calculations.calculatetax();
                lbltax.Text = "Tax: " + tax.ToString();

                double total = calculations.calculatetotal(Request.Form["tip"]);
                lbltotal.Text = "Total: " + total.ToString();
            }
            

        }
       



    }
}