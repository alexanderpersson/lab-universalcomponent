using System;
using System.Windows.Input;
using Windows.UI.Popups;

namespace UniversalComponent.ViewModels
{
    public partial class ItemVM
    {
        private ICommand _anotherButtonCommand;
        public ICommand AnotherButtonCommand
        {
            get { return _anotherButtonCommand ?? (_anotherButtonCommand = new RelayCommand(AnotherButtonAction, () => true)); }
        }

        private async void AnotherButtonAction()
        {
            var msg = new MessageDialog("DoMoreStuff!");
            await msg.ShowAsync();
        }
    }
}