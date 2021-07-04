using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DataProvider;
namespace ResidentsApplication
{
    public partial class ResultPage1 : System.Web.UI.Page
    {
        class ResultItem
        {
            public string Address { get; set; }
            public int Year { get; set; }
            public int PaymentSum { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session.Keys.OfType<string>().Contains("year")&& Session.Keys.OfType<string>().Contains("address"))
            {
                int year = Convert.ToInt32(Session["year"]);
                string address = Convert.ToString(Session["address"]);
                int totalChargeForGas = 0;
                foreach (var payment in Payments)
                {
                    if (Residents[payment.Id].Address.StartsWith(address) && payment.PaymentDate.Year == year)
                    {
                        if (payment.PaymentType == "газ")
                        {
                           
                            totalChargeForGas += Convert.ToInt32(payment.PaymentSum);
                        }
                    }
                }
                if (totalChargeForGas > 0)
                {
                    var resultList = new List<ResultItem>();

                    resultList.Add(new ResultItem
                    {
                        
                        Address = address,
                        Year = year,
                        PaymentSum = totalChargeForGas
                    });
                    GridViewRes1.DataSource = resultList;
                    GridViewRes1.DataBind();
                }
                else
                    Response.Write(@"<script>alert('No available data')</script>");
            }
            else
                Response.Write(@"<script>alert('Undefined year or/and address')</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}