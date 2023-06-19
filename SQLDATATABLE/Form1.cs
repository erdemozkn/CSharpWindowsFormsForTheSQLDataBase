using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLDATATABLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Category frm_Category = new Frm_Category();
            frm_Category.ShowDialog();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Customers_Click(object sender, EventArgs e)
        {
            Frm_Customer customer = new Frm_Customer();
            customer.ShowDialog();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=ERDEM\SQLEXPRESS;Initial Catalog=DBSellVT;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            //Condition of prodcuts
            SqlCommand cmd = new SqlCommand("Execute TEST1",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Table_Frm1.DataSource = dt;

            //Data extraction by chart
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("Select CategoryName, Count(*) from CATEGORY inner join PRODUCTS on CategoryID = PRODUCTS.CATEGORY group by CategoryName",connection);
            SqlDataReader dr = cmd2.ExecuteReader();
            while(dr.Read())
            {
                chart1.Series["Series1"].Points.AddXY(dr[0], dr[1]);
            }
            connection.Close();
        }
    }
}
