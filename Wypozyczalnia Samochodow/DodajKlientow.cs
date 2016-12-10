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
    public partial class DodajKlientow : Form
    {
        private BazaDanychPolaczenie dbConnect;
        public string imie, nazwisko, telefon;
        public DodajKlientow()
        {
            InitializeComponent();
            dbConnect = new BazaDanychPolaczenie();
            //Wyświetlenie listy wszystkich klientów wypożyczalni
            List<string>[] list;
            list = dbConnect.SelectALLKlienci();
            WyswietlKlientowDataG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlKlientowDataG.Rows.Add();
                WyswietlKlientowDataG.Rows[number].Cells[0].Value = list[0][i];
                WyswietlKlientowDataG.Rows[number].Cells[1].Value = list[1][i];
                WyswietlKlientowDataG.Rows[number].Cells[2].Value = list[2][i];
                WyswietlKlientowDataG.Rows[number].Cells[3].Value = list[3][i];
            }
        }

        private void dodajklienta_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtImie.Text) || String.IsNullOrEmpty(txtNazwisko.Text) || String.IsNullOrEmpty(txtNumerTelefonu.Text))//Jeśli nic nie wpisano to wyświetl kompunikat
                {
                    MessageBox.Show("Podano niepoprawne dane!");
                }
            else
            {
                imie = txtImie.Text;
                nazwisko = txtNazwisko.Text;
                telefon = txtNumerTelefonu.Text;
                dbConnect.DodawanieKlientow(imie, nazwisko, telefon);//Przekazuje zmienne do metody dodającej rekord do bazy danych
                MessageBox.Show("Dodano nowego klienta!");
            }
            //Ponowne wyświetlenie listy klientów, po dodaniu nowego klienta
            List<string>[] list;
            list = dbConnect.SelectALLKlienci();
            WyswietlKlientowDataG.Rows.Clear();
            for (int i = 0; i < list[0].Count; i++)
            {
                int number = WyswietlKlientowDataG.Rows.Add();
                WyswietlKlientowDataG.Rows[number].Cells[0].Value = list[0][i];
                WyswietlKlientowDataG.Rows[number].Cells[1].Value = list[1][i];
                WyswietlKlientowDataG.Rows[number].Cells[2].Value = list[2][i];
                WyswietlKlientowDataG.Rows[number].Cells[3].Value = list[3][i];
            }
        }

        private void PowrotDoMenu_Click(object sender, EventArgs e)//Przycisk powrót do menu
        {
            MenuGlowne m1 = new MenuGlowne();
            this.Hide();//
            m1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void ZarzadzajKlientami_Click(object sender, EventArgs e)//Przejscie do modyfikacji danych klienta
        {
            ModyfikacjaKlientow md = new ModyfikacjaKlientow();
            this.Hide();//
            md.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void WypozyczAuto_Click(object sender, EventArgs e)//Przejscie do wypożyczeń samochodów
        {
            WypozyczanieSamochodow wyp = new WypozyczanieSamochodow();
            this.Hide();//
            wyp.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void DodajKlientow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//Po zamknięciu formularza zamykamy aplikacje
        }
      }
    }

