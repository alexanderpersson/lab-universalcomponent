using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace UniversalComponent.ViewModels
{
    public class ItemVM : ViewModelBase
    {
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        private string _details;
        public string Details
        {
            get
            {
                return _details;
            }
            set
            {
                _details = value;
                OnPropertyChanged();
            }
        }

        private string _imageSource;
        public string ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        private ICommand _buttonCommand;
        public ICommand ButtonCommand
        {
            get { return _buttonCommand ?? (_buttonCommand = new RelayCommand(ButtonAction, () => true)); }
        }

        public ItemVm()
        {
            Title = "Cool sheep";
            Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec ut malesuada lacus. Nulla at fringilla tortor, in dictum mi. Nulla fermentum lorem eu metus tempor, vel vulputate orci congue. Sed dapibus ante in diam feugiat, sed vulputate eros pulvinar. Aliquam ultrices fringilla fermentum. Cras consequat suscipit accumsan. Aliquam non leo vestibulum, tempus urna eu, aliquet quam. Cras sit amet rutrum augue, a rhoncus purus. Pellentesque tempor laoreet erat, eu pretium mauris facilisis eu. Suspendisse fermentum feugiat magna, id pulvinar justo sollicitudin id. Maecenas sit amet vulputate nibh. In hac habitasse platea dictumst. Nullam in pulvinar ligula. Donec pellentesque tempus felis.";
            ImageSource = "Assets/sheep.JPG";
        }

        private async void ButtonAction()
        {
            var msg = new MessageDialog("DoTheStuff!");
            await msg.ShowAsync();
        }
    }
}
