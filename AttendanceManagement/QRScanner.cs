using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.Barcode;
using BasselTech_CamCapture;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace AttendanceManagement
{
    public partial class QRScanner : Form
    {
        Camera cam;
        Timer t;// definde time frame
        BackgroundWorker worker;
        Bitmap CapImage;//capture pixel data

        //get Connections
        string con_string = @"Data Source=LAPTOP-AMG7EJML;Initial Catalog=AttendanceDB;Integrated Security=True";

        public QRScanner()
        {
            InitializeComponent();
            t = new Timer();
            cam = new Camera(QrReader);
            worker = new BackgroundWorker();//beign process when application doing qr scanning 

            worker.DoWork += Worker_DoWork;
            t.Tick += T_Tick;//timer intervals
            t.Interval = 1;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            CapImage = cam.GetBitmap();
            if (CapImage != null && !worker.IsBusy)
                worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BarcodeDecoder decoder = new BarcodeDecoder();
            try
            {
                string pres = "Present";

                string decoded_text = decoder.Decode(CapImage).Text;
                SqlConnection con = new SqlConnection(con_string);
                SqlCommand command = con.CreateCommand();
                SqlCommand cmd = con.CreateCommand();

                con.Open();

                command.CommandText = "UPDATE Attendance SET Status =@Status WHERE Emp_ID=@Emp_ID AND Date=@todayDate";

                command.Parameters.AddWithValue("@Status", pres);
                command.Parameters.AddWithValue("@Emp_ID", decoded_text);
                command.Parameters.AddWithValue("@todayDate", DateTime.Today);

                if (command.ExecuteNonQuery() > 0)
                    MessageBox.Show("Present" + decoded_text);

                con.Close();
            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cam.Start();
                t.Start();
                button2.Enabled = true;
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                cam.Stop();
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
            cam.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }
        //drag form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
