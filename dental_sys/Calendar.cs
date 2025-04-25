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
    public partial class Calendar: Form
    {
        
        static DateTime currentDT = DateTime.Now;
        static int currentYear = currentDT.Year;
        static int currentMonth = currentDT.Month;

        public Calendar()
        {
            InitializeComponent();
        }
        // ...existing code...

        private void DisplayDays()
        {
            lblMonth.Text = "Month: " + currentMonth.ToString();
            daysContainer.Controls.Clear(); // Clear previous controls

            DateTime startOfMonth = new DateTime(currentYear, currentMonth, 1);
            int days = DateTime.DaysInMonth(currentYear, currentMonth);

            // Adjust dayOfWeek to start on Monday (0 = Monday, 6 = Sunday)
            int dayOfWeek = ((int)startOfMonth.DayOfWeek + 6) % 7;

            // Add blank days for the days before the start of the month
            for (int i = 0; i < dayOfWeek; i++)
            {
                UCBlank blank = new UCBlank();
                daysContainer.Controls.Add(blank);
            }

            // Add day blocks for each day of the month
            for (int i = 1; i <= days; i++)
            {
                DateTime currentDate = new DateTime(currentYear, currentMonth, i);
                dayBlock day = new dayBlock();
                day.days(i);

                // Highlight the current day
                if (currentDate.Date == DateTime.Now.Date)
                {
                    day.BackColor = Color.LightBlue; // Set a highlight color
                    day.Controls["lblToday"].Visible = true;
                }

                daysContainer.Controls.Add(day);
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();
            if (currentMonth == 12)
            {
                currentYear++;
                currentMonth = 1;
            }
            else currentMonth++;
            DisplayDays();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            daysContainer.Controls.Clear();
            if (currentMonth == 1)
            {
                currentYear--;
                currentMonth = 12;
            }
            else currentMonth--;
            DisplayDays();
        }
        private void Calendar_Load(object sender, EventArgs e)
        {
            DisplayDays();

        }
    }


}
