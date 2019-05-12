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
    public partial class UserControlSignUpForm : UserControl
    {

        private System.Windows.Forms.Panel panelSignInForm;
        public UserControlSignUpForm(System.Windows.Forms.Panel panelSignInForm)
        {
            this.panelSignInForm = panelSignInForm;
            InitializeComponent();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSignIn(panelSignInForm));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = Database_Connection.OpenCon();
            string em = Convert.ToString(TextBoxEmail.Text);
            string query = @"INSERT INTO user_info(full_name, email, user_name , password) VALUES(@nm , @em , @un , @pw)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@un", TextBoxUserName.Text);
            cmd.Parameters.AddWithValue("@nm", TextBoxYourName.Text);
            cmd.Parameters.AddWithValue("@pw", TextBoxPassword.Text);
            cmd.Parameters.AddWithValue("@em", em);


            cmd.ExecuteNonQuery();
            cmd.ExecuteScalar();

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
