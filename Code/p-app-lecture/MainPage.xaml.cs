using Microsoft.Maui.Controls;
using p_app_lecture.Class;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using VersOne.Epub;

namespace p_app_lecture
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Book> Books { get; } = new ObservableCollection<Book>();

        public MainPage()
        {
            InitializeComponent();
            LoadBooksFromFolder("p-app-lecture\\Resources\\Books-Epub");
            BindingContext = this;
        }

        private void LoadBooksFromFolder(string folderPath)
        {
            string[] epubFiles = Directory.GetFiles(folderPath, "*.epub");

            foreach (string epubFilePath in epubFiles)
            {
                LoadBooksFromEpubFile(epubFilePath);
            }
        }

        private void LoadBooksFromEpubFile(string epubFilePath)
        {
            EpubBook epubBook = EpubReader.ReadBook(epubFilePath);

            Book book = new Book
            {
                Title = epubBook.Title,
                Author = epubBook.Author,
                CoverImagePath = Path.Combine(Path.GetDirectoryName(epubFilePath), "cover.jpg")
            };

            Books.Add(book);
        }
    }


}
