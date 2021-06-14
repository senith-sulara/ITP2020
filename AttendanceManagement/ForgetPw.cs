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
    public partial class ForgetPw : Form
    {
        public ForgetPw()
        {
            InitializeComponent();
        }
        //Drag form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.userPTableAdapter userAda = new DataSet1TableAdapters.userPTableAdapter();
            DataTable dt = userAda.GetDataByfoget(int.Parse(textBoxuID.Text), textBoxUName.Text);

            if (dt.Rows.Count > 0)
            {
                if(textBoxnew.Text == textBoxconf.Text)
                {
                    userAda.UpdateQueryPass(textBoxconf.Text.ToString(), int.Parse(textBoxuID.Text));
                    MessageBox.Show("Successfully Updated");
                    Close();
                }
                else
                {
                    MessageBox.Show("Password is not match");
                }
                
            }
            else
            {
                MessageBox.Show("user credentials incorrect");
            }
        }

        private void textBoxconf_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBoxnew.PasswordChar == '*')
            {
                button2.BringToFront();
                textBoxnew.PasswordChar = '\0';
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBoxnew.PasswordChar == '\0')
            {
                button3.BringToFront();
                textBoxnew.PasswordChar = '*';
            }
        }

        private void button5con_Click(object sender, EventArgs e)
        {
            if (textBoxconf.PasswordChar == '*')
            {
                button4con.BringToFront();
                textBoxconf.PasswordChar = '\0';
            }
        }

        private void button4con_Click(object sender, EventArgs e)
        {
            if (textBoxconf.PasswordChar == '\0')
            {
                button5con.BringToFront();
                textBoxconf.PasswordChar = '*';
            }
        }
    }
}
