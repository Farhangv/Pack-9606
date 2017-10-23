using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersianDatePickerDemo
{
    public partial class Form1 : Form
    {
        PersianCalendar calendar;
        int currentYear ;
        int currentMonth;

        public Form1()
        {
            InitializeComponent();
            calendar = new PersianCalendar();
            currentYear = calendar.GetYear(DateTime.Now);
            currentMonth = calendar.GetMonth(DateTime.Now);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = currentYear - 10; i <= currentYear + 10; i++)
            {
                cboYear.Items.Add(i);
            }
            cboYear.SelectedItem = currentYear;

            //Enum.GetNames()
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add((PersianMonth)i);
            }
            cboMonth.SelectedItem = (PersianMonth)currentMonth;
        }

        private void DrawDays(object sender, EventArgs e)
        {
            if (cboYear.SelectedItem != null && cboMonth.SelectedItem != null)
            {
                var selectedYear = (int)cboYear.SelectedItem;
                var selectedMonth = (PersianMonth)cboMonth.SelectedItem;
                var daysInMonth = calendar.GetDaysInMonth(selectedYear, (int)selectedMonth);
                var currentDay = calendar.GetDayOfMonth(DateTime.Now);

                flpDays.Controls.Clear();
                for (int i = 1; i <= daysInMonth; i++)
                {
                    Button btn = new Button()
                    {
                        Width = 35,
                        Height = 35,
                        Text = i.ToString()
                    };
                    if (selectedYear == currentYear && (int)selectedMonth == currentMonth && i == currentDay)
                        btn.BackColor = Color.Aqua;
                    if (calendar.GetDayOfWeek(calendar.ToDateTime(selectedYear, (int)selectedMonth, i, 0, 0, 0, 0)) == DayOfWeek.Friday)
                        btn.BackColor = Color.Red;

                    btn.Click += Btn_Click;

                    flpDays.Controls.Add(btn);
                }
            }

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            MessageBox.Show($"{cboYear.SelectedItem.ToString():0000}/{(int)cboMonth.SelectedItem:00}/{int.Parse(btn.Text):00}");
        }
    }
}
