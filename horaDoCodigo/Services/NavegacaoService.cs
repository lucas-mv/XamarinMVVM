using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace horaDoCodigo.Services
{
    public static class NavegacaoService
    {
        public static NavigationPage MakeNavigationPage(Page page)
        {
            return new NavigationPage(page);    
        }

        public static async Task NavigatePage(Page page)
        {
            if(page == null)
            {
                return;    
            }    

            var masterDetailPage = page as MasterDetailPage;
            if(masterDetailPage != null)
            {
				App.Current.MainPage = masterDetailPage;
                return;
			}

			var navigationPage = App.Current.MainPage as NavigationPage;
			if (navigationPage != null)
			{
				await navigationPage.Navigation.PushAsync(page);
			}
            else
            {
                App.Current.MainPage = MakeNavigationPage(page);
			}
        }

		public static async Task NavigateMasterDetail(Page page)
		{
			if (page == null)
			{
				return;
			}

			var masterDetail = App.Current.MainPage as MasterDetailPage;

            if (masterDetail == null || masterDetail.Detail == null)
            {
                Debug.WriteLine("MasterDetailPage or Detail null");
                return;
            }

			var navigationPage = masterDetail.Detail as NavigationPage;
			if (navigationPage == null)
			{
				masterDetail.Detail = new NavigationPage(page);
				masterDetail.IsPresented = false;
				return;
			}

            await navigationPage.Navigation.PushAsync(page);
			masterDetail.IsPresented = false;
		}
    }
}
