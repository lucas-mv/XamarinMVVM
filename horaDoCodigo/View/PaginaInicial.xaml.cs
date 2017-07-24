using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using horaDoCodigo.Services;
using horaDoCodigo.ViewModel;
using Xamarin.Forms;

namespace horaDoCodigo.View
{
    public partial class PaginaInicial : ContentPage
    {
        private PaginaInicialViewModel _viewModel;

        public PaginaInicial()
        {
            InitializeComponent();
            _viewModel = App.Locator.PaginaInicialViewModel;
            BindingContext = _viewModel;
            RegistrarMessagingCenter();
        }

		private void RegistrarMessagingCenter()
		{
			MessagingCenter.Subscribe<string>(this, Constants.PAGINA_INICIAL_NAVEGAR_PARA, async (mensagem) =>
			{
                var minhaMasterDetail = new MinhaMasterDetailPage();
                await NavegarPara(minhaMasterDetail);
			});
		}

        private async Task NavegarPara(Page pagina)
        {
            await NavegacaoService.NavigatePage(pagina);
        }
    }
}
