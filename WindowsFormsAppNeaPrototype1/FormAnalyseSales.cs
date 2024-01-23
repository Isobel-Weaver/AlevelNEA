using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsAppNeaPrototype1

{
    public partial class FormAnalyseSales : Form    
    {
        static OleDbConnection conM;
        static OleDbCommand cmdM;
        static OleDbConnection conY;
        static OleDbCommand cmdY;
        static OleDbConnection conD;
        static OleDbCommand cmdD;
        static OleDbDataReader readerD;
        static OleDbConnection conP;
        static OleDbCommand cmdP;
        static OleDbDataReader readerP;
        static OleDbCommand cmdLY;
        static OleDbConnection conLY;

        
        public FormAnalyseSales()
        {
            InitializeComponent();

            // Quantity of items sold so far this month 
            int Quantity;
            conM = new OleDbConnection();
            conM.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdM = new OleDbCommand();
            conM.Open();
            cmdM = conM.CreateCommand();
            cmdM.CommandText = @"SELECT Count(tableOrderItems.ItemID) FROM tableOrderItems INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE Month(tableOrders.DateOrdered) = MONTH(Date()) AND YEAR(tableOrders.DateOrdered) = YEAR(Date())";
            Quantity = (int)cmdM.ExecuteScalar();
            conM.Close();
            if (Quantity == 1)
            {
                lblMonthSales.Text = ("You have sold 1 item so far this month."); // As item
                //is singular if only 1 item has sold
            }
            else
            {
                lblMonthSales.Text = ("You have sold " + Quantity + " items so far this month.");

            }

            // Quantity of items sold so far this year
            int YQuantity;
            conY = new OleDbConnection();
            conY.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdY = new OleDbCommand();
            conY.Open();
            cmdY = conY.CreateCommand();
            cmdY.CommandText = @"SELECT Count(tableOrderItems.ItemID) FROM tableOrderItems INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE YEAR(tableOrders.DateOrdered) = YEAR(Date())";
            YQuantity = (int)cmdY.ExecuteScalar();
            conY.Close();
            if (YQuantity == 1)
            {
                lblMonthSales.Text = ("You have sold 1 item so far this year."); // As item
                //is singular if only 1 item has sold
            }
            else
            {
                lblYearSales.Text = ("You have sold " + YQuantity + " items so far this year.");
            }

            // Percentage difference in the items sold this month this year and this month 
            //last year
            // Quantity of items sold this month last year
            int LYQuantity;
            conLY = new OleDbConnection();
            conLY.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdLY = new OleDbCommand();
            conLY.Open();
            cmdLY = conLY.CreateCommand();
            cmdLY.CommandText = @"SELECT Count(tableOrderItems.ItemID) FROM tableOrderItems INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID  WHERE Month(tableOrders.DateOrdered) = Month(Date()) AND Year(tableOrders.DateOrdered) = Year(Date())-1";
            LYQuantity = (int)cmdLY.ExecuteScalar();
            conLY.Close();

            // Percentage calculation
            int difference = LYQuantity - Quantity;
            if (difference < 0) //More sales this year
            {
                difference = Quantity - LYQuantity; // So that the difference is a positive
                //value
                if (LYQuantity!=0) // So that the program does not crash by trying to divide
                    //by zero
                {
                    int percentage = (difference / LYQuantity) * 100;
                    lblMonthLastYear.Text = ("Sales are " + percentage + "% compared to last year");
                }
                else // Alternative label that doesn't require dividing by the quantity from
                    //last year.
                {
                    if (difference == 1)
                    {
                        lblMonthLastYear.Text = ("Sales are up by 1 item since last year"); 
                        // As item is singular
                    }
                    else
                    {
                        lblMonthLastYear.Text = ("Sales are up by " + difference + " items since last year");
                    }
                }
            }
            else if (difference > 0) // More sales last year
            {
                if (LYQuantity != 0)
                {
                    int percentage = (difference / LYQuantity) * 100;
                    lblMonthLastYear.Text = ("Sales are " + percentage + "% compared to last year");
                }
                else
                {
                    if (difference == 1)
                    {
                        lblMonthLastYear.Text = ("Sales are down by 1 item since last year"); 
                        // As item is singular
                    }
                    else
                    {
                        lblMonthLastYear.Text = ("Sales are down by " + difference + " items since last year");
                    }
                }
                // Case for if the quantity of sales is the same in both months
            }
            else
            {
                lblMonthLastYear.Text = ("Sales are the same as this month last year");     
            }

            // Percentage profit in the last month
            decimal pricePaid = 0;
            decimal priceSold = 0;
            decimal profit = 0;
            conP = new OleDbConnection();
            conP.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdP = new OleDbCommand();
            conP.Open();
            cmdP = conP.CreateCommand();
            cmdP.CommandText = @"SELECT tableItems.PricePaid, tableItems.PriceSold FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (tableItems.PriceSold IS NOT NULL) AND (tableOrders.DateOrdered BETWEEN DateAdd('m', -1, Date()) AND (Date()))";
            readerP = cmdP.ExecuteReader();
            if (readerP.HasRows)
            {
                while (readerP.Read())
                {
                    pricePaid += Convert.ToDecimal(readerP[0]); // Calculates the total 
                    //amount paid for the items sold in the last month.
                    priceSold += Convert.ToDecimal(readerP[1]); // Calculates the total 
                    //amount made in the last month.
                }
                profit = priceSold - pricePaid; // Calculates the profit made on all of the
                //items sold in the last month. 
            }
            string strProfit = Convert.ToString(profit);
            lblMonthProfit.Text = ("You have made £" + String.Format("{0:C2}", strProfit) +" profit in the last month");

            // Percentage profit in the last year and amount sold in the last year
            decimal YearPricePaid = 0;
            decimal YearPriceSold = 0;
            conP = new OleDbConnection();
            conP.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdP = new OleDbCommand();
            conP.Open();
            cmdP = conP.CreateCommand();
            cmdP.CommandText = @"SELECT tableItems.PricePaid, tableItems.PriceSold FROM (tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (tableItems.PriceSold IS NOT NULL) AND (tableOrders.DateOrdered BETWEEN DateAdd('yyyy', -1, Date()) AND (Date()))";
            readerP = cmdP.ExecuteReader();
            if (readerP.HasRows)
            {
                while (readerP.Read())
                {
                    YearPricePaid += Convert.ToDecimal(readerP[0]); // Calculates the total
                    //amount paid for the items sold in the last year.
                    YearPriceSold += Convert.ToDecimal(readerP[1]); // Calculates the total 
                    //amount made in the last year.
                }
            }
            decimal YearProfit = YearPriceSold - YearPricePaid; // Calculates the profit 
            //made on all of the items sold in the last year.
            string strYearProfit = Convert.ToString(YearProfit);
            string strYearPriceSold = Convert.ToString(YearPriceSold);
            lblYearProfit.Text = ("You have made £" + String.Format("{0:C2}", strYearProfit) + " profit in the last year");
            lblYearQuantity.Text = ("You have sold £" + String.Format("{0:C2}", strYearPriceSold)+" in the last year");

            //Best time for sales
            List<AnalyseItem> BTFS = new List<AnalyseItem>();
            conD = new OleDbConnection();
            conD.ConnectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = NeaAccess.mdb";
            cmdD = new OleDbCommand();
            conD.Open();
            cmdD = conD.CreateCommand();
            cmdD.CommandText = @"SELECT tableItems.PriceSold, tableItems.PricePaid, tableOrders.DateOrdered FROM(tableItems INNER JOIN tableOrderItems ON tableItems.ID = tableOrderItems.ItemID) INNER JOIN tableOrders ON tableOrderItems.OrderID = tableOrders.ID WHERE (tableItems.PriceSold IS NOT NULL)";
            readerD = cmdD.ExecuteReader();
            if (readerD.HasRows)
            {
                while (readerD.Read())
                {
                    AnalyseItem item = new AnalyseItem(Convert.ToDecimal(readerD[0]), 
                        Convert.ToDecimal(readerD[1]), Convert.ToString(readerD[2]));
                    BTFS.Add(item);
                }
            }
            conD.Close();

            //Best time of the month
            string bestTimeMonth = "";
            int monthStart = 0; //Days 1-10
            int monthMiddle = 0; // Days 10-20
            int monthEnd = 0;  //Days 20+
            foreach (AnalyseItem item in BTFS)
            {
                if (item.GetDay() <= 10)
                {
                    monthStart++;
                }
                else if (item.GetDay() > 20)
                {
                    monthEnd++;
                }
                else
                {
                    monthMiddle++;
                }
            }
            if (monthStart > monthMiddle && monthStart > monthEnd)
            {
                bestTimeMonth = "start of the month";
            }
            else if (monthEnd > monthStart && monthEnd > monthMiddle)
            {
                bestTimeMonth = "end of the month";
            }
            else if (monthMiddle > monthStart && monthMiddle > monthEnd)
            {
                bestTimeMonth = "middle of the month";
            }
            else if (monthStart == monthMiddle)
            {
                bestTimeMonth = "start and the middle of the month";
            }
            else if (monthStart == monthEnd)
            {
                bestTimeMonth = "start and the end of the month";
            }
            else if (monthMiddle == monthEnd)
            {
                bestTimeMonth = "middle and end of the month";
            }
            else
            {
                bestTimeMonth = "";
            }
            int[] dayOfWeekQty = new int[7];

            // Most common month
            // Number of items sold for each month
            int[] monthQuantities = new int[12];
            foreach (AnalyseItem item in BTFS)
            {
                switch (item.GetMonth())
                {
                    case 0:
                        monthQuantities[0]++;
                        break;
                    case 1:
                        monthQuantities[1]++;
                        break;
                    case 2:
                        monthQuantities[2]++;
                        break;
                    case 3:
                        monthQuantities[3]++;
                        break;
                    case 4:
                        monthQuantities[4]++;
                        break;
                    case 5:
                        monthQuantities[5]++;
                        break;
                    case 6:
                        monthQuantities[6]++;
                        break;
                    case 7:
                        monthQuantities[7]++;
                        break;
                    case 8:
                        monthQuantities[8]++;
                        break;
                    case 9:
                        monthQuantities[9]++;
                        break;
                    case 10:
                        monthQuantities[10]++;
                        break;
                    case 11:
                        monthQuantities[11]++;
                        break;
                }
                // Find occurences of all days of the week
                string day = item.GetDayOfWeek();
                switch (day)
                {
                    case "Monday":
                        dayOfWeekQty[0]++;
                        break;
                    case "Tuesday":
                        dayOfWeekQty[1]++;
                        break;
                    case "Wednesday":
                        dayOfWeekQty[2]++;
                        break;
                    case "Thursday":
                        dayOfWeekQty[3]++;
                        break;
                    case "Friday":
                        dayOfWeekQty[4]++;
                        break;
                    case "Saturday":
                        dayOfWeekQty[5]++;
                        break;
                    case "Sunday":
                        dayOfWeekQty[6]++;
                        break;
                }
            }
            // Find the month with the largest quantity
            List<int> largestMonth = new List<int>(); // List so that if there are multiple
            //months with the same number of items sold, they can all be output.
            largestMonth.Add(monthQuantities[0]);
            int largestDay = 0;
            int monthQuantity = 0;
            for (int i = 0; i < monthQuantities.Length - 1; i++)
            {
                if (monthQuantities[i] > monthQuantity)
                {
                    largestMonth.Clear();
                    largestMonth.Add(i);
                    monthQuantity = monthQuantities[i];
                }
                else if (monthQuantities[i] == monthQuantity)
                {
                    largestMonth.Add(i);
                    monthQuantity = monthQuantities[i];
                }
            }
            // Find the day with the largest quantity
            List<int> mCommonDay = new List<int>(); // List so that if there are multiple 
            //days with the same number of items sold, they can all be output.
            mCommonDay.Add(Convert.ToInt32(dayOfWeekQty[0]));
            for (int i = 0; i < dayOfWeekQty.Length - 1; i++)
            {
                if (dayOfWeekQty[i] > largestDay)
                {
                    mCommonDay.Clear();
                    mCommonDay.Add(i);
                    largestDay = dayOfWeekQty[i];
                }
                else if (dayOfWeekQty[i] == largestDay)
                {
                    mCommonDay.Add(i);
                    largestDay = dayOfWeekQty[i];
                }
            }
            // Replace number with the equivalent month name for each of the largest months.
            List<string> strLargestMonth = new List<string>();
            string mcMonth = "";
            if (largestMonth.Count <3) // Maximum amount of values to be output on the 
                //label to determine largest months.
            {
                foreach (var item in largestMonth)
                {
                    switch (item)
                    {
                        case 1:
                            strLargestMonth.Add("January");
                            break;
                        case 2:
                            strLargestMonth.Add("February");
                            break;
                        case 3:
                            strLargestMonth.Add("March");
                            break;
                        case 4:
                            strLargestMonth.Add("April");
                            break;
                        case 5:
                            strLargestMonth.Add("May");
                            break;
                        case 6:
                            strLargestMonth.Add("June");
                            break;
                        case 7:
                            strLargestMonth.Add("July");
                            break;
                        case 8:
                            strLargestMonth.Add("August");
                            break;
                        case 9:
                            strLargestMonth.Add("September");
                            break;
                        case 10:
                            strLargestMonth.Add("October");
                            break;
                        case 11:
                            strLargestMonth.Add("November");
                            break;
                        case 12:
                            strLargestMonth.Add("December");
                            break;
                    }   
                }
                mcMonth = String.Join(" and ", strLargestMonth); // If there are 
                //multiple months, they will be separated by "and" on the label.
            }
            else
            {
                mcMonth = "no particular month"; // If there are more than 3 months with 
                //the same value then it cannot be said that there are specific largest 
                //months.
            }
            string mcDay = "";
            if (mCommonDay.Count < 3) // Limit on the number of days on the label
            {
                List<string> strMCommonDay = new List<string>();
                foreach (int Day in mCommonDay)
                {
                    switch (Day)
                    {
                        case 0:
                            strMCommonDay.Add("Monday");
                            break;
                        case 1:
                            strMCommonDay.Add("Tuesday");
                            break;
                        case 2:
                            strMCommonDay.Add("Wednesday");
                            break;
                        case 3:
                            strMCommonDay.Add("Thursday");
                            break;
                        case 4:
                            strMCommonDay.Add("Friday");
                            break;
                        case 5:
                            strMCommonDay.Add("Saturday");
                            break;
                        case 6:
                            strMCommonDay.Add("Sunday");
                            break;
                    }

                }
                mcDay = string.Join(" and ", strMCommonDay);
            }
            else
            {
                mcDay = "no particular day"; // If there are more than 3 days then it cannot
                //be said that there are specific largest days.
            }
            
         lblBestTimeSales.Text = ("The best time for sales is on " + mcDay + ", at the " + bestTimeMonth + " and in " + mcMonth + ".");
        }

        private void FormAnalyseSales_Load(object sender, EventArgs e)
        {
        }
        private void btnMonthSales_Click(object sender, EventArgs e)
        {
            string monthYear = "MONTH"; // Indicates whether the data grid view should be 
            //showing sales in the last month or year.
            FormViewSales formViewSales = new FormViewSales(monthYear);
            formViewSales.ShowDialog();
        }

        private void btnYearSales_Click(object sender, EventArgs e)
        {
            string monthYear = "YEAR";
            FormViewSales formViewSales = new FormViewSales(monthYear);
            formViewSales.ShowDialog();
        }

        private void btnYearComparison_Click(object sender, EventArgs e)
        {
            FormYearComparison formYearComparison = new FormYearComparison();
            formYearComparison.ShowDialog();
        }
        class AnalyseItem
        {
            private decimal soldPrice;
            private decimal boughtPrice;
            private string date;
            public List<AnalyseItem> analyseItem = new List<AnalyseItem>();
            public AnalyseItem(decimal SoldPrice, decimal BoughtPrice, string Date)
            {
                soldPrice = SoldPrice;
                boughtPrice = BoughtPrice;
                date = Date;
                analyseItem = new List<AnalyseItem>(); 
            }

            public int GetMonth()
            {
                int month = Convert.ToInt32(date.Substring(3,2));
                return month;
            }

            public int GetDay()
            {
                int day = Convert.ToInt32(date.Substring(0, 2));
                return day;
            }

            public string GetDayOfWeek()
            {
                DateTime Date = Convert.ToDateTime(date);
                string dayOfWeek = Convert.ToString(Date.DayOfWeek);
                return dayOfWeek;
            }
        }

        private void btnTDLY_Click(object sender, EventArgs e)
        {
            FormViewSalesTDLY formViewSalesTDLY = new FormViewSalesTDLY();
            formViewSalesTDLY.Show();
        }
    }
}
