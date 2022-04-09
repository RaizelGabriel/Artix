using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Artix
{
    public partial class uc_UpdateItems : UserControl
    {
        Function fn = new Function();
        String query;
        public uc_UpdateItems()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            query = "select * from Items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void txtSearchItemName_TextChanged_1(object sender, EventArgs e)
        {
            query = "select * from Items where name like '" + txtSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        int iid;

        private void uc_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            query = "update Items set name= '" + txtName.Text + "', category= '" + txtCategory.Text + "',price= '" + txtPrice.Text + "' where id= '" + iid + "'";
            fn.setData(query);
            loadData();

            txtCategory.Clear();
            txtName.Clear();
            txtPrice.Clear();

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            iid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();
        }
    }
}
