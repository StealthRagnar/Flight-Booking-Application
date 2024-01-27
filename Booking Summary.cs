using System;
using System.Windows.Forms;

namespace Flight_Booking_Application
{
    public partial class Booking_Summary : Form
    {
        public Booking_Summary()
        {
            InitializeComponent();
        }



        private void lblDone_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Booking_Summary_Load(object sender, EventArgs e)
        {
            lblName.Text = FlightBook.FirstName + FlightBook.LastName;
            lblDate.Text = FlightBook.StartTrip;
            lblCityDes.Text = FlightBook.To;
            lblCityDep.Text = FlightBook.From;
            lblID.Text = FlightBook.DocNum;
            lblPayment.Text = FlightBook.paymentmode;
            lblWeight.Text = FlightBook.BagWeight.ToString();
            
            if (FlightBook.Passport)
            {
                labelID.Text = " passport ID: ";
                lblDoc.Text = "Passport";
            }
            else
            {
                labelID.Text = " Proof ID: ";
                lblDoc.Text = " Other IDs ";
            }
        }
    }




}
