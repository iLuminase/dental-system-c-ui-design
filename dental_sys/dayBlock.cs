using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class dayBlock: UserControl
    {

        public dayBlock()
        {
            InitializeComponent();
        }
        public void days(int num)
        {
            lblDay.Text = num+"";
        }

        private void dayBlock_Click(object sender, EventArgs e)
        {
            calendarDetail detail = new calendarDetail();
            detail.Show();
        }
    }
}
