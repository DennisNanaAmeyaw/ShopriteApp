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

namespace ShopriteInventoryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //creating an instance of the MotherOfAllConnections class
        MotherOfAllConnections Connect = new MotherOfAllConnections();
        private void bunifuLabel6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categories = new Categories();
            categories.Show();

        }

        private void bunifuLabel11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect.openConn();
            string query = "SELECT COUNT(*) FROM Categories ";
            SqlCommand cmd = new SqlCommand(query, Connect.returnConn());
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            bunifuLabel11.Text = count.ToString();

            //count products
            string prodQuery = "SELECT COUNT(*) FROM Products ";
            SqlCommand prodCmd = new SqlCommand(prodQuery, Connect.returnConn());
            Int32 countProduct = Convert.ToInt32(prodCmd.ExecuteScalar());
            bunifuLabel4.Text = countProduct.ToString();

            //count users
            string uQuery = "SELECT COUNT(*) FROM Users ";
            SqlCommand uCmd = new SqlCommand(uQuery, Connect.returnConn());
            Int32 uCount = Convert.ToInt32(uCmd.ExecuteScalar());
            bunifuLabel9.Text = uCount.ToString();

        }

        private void bunifuButton7_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT THIS APP ??", "EXIT?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                MessageBox.Show("Thank You For Using This App", "Thank You", 0, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                this.Show();

            }
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var products = new ManageProducts();
            products.Show();
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            var user = new Users();
            user.Show();
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Customer = new Customers();
            Customer.Show();
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var st = new Stocks();
            st.Show();
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            var order = new Orders();
            this.Hide();
            order.Show();
        }
    }
}
