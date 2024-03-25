namespace p_app_lecture
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void MenuBurger_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("titre test alert","desc alert","ok");
        }


    }

}
