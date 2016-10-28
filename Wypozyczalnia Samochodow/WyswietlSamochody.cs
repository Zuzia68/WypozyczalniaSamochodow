using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wypozyczalnia_Samochodow
{
    public partial class WyswietlSamochody : Form
    {
        public WyswietlSamochody()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WyswietlSamochody_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Ta instrukcja jest do zamknięcia aplikacji gdy przejdziemy do drugiego formularza
        }
    }
}
