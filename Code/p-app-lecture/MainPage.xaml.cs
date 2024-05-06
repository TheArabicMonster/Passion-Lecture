using Microsoft.Maui.Controls;
using p_app_lecture.Class;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VersOne.Epub;
using System.Data.SqlClient;

namespace p_app_lecture
{
    public partial class MainPage : ContentPage
    {
        string connectionString = "server=localhost;user=root;database=db_livres;port=3306;password=root;";


        public MainPage()
        {
            InitializeComponent();
        }
    }
}