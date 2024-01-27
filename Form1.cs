using System;
using System.Windows.Forms;

namespace Flight_Booking_Application
{
    public partial class FlightBook : Form
    {
        public static bool Passport, IdCard;
        Booking_Summary S = new Booking_Summary();
        public static string To, From, StartTrip, Endtrip, FirstName, LastName,
        DocNum, DocIssue, DocExpiry, paymentmode;

        private void Form1_Load(object sender, EventArgs e)
        {
            Numeric.Increment = 3;
            Numeric.ReadOnly = true;

            MonthCal.MaxSelectionCount = 50;
            MonthCal.ShowToday = true;
        }

        public static int BagWeight;


        public FlightBook()
        {
            InitializeComponent();
        }

        private void RdbtnIDCard_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbtnIDCard.Checked)
            {
                lblDocNum.Text = " ID Proof Number: ";
                lblDocDate.Text = " ID Proof Expiry Date: ";
                lblDateofIssue.Text = " Date of Issue of ID Proof: ";
                IdCard = true;
            }
        }

        private void ResetFields()
        {
            txtbxTo.Text = "";
            txtbxFrom.Text = "";
            txtDocNum.Text = "";
            ExpDatePick.Value = DateTime.Now;
            txtFN.Text = "";
            txtFN.Text = "";
            IssueDatePick.Value = DateTime.Now;
            RdbtnIDCard.Checked = false; RdbtnPassport.Checked = false;
            RdbtnNB.Checked = false; RdbtnUPI.Checked = false; RdbtnCard.Checked = false;
            MonthCal.SetDate(new DateTime());
            Numeric.Value = 0;
            lblDocNum.Text = "...";
            lblDocDate.Text = "...";
            lblDateofIssue.Text = "...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            To = txtbxTo.Text;
            From = txtbxFrom.Text;
            StartTrip = MonthCal.SelectionStart.ToString();
            Endtrip = MonthCal.SelectionEnd.ToString();
            FirstName = txtFN.Text;
            LastName = txtLN.Text;
            DocNum = txtDocNum.Text;
            DocExpiry = ExpDatePick.Value.ToString();
            DocIssue = IssueDatePick.Value.ToString();
            BagWeight = (int)Numeric.Value;
            if(RdbtnCard.Checked == true)
            {
                paymentmode = "NetBanking";
            }
            else if(RdbtnUPI.Checked == true)
            {
                paymentmode = "UPI";
            }
            else
            {
                paymentmode = "Debit/Credit card";
            }


            this.Hide();
            Booking_Summary S = new Booking_Summary();
            S.Show();

        }

        private void ExpDatePick_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = IssueDatePick.Value;
            ExpDatePick.MinDate = dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbtnPassport.Checked)
            {
                lblDocNum.Text = " Passport Number: ";
                lblDocDate.Text = " Passport Expiry Date: ";
                lblDateofIssue.Text = " Date of Issue of passport: ";
                Passport = true;
            }
        }
    }
}
