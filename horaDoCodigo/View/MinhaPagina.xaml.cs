
using System;
using System.Collections.Generic;
using horaDoCodigo.ViewModel;
using Xamarin.Forms;

namespace horaDoCodigo.View
{
    public partial class MinhaPagina : ContentPage
    {
        MinhaPaginaViewModel _viewModel;

        public MinhaPagina()
        {
            InitializeComponent();
            _viewModel = App.Locator.MinhaPagina;
            BindingContext = _viewModel;
            RegistrarMessagingCenter();
        }

        private void RegistrarMessagingCenter(){
            MessagingCenter.Subscribe<string>(this, Constants.MOSTRAR_ALERT_MESSAGE, (mensagem) => 
            {
                DisplayAlert("Alerta", mensagem, "Ok");
            });
        }
    }
}
