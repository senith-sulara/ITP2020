using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendanceManagement
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //Drag form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;//Form minimized
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //form maximizes
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();//exit from application
        }

        //HR form
        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        //Attendance Forms
        private void attendbtn_Click(object sender, EventArgs e)
        {
            this.Hide();//hide the home page
            MainForm frm = new MainForm();//open Attendance management form
            frm.Show();
        }

        //cilckable links
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://lk.linkedin.com/");//linkedin
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/?hl=en");//instagram
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/?lang=en");//twitter
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");//facebook
        }

        //income & expensive
        private void incomebtn_Click(object sender, EventArgs e)
        {

        }

        //Mall management
        private void mallbtn_Click(object sender, EventArgs e)
        {

        }

        //Asset
        private void assetbtn_Click(object sender, EventArgs e)
        {

        }

        //Infrastucure
        private void infrasbtn_Click(object sender, EventArgs e)
        {

        }

        //Stock
        private void stockbtn_Click(object sender, EventArgs e)
        {

        }

        //System Admin
        private void adminbtn_Click(object sender, EventArgs e)
        {

        }
    }
    
}
