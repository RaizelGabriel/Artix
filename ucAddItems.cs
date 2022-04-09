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
    public partial class ucAddItems : UserControl
    {
        Function fn = new Function();
        String query;
        public ucAddItems()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into Items (name,category,price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "','" + txtPrice.Text + "')";
            fn.setData(query);
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void ucAddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
