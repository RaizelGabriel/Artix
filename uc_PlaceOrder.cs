using DGVPrinterHelper;
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
    public partial class uc_PlaceOrder : UserControl
    {
        Function fn = new Function();
        String query;
        public uc_PlaceOrder()
        {
            InitializeComponent();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "Select name from Items where category = '" + category + "'";
            showItemsList(query);
  
           
        }
        private void showItemsList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "Select name from Items where category = '" + category + "' and name like'"+txtSearch.Text+"%'";
            showItemsList(query);
        }

        private void txtQuantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtQuantityUpDown.Value.ToString());
            Int64 price = Int64.Parse(txtPrice.Text);
            txtTotal.Text = (quan * price).ToString();
        }


        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
            }
            catch { }
            total -=  amount;
            labelTotalAmount.Text = "Php" + total;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            this.Refresh(); 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title= "Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Amount: " + labelTotalAmount.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

            total = 0;
            dataGridView1.Rows.Clear();
            labelTotalAmount.Text = "Php " +total;  
        }

        protected int n, total = 0;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantityUpDown.ResetText();
            txtTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;
            query = "select price from Items where name = '" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch
            {

            }
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text != "0" && txtTotal.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantityUpDown.Value;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total = total + int.Parse(txtTotal.Text);
                labelTotalAmount.Text = "Php " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
