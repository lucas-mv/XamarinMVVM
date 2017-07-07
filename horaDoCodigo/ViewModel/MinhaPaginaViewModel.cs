using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Xamarin.Forms;

namespace horaDoCodigo.ViewModel
{
    public class MinhaPaginaViewModel : ViewModelBase
    {
        #region Propriedades

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set 
            { 
                Set(() => Nome, ref _nome, value); 
            }
        }

        private bool _botaoHabilitado;
        public bool BotaoHabilitado
        {
            get { return _botaoHabilitado; }
            set 
            { 
                Set(() => BotaoHabilitado, ref _botaoHabilitado, value); 
                MostrarAlertCommand.RaiseCanExecuteChanged();
            }
        }

        #endregion

        #region Commands

        private RelayCommand _validarTextoModificadoCommand;
		public RelayCommand ValidarTextoModificadoCommand
		{
			get
			{
				return _validarTextoModificadoCommand ?? (_validarTextoModificadoCommand = new RelayCommand(ValidarTextoModificado));
			}
		}

        private RelayCommand _mostrarAlertCommand;
        public RelayCommand MostrarAlertCommand
        {
            get
            {
                return _mostrarAlertCommand ?? (_mostrarAlertCommand = new RelayCommand(MostrarAlert,
                                                                                        () => { return BotaoHabilitado; }));
            }
        }

        #endregion

        public MinhaPaginaViewModel()
        {
        }

        #region Metodos privados

        private void ValidarTextoModificado()
        {
            BotaoHabilitado = !string.IsNullOrEmpty(Nome);
        }

        private void MostrarAlert()
        {
            var mensagem = "Seu nome é " + Nome;
            MessagingCenter.Send(mensagem, Constants.MOSTRAR_ALERT_MESSAGE);
        }

        #endregion
    }
}
