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
    public partial class Frm_Customer : Form
    {
        public Frm_Customer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=ERDEM\SQLEXPRESS;Initial Catalog=DBSellVT;Integrated Security=True");
        void List()
        {
            SqlCommand cmd = new SqlCommand("Select * from CUSTOMER", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Table_Customer.DataSource = dt;
        }
        private void Frn_Customer_Load(object sender, EventArgs e)
        {
            List();

            connection.Open();
            SqlCommand cmd = new SqlCommand("Select * from CITY", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Customer_City.Items.Add(dr["CityName"]);
            }
            connection.Close();
        }

        private void Table_Customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Customer_ID.Text = Table_Customer.Rows[e.RowIndex].Cells[0].Value.ToString();
            Customer_Name.Text = Table_Customer.Rows[e.RowIndex].Cells[1].Value.ToString();
            Customer_Surname.Text = Table_Customer.Rows[e.RowIndex].Cells[2].Value.ToString();
            Customer_City.Text = Table_Customer.Rows[e.RowIndex].Cells[3].Value.ToString();
            Customer_Balance.Text = Table_Customer.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Btn_CategoryList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void Btn_CategorySave_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into CUSTOMER (CUSTOMERNAME,CUSTOMERSURNAME,CUSTOMERCITY,CUSTOMERBALANCE) values (@p1,@p2,@p3,@p4)",connection);
            cmd.Parameters.AddWithValue("@p1", Customer_Name);
            cmd.Parameters.AddWithValue("@p2", Customer_Surname);
            cmd.Parameters.AddWithValue("@p3", Customer_City);
            cmd.Parameters.AddWithValue("@p4", Customer_Balance);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Saved");
            List();
        }

        private void Btn_CategoryClear_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from CUSTOMER where CUSTOMERID=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", Customer_ID);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Deleted");
            List();
        }

        private void Btn_CategoryUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE CUSTOMER set CUSTOMERNAME=@p1,CUSTOMERSURNAME=@p2,CUSTOMERCITY=@p3,CUSTOMERBALANCE=@p4 where CUSTOMERID=@p5");
            cmd.Parameters.AddWithValue("@p1", Customer_Name);
            cmd.Parameters.AddWithValue("@p2", Customer_Surname);
            cmd.Parameters.AddWithValue("@p3", Customer_City);
            cmd.Parameters.AddWithValue("@p4", Customer_Balance);
            cmd.Parameters.AddWithValue("@p5", Customer_ID);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Updated");
            List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Customer where CUSTOMERID=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", Customer_ID);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Table_Customer.DataSource = dt;
        }
    }
}
