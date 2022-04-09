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
    public partial class uc_RemoveItems : UserControl
    {
        Function fn = new Function();
        String query;
        public uc_RemoveItems()
        {
            InitializeComponent();
        }

        private void uc_RemoveItems_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE?";
            DelLabel.ForeColor = Color.Brown;
            LoadData();
        }
        public void LoadData()
        {
            query = "select * from Items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchItemName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Items where name like '" + txtSearchItemName.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Items?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from Items where id =" + id + "";
                fn.setData(query);
                LoadData();
            }
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "Click on the row to Delete the Item.";
        }

        private void uc_RemoveItems_Enter(object sender, EventArgs e)
        {
            LoadData();
        }

    }
}
