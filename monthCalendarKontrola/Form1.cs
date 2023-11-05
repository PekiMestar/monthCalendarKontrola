using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monthCalendarKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan ts = monthCalendar1.SelectionEnd -
            monthCalendar1.SelectionStart;

            if (ts.Days < 1)

            {

                MessageBox.Show("Korištenjem tipke SHIFT izaberite dane.");

                return;
            }

            MessageBox.Show("Rezervirali ste termin u trajanju od " + ts.Days.ToString() + " dana.", "Rezervacija");

            MessageBox.Show("Vaša rezervacija počinje " + monthCalendar1.SelectionStart.ToShortDateString() + " ,a završava " + monthCalendar1.SelectionEnd.ToShortDateString());

        }
    }
}
