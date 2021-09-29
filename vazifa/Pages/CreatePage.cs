using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vazifa.Pages
{
    public partial class CreatePage : UserControl
    {
        SqlConnection connection = null;
       
        SqlCommand command = null;

        public CreatePage()
        {
            InitializeComponent();
        }

        private void CreatePage_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C# developer\vazifa\vazifa\FirstDatabase1.mdf;Integrated Security=True");
            string createQuery = "INSERT INTO Users(Name, Email, Password, Phone)" +
                $"VALUES ('{Name.Text }','{Email.Text }','{Password.Text}','{Phone.Text}'); ";
            connection.Open();
            command = new SqlCommand(createQuery, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("User muvoffaqqiyatli qo`shildi");
            ClearAll();
        }
        void ClearAll()
        {
            Name.Clear();
            Email.Clear();
            Password.Clear();
            Phone.Clear();
        }
    }
}
