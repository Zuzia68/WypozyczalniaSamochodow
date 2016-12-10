﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Wypozyczalnia_Samochodow
{
    public partial class MenuGlowne : Form
    {
        public MenuGlowne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Wyswietl samochody
        {
            WyswietlSamochody w1 = new WyswietlSamochody();
            this.Hide();//
            w1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void Usun_Click(object sender, EventArgs e)//Usun samochody
        {
            UsunSamochody u1 = new UsunSamochody();
            this.Hide();//
            u1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void button1_Click_1(object sender, EventArgs e)//Przycisk dodaj samochody
        {
            DodajSamochody d1 = new DodajSamochody();
            this.Hide();//
            d1.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void button3_Click(object sender, EventArgs e)//Przycisk wyswietl klientow
        {
            DodajKlientow dk = new DodajKlientow();
            this.Hide();//
            dk.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModyfikacjaKlientow mk = new ModyfikacjaKlientow();
            this.Hide();//
            mk.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void MenuGlowne_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Zamknięcie aplikacji po wyłączeniu formularza
        }

        private void button5_Click(object sender, EventArgs e)//Wyswietlenie formlarza do wypożyczeń samochodów
        {
            WypozyczanieSamochodow wyp = new WypozyczanieSamochodow();
            this.Hide();//
            wyp.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        }

        private void button4_Click(object sender, EventArgs e)//Przejscie do zarzadzania samochodami
        {
            ZarządzanieWypozyczeniami zarz = new ZarządzanieWypozyczeniami();
            this.Hide();//
            zarz.ShowDialog();//Wyswietlanie 2 formularza i ukrywanie bieżącego.
        } 
    }
}
