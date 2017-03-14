using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormsSample.Pages
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _taps;
        public int Taps
        {
            get
            {
                return _taps;
            }
            set
            {
                if (value != _taps)
                {
                    _taps = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Taps"));
                }
            }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            
        }

        private void TapsClicked(object sender, EventArgs e)
        {
            Taps++;
        }

        private async void ViewAttendeesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TopicListPage());
        }
    }
}
