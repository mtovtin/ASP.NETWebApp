using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DataProvider;
namespace ResidentsApplication
{
    class PaymentsInfo
    {
        public string Resident { get; set; }
        public string Type { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ReadData())
                {
                    GridViewResidents.DataSource = Residents.Values;
                    var paymentsInfo = new List<PaymentsInfo>();
                    var years = new SortedSet<int>();
                    var addresses = new SortedSet<string>();
                    foreach (var payment in Payments)
                    {
                        paymentsInfo.Add(new PaymentsInfo
                        {
                            Resident = Residents[payment.Id].LastName,
                            Type = payment.PaymentType,
                            Amount=payment.PaymentSum,
                            Date = payment.PaymentDate
                        });
                        years.Add(payment.PaymentDate.Year);
                        addresses.Add(Residents[payment.Id].Address);
                    }
                    GridViewPayments.DataSource = paymentsInfo;
                    GridViewResidents.DataBind();
                    GridViewPayments.DataBind();
                    DropDownListYear.Items.Clear();
                    DropDownListAddress.Items.Clear();
                    foreach (var year in years)
                    {
                        DropDownListYear.Items.Add(year.ToString());
                    }
                    foreach(var address in addresses)
                    {
                        DropDownListAddress.Items.Add(address); 
                    }
                }
            }
        }
            protected void ButtonTask1_Click(object sender, EventArgs e)
            {
            Session["year"] = DropDownListYear.SelectedValue;
            Session["address"] = DropDownListAddress.SelectedValue;
            Response.Redirect("ResultPage1.aspx");
            }
      

        protected void ButtonTask2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("ResultPage2.aspx");
        }
    }
    }









































