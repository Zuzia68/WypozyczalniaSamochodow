using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Wypozyczalnia_Samochodow
{
    
    public partial class UsunSamochody : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public UsunSamochody()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
            List<string>[] list;
            list = dbConnect.SelectWszystkie();
            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();//Wyświetlenie listy wszystkich samochodów
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
                WyswietlDG1.Rows[number].Cells[3].Value = list[3][i];
                WyswietlDG1.Rows[number].Cells[4].Value = list[4][i];
                WyswietlDG1.Rows[number].Cells[5].Value = list[5][i];
            }
        }

        private void PokazWszystkie_Click(object sender, EventArgs e)
        {
            //Wyswietlenie wszystkich samochodow
            List<string>[] list;
            list = dbConnect.SelectWszystkie();

            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
                WyswietlDG1.Rows[number].Cells[3].Value = list[3][i];
                WyswietlDG1.Rows[number].Cells[4].Value = list[4][i];
                WyswietlDG1.Rows[number].Cells[5].Value = list[5][i];
            }
        }

        public void UsunSamochod_Click(object sender, EventArgs e)
        {
           
            int idUsuwane;
            bool successfullyParsed = int.TryParse(txtWejscie.Text, out idUsuwane);
            if (successfullyParsed)
            {
                dbConnect.UsuwanieSamochodow(idUsuwane);//Przekazuje zmienna idUsuwane do metody usuwającej rekord o danym id z bazy danych
                MessageBox.Show("Usuwanie samochodu.");
            }
            else
            {
                MessageBox.Show("Podana wartość nie jest liczbą!");
            }
            List<string>[] list; //Ponowne wypisanie listy samochodów tym razem po usunięciu danego rekordu
            list = dbConnect.SelectWszystkie();
            WyswietlDG1.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlDG1.Rows.Add();
                WyswietlDG1.Rows[number].Cells[0].Value = list[0][i];
                WyswietlDG1.Rows[number].Cells[1].Value = list[1][i];
                WyswietlDG1.Rows[number].Cells[2].Value = list[2][i];
                WyswietlDG1.Rows[number].Cells[3].Value = list[3][i];
                WyswietlDG1.Rows[number].Cells[4].Value = list[4][i];
                WyswietlDG1.Rows[number].Cells[5].Value = list[5][i];
            }
        }

        private void UsunSamochody_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Zamknięcie aplikacji po zamknieciu formularza
        }

        private void PowrotDoMenu_Click(object sender, EventArgs e)//powrtot do menu
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();//
            m1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }
    }
}
