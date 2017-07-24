using horaDoCodigo.View;
using horaDoCodigo.ViewModel;
using Xamarin.Forms;

namespace horaDoCodigo
{
    public partial class App : Application
    {
        public static ViewModelLocator _locator;
        public static ViewModelLocator Locator
        {
            get 
            {
                return _locator ?? (_locator = new ViewModelLocator());
            }
        }
        public App()
        {
            InitializeComponent();
            MainPage = new PaginaInicial();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
