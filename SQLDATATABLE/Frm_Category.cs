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
    public partial class Frm_Category : Form
    {
        public Frm_Category()
        {
            InitializeComponent();
        }

        private void Frm_Category_Load(object sender, EventArgs e)
        {

        }

        //Data Source=ERDEM\SQLEXPRESS;Initial Catalog=DBSellVT;Integrated Security=True

        SqlConnection connection = new SqlConnection(@"Data Source=ERDEM\SQLEXPRESS;Initial Catalog=DBSellVT;Integrated Security=True");
        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from CATEGORY", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            Table_Category.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into CATEGORY (CATEGORYNAME) values (@p1)",connection);
            cmd.Parameters.AddWithValue("@p1", Category_Name.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Saved.");
        }

        private void Btn_CategoryClear_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Delete from CATEGORY where CATEGORYID=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", Category_ID.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Deleted.");
        }

        private void Table_Category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Category_ID.Text = Table_Category.Rows[e.RowIndex].Cells[0].Value.ToString();
            Category_Name.Text = Table_Category.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void Btn_CategoryUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update CATEGORY set CATEGORYNAME=@p1 where CATEGORYID=@p2", connection);
            cmd.Parameters.AddWithValue("@p2", Category_ID.Text);
            cmd.Parameters.AddWithValue("@p1", Category_Name.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Succesfully Updated.");
        }
    }
}
