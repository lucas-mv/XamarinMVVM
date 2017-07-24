using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace horaDoCodigo.ViewModel
{
    public class PaginaInicialViewModel : ViewModelBase
    {
        #region Properties

		private bool _navegarHabilitado;
		public bool NavegarHabilitado
		{
			get { return _navegarHabilitado; }
			set
			{
				Set(() => _navegarHabilitado, ref _navegarHabilitado, value);
                NavegarCommand.RaiseCanExecuteChanged();
			}
		}

        #endregion

		#region Commands

		private RelayCommand _navegarCommand;
		public RelayCommand NavegarCommand
		{
			get
			{
                return _navegarCommand ?? (_navegarCommand = new RelayCommand(Navegar));
			}
		}

        #endregion

        public PaginaInicialViewModel()
        {
        }

        private void Navegar()
        {
            MessagingCenter.Send(string.Empty, Constants.PAGINA_INICIAL_NAVEGAR_PARA);
        }
    }
}
