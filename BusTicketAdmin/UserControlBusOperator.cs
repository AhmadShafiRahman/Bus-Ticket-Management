using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusTicketManagement;
using System.Data.SqlClient;

namespace BusTicketAdmin
{
    public partial class UserControlBusOperator : UserControl
    {
        public UserControlBusOperator()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlBusOperator_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string fare = textBoxFare.Text;
            string id = TextBoxId.Text;
            string name = TextBoxOperatorName.Text;

            SqlConnection con = Database_Connection.OpenCon();
      
            string query = @"INSERT INTO operator_info(name, id, fare) VALUES(@nm , @id , @fr)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nm", name);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fare", fare);


            cmd.ExecuteNonQuery();
            cmd.ExecuteScalar();




        }
    }
}
