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
    public partial class MainForm : Form
    {
        public int loggedIn { get; set; }
        public String Username { get; set; }

        public MainForm()
        {
            InitializeComponent();
            loggedIn = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Attendance Button
        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Attendance());
        }
        private Form OpenForm = null;
        private void OpenChildForm(Form childForm)
        {
           
            if (OpenForm != null)
            {
                OpenForm.Close();
            }
            OpenForm = childForm;
            //End
            //Create child form operations
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //DashBoard button
        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new DashBoard());
        }
        //Back Button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Home hm = new Home();
            hm.Show();

        }
        //User Profile Label
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login newLogin = new Login();
            Username = newLogin.Username;
           // Password = newLogin.Password;
            OpenChildForm(new UserProfile(Username));

        }
        //Login
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if(loggedIn == 0)
            {
                Login newLogin = new Login();
                newLogin.ShowDialog();

                if (newLogin.loginFlag == false)
                {
                    Close();
                    
                }
                else
                {
                    Username = newLogin.Username;
                    linkLabel1.Text = Username;
                    loggedIn = 1;
                }
            }
            
        }
        //LogOut Button
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm lg = new MainForm();
            lg.Show();
            
        }
        //Report Button
        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Report());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();//exit from application
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Maximized form
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //minimized form
            WindowState = FormWindowState.Minimized;
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
        //drag form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Drag
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
