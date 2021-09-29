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
    public partial class HomePage : UserControl
    {
        SqlConnection connection = null;
        SqlDataAdapter dataAdapter = null;
        DataTable table = null;
        public HomePage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Load_Data();

        }
        void Load_Data()
        {
            connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\C# developer\vazifa\vazifa\FirstDatabase1.mdf;Integrated Security=True");
            string readQuery = "SELECT * FROM Users;";
            dataAdapter = new SqlDataAdapter(readQuery, connection);
            table = new DataTable();
            dataAdapter.Fill(table);

            guna2DataGridView1.DataSource = table;
        }


    }
}
