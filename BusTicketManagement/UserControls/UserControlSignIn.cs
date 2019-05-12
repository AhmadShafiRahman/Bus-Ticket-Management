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
    public partial class UserControlSignIn : UserControl
    {
        private System.Windows.Forms.Panel panelSignInForm;

        public UserControlSignIn(System.Windows.Forms.Panel panelSignInForm)
        {
            this.panelSignInForm = panelSignInForm;
            InitializeComponent();
            
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-IBAJJID;Initial Catalog=BusTicket;Integrated Security=True");

            SqlConnection con = Database_Connection.OpenCon();

            //string query = @"select email from user_info";
            string query = @"Select full_name from user_info where password=@pw and user_name=@un";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@un", TextBoxUserName.Text);
            cmd.Parameters.AddWithValue("@pw", TextBoxPassword.Text);
            cmd.ExecuteNonQuery();
            //MessageBox.Show(Convert.ToString(i));


            SqlDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
             {
             //write the data on to the screen
               
            //call the objects from their index
            //    reader[0]));

             string a = Convert.ToString(reader[0]);
                //MessageBox.Show(a);
                // TextBoxUserName.Text = a;

                panelSignInForm.Controls.Clear();
                panelSignInForm.Controls.Add(new UserControlUser(TextBoxUserName.Text, a , panelSignInForm));


            }


            





        }

    public void panelSetUp(System.Windows.Forms.Panel panelSignInForm)
        {

            this.panelSignInForm = panelSignInForm;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelSignInForm.Controls.Clear();
            panelSignInForm.Controls.Add(new UserControlSignUpForm(panelSignInForm));
        }
    }
}
