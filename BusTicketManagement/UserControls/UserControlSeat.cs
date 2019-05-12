using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusTicketManagement
{
    
    public partial class UserControlSeat : UserControl
    {
        
        
        int trip_id_number = 2207;


        //
        //buttonStatus
        //
        string statusA1 = "none";
        string statusA2 = "none";
        string statusA3 = "none";
        string statusA4 = "none";
        string statusB1 = "none";
        string statusB2 = "none";
        string statusB3 = "none";
        string statusB4 = "none";
        string statusC1 = "none";
        string statusC2 = "none";
        string statusC3 = "none";
        string statusC4 = "none";
        string statusD1 = "none";
        string statusD2 = "none";
        string statusD3 = "none";
        string statusD4 = "none";
        string statusE1 = "none";
        string statusE2 = "none";
        string statusE3 = "none";
        string statusE4 = "none";
        string statusF1 = "none";
        string statusF2 = "none";
        string statusF3 = "none";
        string statusF4 = "none";

        //
        //flag status
        //
        int buttonYellowA1 = 0;
        int buttonYellowA2 = 0;
        int buttonYellowA3 = 0;
        int buttonYellowA4 = 0;
        int buttonYellowB1 = 0;
        int buttonYellowB2 = 0;
        int buttonYellowB3 = 0;
        int buttonYellowB4 = 0;
        int buttonYellowC1 = 0;
        int buttonYellowC2 = 0;
        int buttonYellowC3 = 0;
        int buttonYellowC4 = 0;
        int buttonYellowD1 = 0;
        int buttonYellowD2 = 0;
        int buttonYellowD3 = 0;
        int buttonYellowD4 = 0;
        int buttonYellowE1 = 0;
        int buttonYellowE2 = 0;
        int buttonYellowE3 = 0;
        int buttonYellowE4 = 0;
        int buttonYellowF1 = 0;
        int buttonYellowF2 = 0;
        int buttonYellowF3 = 0;
        int buttonYellowF4 = 0;


        System.Windows.Forms.Panel panelSignInForm;
        public UserControlSeat(int trip_id_number , System.Windows.Forms.Panel panelSignInForm)
        {
            InitializeComponent();
            this.trip_id_number = trip_id_number;
            this.panelSignInForm = panelSignInForm;
        }

        private void UserControlSeat_Load(object sender, EventArgs e)
        {
            buttonLoadStatusA1();
            buttonLoadStatusA2();
            buttonLoadStatusA3();
            buttonLoadStatusA4();
            buttonLoadStatusB1();
            buttonLoadStatusB2();
            



        }
       
        private void buttonA1_Click(object sender, EventArgs e)
        {

        }

        private void buttonA1_MouseClick(object sender, MouseEventArgs e)
        {



            if (statusA1 == "free" && buttonYellowA1==0)
            {
                buttonYellowA1 = 1;
                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            }
            else if(statusA1 == "free" && buttonYellowA1 == 1)
            {

                buttonYellowA1 = 0;
                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));


            }
        }

        private void buttonA2_Click(object sender, EventArgs e)
        {

        }


        private void buttonLoadStatusA1()
        {

            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA1 == "av")
            {
                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA1 == "booked")
            {

                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA1 == "sold")
            {

                buttonA1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }
        private void buttonLoadStatusA2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA2 == "av")
            {
                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA2 == "booked")
            {

                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA2 == "sold")
            {

                buttonA2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }
        private void buttonLoadStatusA3()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a3'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number   );
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA3 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA3 == "av")
            {
                buttonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA3 == "booked")
            {

                buttonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA3 == "sold")
            {

                buttonA3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }
        private void buttonLoadStatusA4()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='a4'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusA4 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusA4 == "av")
            {
                buttonA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusA4 == "booked")
            {

                buttonA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusA4 == "sold")
            {

                buttonA4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusB1()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='b1'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusB1 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusB1 == "av")
            {
                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusB1 == "booked")
            {

                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusB1 == "sold")
            {

                buttonB1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }

        private void buttonLoadStatusB2()
        {
            SqlConnection con = Database_Connection.OpenCon();
            string query = @"select status from seat_status where trip_id=@tid and seat_no='b2'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@tid", trip_id_number);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                statusB2 = Convert.ToString(reader[0]);
                // b = Int32.Parse(a);

            }
            if (statusB2 == "av")
            {
                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));

            }
            else if (statusB2 == "booked")
            {

                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(128)))), ((int)(((byte)(44)))));

            }
            else if (statusB2 == "sold")
            {

                buttonB2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));

            }

        }



    }
}
