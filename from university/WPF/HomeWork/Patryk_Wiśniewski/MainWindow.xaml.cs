using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Patryk_Wiśniewski
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnectionStringBuilder pol;
        SqlConnection con;
        SqlCommand com;
        SqlDataReader red;
        DataTable tab;
        int licznik = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            

            pol = new SqlConnectionStringBuilder();
            pol.InitialCatalog = "Ksiazki";
            pol.IntegratedSecurity = true;
            con = new SqlConnection(pol.ConnectionString);
            try
            {
                con.Open();
            }
            catch(SqlException ex1)
            {
                MessageBox.Show(ex1.ToString(), "Błąd połączenia się z bazą danych");
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.ToString(), "Błąd połączenia się z bazą danych");
            }
            com = new SqlCommand("SELECT A.nazwiskoAutora, A.imieAutora, k.tytul, k.gatunek FROM Autor A, AutorKsiazki Au, Ksiazka k WHERE A.autorID = Au.autorID and k.ksiazkaID = Au.ksiazkaID", con);

            tab = new DataTable("test");
            red = com.ExecuteReader();
            tab.Load(red);
            Tytul_ksiazki.Text = tab.Rows[0][2].ToString();
            Gatunek.Text = tab.Rows[0][3].ToString();
            Imie_autora.Text = tab.Rows[0][1].ToString();
            Nazwisko_Autora.Text = tab.Rows[0][0].ToString();
        }

        private void Wstecz_Click(object sender, RoutedEventArgs e)
        {
            if(licznik > 0)
            {
                --licznik;
                Tytul_ksiazki.Text = tab.Rows[licznik][2].ToString();
                Gatunek.Text = tab.Rows[licznik][3].ToString();
                Imie_autora.Text = tab.Rows[licznik][1].ToString();
                Nazwisko_Autora.Text = tab.Rows[licznik][0].ToString();
            }
            else if( licznik == 0)
            {
                licznik = 1;
                MessageBox.Show("Nie ma rekordu 0, -1 etc");
            }
        }

        private void Kolejny_Click(object sender, RoutedEventArgs e)
        {
            if(licznik <tab.Rows.Count - 1)
            {
               
                
                    ++licznik;
                    Tytul_ksiazki.Text = tab.Rows[licznik][2].ToString();
                    Gatunek.Text = tab.Rows[licznik][3].ToString();
                    Imie_autora.Text = tab.Rows[licznik][1].ToString();
                    Nazwisko_Autora.Text = tab.Rows[licznik][0].ToString();
                
            }
            else if( licznik == tab.Rows.Count-1)
            {
                MessageBox.Show("To już był ostatni rekord");
            }
        }
    }
}
