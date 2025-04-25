using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            label_val.Text = "Bảng thông báo";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label_val.Text = "Bảng thông báo";
            guna2PictureBox_val.Image = Properties.Resources.dashboard__12_;
            container(new Dashboard());
        }

        private void container(object _form)
        {

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();

            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            label_val.Text = "Danh sách bệnh nhân";
            guna2PictureBox_val.Image = Properties.Resources.person__1_;
            container(new Patient());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            label_val.Text = "Messages";
            guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            container(new Messages());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void btn_LichHen_Click(object sender, EventArgs e)
        {
            label_val.Text = "Lịch Hẹn";
            guna2PictureBox_val.Image = Properties.Resources.chat__1_;
            container(new Calendar());
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            CreateAppointment createAppointment = new CreateAppointment();
            createAppointment.Show();
        }
    }
}
