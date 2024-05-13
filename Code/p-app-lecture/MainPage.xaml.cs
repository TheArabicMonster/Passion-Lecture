using Microsoft.Maui.Controls;
using p_app_lecture.Class;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VersOne.Epub;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Data;

namespace p_app_lecture
{
    public partial class MainPage : ContentPage
    {
        string connectionString = "server=localhost;user=root;database=db_livres;port=3306;password=root;";
        public ObservableCollection<Book> Books = new ObservableCollection<Book>();
        public MainPage()
        {
            InitializeComponent();
            Books = new ObservableCollection<Book>();
            GetLivresFromDB();
            BindingContext = this;
        }

        private void GetLivresFromDB()
        {
            try
            {
                
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Définir la commande SQL pour récupérer les informations sur les livres
                    string query = "SELECT * FROM livres";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Exécuter la commande et récupérer les résultats
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            Book book = new Book();
                            Debug.WriteLine($"Nombre de livres récupérés : {Books.Count}");
                            
                            book.Id = reader.GetInt32("idLivre");
                            book.Title = reader.GetString("titre");
                            //book.EpubFile = 
                            book.Summary = reader.GetString("extrait");
                            book.YearPublished = reader.GetInt32("anneeEdition");
                            //book.CoverImage
                            Books.Add(book);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}