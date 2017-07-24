using System;
using System.Collections.Generic;
using horaDoCodigo.Services;
using Xamarin.Forms;

namespace horaDoCodigo.View
{
    public partial class MinhaMasterDetailPage : MasterDetailPage
    {
        public MinhaMasterDetailPage()
        {
            InitializeComponent();
            Detail = NavegacaoService.MakeNavigationPage(new MinhaPagina());
            Master = new MenuLateral();
        }
    }
}
