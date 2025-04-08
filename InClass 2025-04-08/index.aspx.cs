using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InClass_2025_04_08
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cmdOk.Click += cmdOk_Click;
        }

        protected void cmdOk_Click(object sender, EventArgs e)
        {
            DateTime startDate = cldCheckInDate.SelectedDate;
            DateTime endDate = cldCheckOutDate.SelectedDate;
            double perDayRate = 200;
            double salesTax = 0.15;

            // Ensure both dates are selected
            if (startDate == DateTime.MinValue || endDate == DateTime.MinValue)
            {
                lblResult.Text = "Please select both dates.";
                return;
            }

            // Calculate the difference in days
            TimeSpan dateDifference = endDate - startDate;
            int numberOfDays = dateDifference.Days;
            double totalCost = numberOfDays * perDayRate * (salesTax + 1);

            // Display the result
            lblResult.Text = "Your total cost for the stay is $" + totalCost;
           
        }
    }
}