using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DataProvider;
namespace ResidentsApplication
{
    public partial class ResultPage2 : System.Web.UI.Page
    {
        class ResultItem
        {
            public string Name { get; set; }
            public int Year { get; set; }
            public int PaymentSum { get; set; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var resList = new List<ResultItem>();
            var dict = new Dictionary<string, int>();
            foreach (var payment in Payments)
            {
                if (payment.PaymentDate.Year == DateTime.Today.Year)
                {
                    string h = Residents[payment.Id].LastName;
                    if (!dict.ContainsKey(h))
                        dict.Add(h, 0);
                    dict[h] += payment.PaymentSum;
                }
            }
            foreach (var payment in dict)
            {
                resList.Add(new ResultItem() { Name = payment.Key, Year = DateTime.Today.Year, PaymentSum = payment.Value });
            }

            resList.Sort(delegate (ResultItem x, ResultItem y)
            {
                if (x.PaymentSum == y.PaymentSum) return 0;
                else if (x.PaymentSum > y.PaymentSum) return -1;
                else return 1;
            });
            var resultList = new List<ResultItem>();

            if (resList.Count != 0)
            {
                resultList.Add(resList[0]);
                for (var i = 1; i < resList.Count; i++)
                {
                    if (resList[i] == resList[i - 1])
                        resultList.Add(resList[i]);
                }
                GridViewRes2.DataSource = resultList;
                GridViewRes2.DataBind();
            }
            else
                Response.Write(@"<script>alert('No available data')</script>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }
    }
}





/*
    foreach (var payment in Payments)
    {
    if (payment.PaymentDate.Year == DateTime.Today.Year)
    {
        if (payment.Id == idChecker)
        {

           residentAmountPaid += Convert.ToInt32(payment.PaymentSum);

        }
        else
        {
            if (residentAmountPaid > largestAmountPaid)
            {
                largestAmountPaid = residentAmountPaid;
                if(payment.Id!=1)
                name = Residents[payment.Id-1].LastName;
                else
                    name = Residents[payment.Id].LastName;
            }
            idChecker = payment.Id;
            residentAmountPaid = 0;
            residentAmountPaid += Convert.ToInt32(payment.PaymentSum);

        }
    }
    }*/

