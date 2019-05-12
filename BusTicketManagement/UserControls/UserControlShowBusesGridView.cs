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
    public partial class UserControlShowBusesGridView : UserControl
    {
        string date;
        string dateforquery;

        System.Windows.Forms.Panel panelSignInForm;


        public UserControlShowBusesGridView(string date , string sdateforquery , string to1 , string from1 , System.Windows.Forms.Panel panelSignInForm)
        {
            InitializeComponent();
            this.date = date;
            this.dateforquery = sdateforquery;

            this.panelSignInForm = panelSignInForm;
            labelDateText.Text = date;
            labelToFrom.Text = to1 + " to " + from1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControlShowBusesGridView_Load(object sender, EventArgs e)
        {
            SqlConnection con = Database_Connection.OpenCon();
            
            string query = @"select  name, time , fare , seat from Bus_info where date= @dd";
            SqlCommand cmd = new SqlCommand(query , con);
            cmd.Parameters.AddWithValue("@dd" , dateforquery);

            SqlDataAdapter sqlDa = new SqlDataAdapter(cmd);

            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            dataGridViewBusAvailable.DataSource = dtbl;

            
        }

            private void dataGridViewShow_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string NameB = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[0].Value.ToString();            
            string timeB = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[1].Value.ToString();
            string fareB = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[2].Value.ToString();
            string seatAv = dataGridViewBusAvailable.Rows[e.RowIndex].Cells[3].Value.ToString();


            labelBusName.Text = "Operator: "+NameB;
            labelTime.Text = "Time: " + timeB;
            labelFare.Text = "Fare: " + fareB;
            labelSeatAv.Text = "Seat Ava: " + seatAv;

        }

        private void dataGridViewBusAvailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSeat( 2207 , panelSignInForm));
        }
    }

    


}

        
    

