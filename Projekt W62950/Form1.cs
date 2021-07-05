using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_W62950
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Utworzenie zmiennych
        /// </summary>
        decimal wartosc;
        int wartosc2;

        /// <summary>
        /// Sprawdzenie czy ciąg znaków należy do danego systemu liczbowego
        /// </summary>
        public bool czyPasuje(string wartosc)
        {
            string ciagZnakow = "";
            if (rb2.Checked == true) ciagZnakow = "01";
            else if (rb4.Checked == true) ciagZnakow = "0123456789ABCDEF";
            else if (rb3.Checked == true) ciagZnakow = "01234567";
            char znak;
            for (int i = 0; i < wartosc.Length; i++)
            {
                znak = wartosc[i];
                if (ciagZnakow.Contains(znak) == false) return false;
            }
            return true;
        }
        /// <summary>
        /// Zamienia ciąg znaków danego systemu liczbowego na system dziesiętny
        /// </summary>
        static int NaDziesietny(string liczba, int system)
        {
            int i, x;
            int p = 1;
            int wynik = 0;

            for (i = liczba.Length - 1; i >= 0; i--)
            {
                if (liczba[i] >= '0' && liczba[i] <= '9') x = liczba[i] - '0';
                else x = liczba[i] - 55;

                wynik += x * p;
                p *= system;

            }
            return wynik;
        }
        /// <summary>
        /// Zamiania wartość z systemu dziesiętnego na inny
        /// </summary>
        static string ZDziesietnego(int liczba, int system)
        {
            string wynik = "";
            string znaki = "0123456789ABCDEF";
            while (liczba > 0)
            {
                wynik = znaki[liczba % system] + wynik;
                liczba = liczba / system;
            }
            return wynik;
        }
        /// <summary>
        /// Mnożenie wartośąci
        /// </summary>
        static decimal mnozenie(decimal a, long b)
        {
            return a * b;
        }
        /// <summary>
        /// Dzielenie wartości
        /// </summary>
        static decimal dzielenie(decimal a, long b)
        {
            return a / b;
        }

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Zamiana nazw radiobuttonów, labeli i  groupbox'ów oraz zamiana rozmiaru 
        /// </summary>
        private void rbMasa_CheckedChanged(object sender, EventArgs e)
        {
            rb5.Visible = true;
            label5.Visible = true;
            textBox6.Visible = true;
            groupBox1.Text = "Masa";
            rb1.Text = "mg";
            rb2.Text = "g";
            rb3.Text = "dag";
            rb4.Text = "kg";
            rb5.Text = "t";
            label1.Text = "mg";
            label2.Text = "g";
            label3.Text = "dag";
            label4.Text = "kg";
            label5.Text = "t";
            groupBox1.Size = new Size(153, 170);
            groupBox2.Size = new Size(61, 170);
        }
        /// <summary>
        ///Zamiana nazw radiobuttonów, labeli i  groupbox'ów oraz zamiana rozmiaru 
        /// </summary>
        private void rbDługosc_CheckedChanged(object sender, EventArgs e)
        {
            rb5.Visible = true;
            label5.Visible = true;
            textBox6.Visible = true;
            groupBox1.Text = "Długość";
            rb1.Text = "mm";
            rb2.Text = "cm";
            rb3.Text = "dm";
            rb4.Text = "m";
            rb5.Text = "km";
            label1.Text = "mm";
            label2.Text = "cm";
            label3.Text = "dm";
            label4.Text = "m";
            label5.Text = "km";
            groupBox1.Size = new Size(153, 170);
            groupBox2.Size = new Size(61, 170);
        }
        /// <summary>
        /// Zamiana nazw radiobuttonów, labeli i  groupbox'ów oraz zamiana rozmiaru 
        /// </summary>
        private void rbCzas_CheckedChanged(object sender, EventArgs e)
        {
            rb5.Visible = true;
            label5.Visible = true;
            textBox6.Visible = true;
            groupBox1.Text = "Czas";
            rb1.Text = "s";
            rb2.Text = "min";
            rb3.Text = "h";
            rb4.Text = "d";
            rb5.Text = "msc";
            label1.Text = "s";
            label2.Text = "min";
            label3.Text = "h";
            label4.Text = "d";
            label5.Text = "msc";
            groupBox1.Size = new Size(153, 170);
            groupBox2.Size = new Size(61, 170);
        }
        /// <summary>
        /// Zamiana nazw radiobuttonów, labeli i  groupbox'ów oraz zamiana rozmiaru 
        /// </summary>
        private void rbPamiec_CheckedChanged(object sender, EventArgs e)
        {
            rb5.Visible = true;
            label5.Visible = true;
            textBox6.Visible = true;
            groupBox1.Text = "Pamięć";
            rb1.Text = "B";
            rb2.Text = "KB";
            rb3.Text = "MB";
            rb4.Text = "GB";
            rb5.Text = "TB";
            label1.Text = "B";
            label2.Text = "KB";
            label3.Text = "MB";
            label4.Text = "GB";
            label5.Text = "TB";
            groupBox1.Size = new Size(153, 170);
            groupBox2.Size = new Size(61, 170);
        }
        /// <summary>
        /// Zamiana nazw radiobuttonów, labeli i  groupbox'ów oraz zamiana rozmiaru 
        /// </summary>
        private void rbSL_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Text = "Systemy liczbowe";
            rb1.Text = "DEC";
            rb2.Text = "BIN";
            rb3.Text = "OCT";
            rb4.Text = "HEX";
            rb5.Visible = false;
            label1.Text = "DEC";
            label2.Text = "BIN";
            label3.Text = "OCT";
            label4.Text = "HEX";
            label5.Visible = false;
            textBox6.Visible = false;
            groupBox1.Size = new Size(153, 140);
            groupBox2.Size = new Size(61, 140);
        }
        /// <summary>
        /// Czyszczenie wartości w textbox'ach
        /// </summary>
        private void bWyczysc_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
        }
        /// <summary>
        /// Zamknięcie aplikacji
        /// </summary>
        private void bZamknij_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Główna część programu, odpowiada za przeliczanie wartości
        /// </summary>
        private void bKonwertuj_Click(object sender, EventArgs e)
        {
            if(rbSL.Checked == true && rb4.Checked == true)                                  //HEX.
            {
                if (czyPasuje(textBox1.Text) == true && textBox1.Text.Length > 0)
                {
                    textBox2.Text = Convert.ToString(NaDziesietny(textBox1.Text, 16));
                    textBox3.Text = Convert.ToString(ZDziesietnego(NaDziesietny(textBox1.Text, 16), 2));
                    textBox4.Text = Convert.ToString(ZDziesietnego(NaDziesietny(textBox1.Text, 16), 8));
                    textBox5.Text = Convert.ToString(textBox1.Text);
                }
                else MessageBox.Show("Podaj liczbę w systemie szesnastkowym!", "Komunikat");
            }
            else if (decimal.TryParse(textBox1.Text, out wartosc) == true && textBox1.Text.Length != 0)
            {
                wartosc = Convert.ToDecimal(textBox1.Text);
                if (wartosc >= 0)
                {
                    if (rbDługosc.Checked == true)                     // DŁUGOŚĆ.
                    {
                        if (rb1.Checked == true)                            // MM
                        {
                            textBox2.Text = Convert.ToString(wartosc);
                            textBox3.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 10),4));
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 100), 6));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000), 8));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000000), 12));
                        }

                        else if (rb2.Checked == true)                     // CM
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 10));
                            textBox3.Text = Convert.ToString(wartosc);
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 10), 6));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 100), 8));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 100000), 12));
                        }

                        else if (rb3.Checked == true)                   //DM
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 100));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 10));
                            textBox4.Text = Convert.ToString(wartosc);
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 10), 8));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 10000), 12));
                        }

                        else if (rb4.Checked == true)                    // M
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1000));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 100));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 10));
                            textBox5.Text = Convert.ToString(wartosc);
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000), 12));
                        }

                        else if (rb5.Checked == true)                     // KM
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1000000));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 100000));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 10000));
                            textBox5.Text = Convert.ToString(mnozenie(wartosc, 1000));
                            textBox6.Text = Convert.ToString(wartosc);
                        }
                    }
                    else if (rbMasa.Checked == true)                     // MASA
                    {
                        if (rb1.Checked == true)                            // MG
                        {
                            textBox2.Text = Convert.ToString(wartosc);
                            textBox3.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000), 4));
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 10000), 6));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000000), 8));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000000000), 12));
                        }

                        else if (rb2.Checked == true)                     // G
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1000));
                            textBox3.Text = Convert.ToString(wartosc);
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 10), 6));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000), 8));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000000), 12));
                        }

                        else if (rb3.Checked == true)                   // DAG
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 10000));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 10));
                            textBox4.Text = Convert.ToString(wartosc);
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 100), 8));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 100000), 12));
                        }

                        else if (rb4.Checked == true)                    // KG
                        {
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1000000));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 1000));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 100));
                            textBox5.Text = Convert.ToString(wartosc);
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1000), 12));
                        }

                        else if (rb5.Checked == true)                     // T
                        {                           
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1000000000));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 1000000));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 100000));
                            textBox5.Text = Convert.ToString(mnozenie(wartosc, 1000));
                            textBox6.Text = Convert.ToString(wartosc);
                        }
                    }

                    else if (rbCzas.Checked == true)                     // CZAS
                    {
                        if (rb1.Checked == true)                            // S
                        {                            
                            textBox2.Text = Convert.ToString(wartosc);
                            textBox3.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 60), 2));
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 3600), 4));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 86400), 5));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 2629743), 7));
                        }

                        else if (rb2.Checked == true)                     // MIN
                        {                           
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 60));
                            textBox3.Text = Convert.ToString(wartosc);
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 60), 2));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1140), 4));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 43829), 5));
                        }

                        else if (rb3.Checked == true)                   // H
                        {                                                      
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 3600));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 60));
                            textBox4.Text = Convert.ToString(wartosc);
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 24), 2));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 730), 3));
                        }

                        else if (rb4.Checked == true)                    // DNI
                        {                            
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 86400));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 1140));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 24));
                            textBox5.Text = Convert.ToString(wartosc);
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 30), 2));
                        }

                        else if (rb5.Checked == true)                     // MIESIAC
                        {                            
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 2629743));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 43829));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 730));
                            textBox5.Text = Convert.ToString(mnozenie(wartosc, 30));
                            textBox6.Text = Convert.ToString(wartosc);
                        }

                    }

                    else if (rbPamiec.Checked == true)                     // PAMIEC
                    {
                        if (rb1.Checked == true)                            // B
                        {                            
                            textBox2.Text = Convert.ToString(wartosc);
                            textBox3.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1024), 3));
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1048576), 6));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1073741824), 10));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1099511627776), 12));
                        }

                        else if (rb2.Checked == true)                     // KB
                        {                         
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1024));
                            textBox3.Text = Convert.ToString(wartosc);
                            textBox4.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1024), 3));
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1048576), 6));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1073741824), 10));
                        }

                        else if (rb3.Checked == true)                   // MB
                        {                           
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1048576));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 1024));
                            textBox4.Text = Convert.ToString(wartosc);
                            textBox5.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1024), 3));
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1048576), 6));
                        }

                        else if (rb4.Checked == true)                    // GB
                        {                          
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1073741824));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 1048576));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 1024));
                            textBox5.Text = Convert.ToString(wartosc);
                            textBox6.Text = Convert.ToString(decimal.Round(dzielenie(wartosc, 1024), 3));
                        }

                        else if (rb5.Checked == true)                     // TB
                        {                          
                            textBox2.Text = Convert.ToString(mnozenie(wartosc, 1099511627776));
                            textBox3.Text = Convert.ToString(mnozenie(wartosc, 1073741824));
                            textBox4.Text = Convert.ToString(mnozenie(wartosc, 1048576));
                            textBox5.Text = Convert.ToString(mnozenie(wartosc, 1024));
                            textBox6.Text = Convert.ToString(wartosc);
                        }

                    }
                    else if(rbSL.Checked == true )
                    {
                        if (int.TryParse(textBox1.Text, out wartosc2) == true)
                        {
                            wartosc2 = Convert.ToInt32(textBox1.Text);
                            if (rb1.Checked == true)                              //DEC
                            {
                                textBox2.Text = Convert.ToString(wartosc2);
                                textBox3.Text = Convert.ToString(ZDziesietnego(wartosc2, 2));
                                textBox4.Text = Convert.ToString(ZDziesietnego(wartosc2, 8));
                                textBox5.Text = Convert.ToString(ZDziesietnego(wartosc2, 16));
                            }
                            else if (rb2.Checked == true)                      //BIN 
                            {
                                if (czyPasuje(textBox1.Text) == true)
                                {
                                    textBox2.Text = Convert.ToString(NaDziesietny(textBox1.Text, 2));
                                    textBox3.Text = Convert.ToString(wartosc2);
                                    textBox4.Text = Convert.ToString(ZDziesietnego(NaDziesietny(textBox1.Text, 2), 8));
                                    textBox5.Text = Convert.ToString(ZDziesietnego(NaDziesietny(textBox1.Text, 2), 16));
                                }
                                else MessageBox.Show("Podaj wartość binarną!", "Komunikat");
                            }
                            else if (rb3.Checked == true)                            //OCT
                            {
                                if (czyPasuje(textBox1.Text) == true)
                                {
                                    textBox2.Text = Convert.ToString(NaDziesietny(textBox1.Text, 8));
                                    textBox3.Text = Convert.ToString(ZDziesietnego(NaDziesietny(textBox1.Text, 8), 2));
                                    textBox4.Text = Convert.ToString(wartosc2);
                                    textBox5.Text = Convert.ToString(ZDziesietnego(NaDziesietny(textBox1.Text, 8), 16));
                                }
                                else MessageBox.Show("Podaj wartość w systemie ósemkowym!", "Komunikat");
                            }
                        }
                        else MessageBox.Show("Podaj poprawną wartość!", "Komunikat");
                    }
                }
                else MessageBox.Show("Nie możesz podać wartości ujemnej!", "Komunikat");
            }
            else if (decimal.TryParse(textBox1.Text, out wartosc) == false) MessageBox.Show("Podaj wartość liczbową!", "Komunikat");
        }
    }
}
