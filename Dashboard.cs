using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Artix
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        //Fields

        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.BackColor = borderColor;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }
        public Dashboard(String user)
        {
            //Dashboard
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 26, 26));
            if (user == "Guest")
            {
                btnAddItems.Hide();
                btnUpdate.Hide();
                btnRemove.Hide();
            }
            else if (user == "Admin")
            {
                btnAddItems.Show();
                btnUpdate.Show();
                btnRemove.Show();
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Time.Text = DateTime.Now.ToString();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Normal;

            ucAddItems1.Visible = false;
            uc_PlaceOrder1.Visible = false;
            uc_UpdateItems1.Visible = false;
            uc_RemoveItems1.Visible = false;
        }
        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
 
            Form1 fn = new Form1();
            this.Hide();
            fn.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            uc_UpdateItems1.Visible = true;
            uc_UpdateItems1.BringToFront();
        }
        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                labelBanner.Location = new Point(94,367);
                labelBanner.ForeColor = Color.Orange;
                num++;
            }
            else if ( num == 1)
            {
                labelBanner.Location = new Point(166, 367);
                labelBanner.ForeColor = Color.Red;
                num++;
            }
            else if (num == 2)
            {
                labelBanner.Location = new Point(268, 367);
                labelBanner.ForeColor = Color.Navy;
                num++;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            ucAddItems1.Visible = true;
            ucAddItems1.BringToFront();
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uc_PlaceOrder1.Visible = true;
            uc_PlaceOrder1.BringToFront();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            uc_RemoveItems1.Visible = true;
            uc_RemoveItems1.BringToFront();
        }
    }
}
