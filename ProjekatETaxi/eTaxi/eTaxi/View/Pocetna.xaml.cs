using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using eTaxi.Model;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace eTaxi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static MainPage Glavna;
        public static Sistem sistem = new Sistem();

        public MainPage()
        {
            this.InitializeComponent();
            Glavna = this;
        }

        private void hyper_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Registracija));
        }

        private void dugmePrijaviSe_Click(object sender, RoutedEventArgs e)
        {
            string pgreske = "";
   
            if (!validirajEMail(textBoxEMail.Text, ref pgreske))
            {
                Greska.Text = pgreske;
            }
            else if (!validirajPassword(passwordBox.Password.ToString(), ref pgreske))
            {
                Greska.Text = pgreske;
            }
            else
            {
                Greska.Text = "";
            }
        }

        public bool validirajEMail(string tekst, ref string pgreske)
        {
            bool imaLudogA = false;
            pgreske = "";

            if (tekst.Length == 0)
            {
                pgreske = "Unesite e-mail!";
                return false;
            }

            foreach(char c in tekst)
            {
                if(c == '@')
                {
                    imaLudogA = true;
                }
            }

            if(tekst.Length < 8 || !imaLudogA)
            {
                pgreske = "Neispravan unos e-maila!";
                return false;
            }

            return true;
        }

        public bool validirajPassword(string tekst, ref string pgreske2)
        {
            pgreske2 = "";

            if(tekst.Length == 0)
            {
                pgreske2 = "Unesite password!";
                return false;
            }

            if(tekst.Length < 8)
            {
                pgreske2 = "Neispravan unos passworda!";
                return false;
            }

            return true;
        }

    }
}
