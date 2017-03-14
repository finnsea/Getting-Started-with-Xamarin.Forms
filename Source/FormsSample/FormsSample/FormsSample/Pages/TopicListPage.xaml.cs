﻿using FormsSample.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsSample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TopicListPage : ContentPage, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Topic> _topics;
        public ObservableCollection<Topic> Topics
        {
            get { return _topics; }
            set
            {
                if (_topics != value)
                {
                    _topics = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Topics"));
                }
            }
        }

        public TopicListPage()
        {
            InitializeComponent();
            BindingContext = this;

            Topics = new ObservableCollection<Topic>()
            {
                new Topic("Stackify Prefix", "James", new DateTime(2017, 3, 7)),
                new Topic("Twilio", "Tin", new DateTime(2017, 3, 14)),
                new Topic("Intro to Basic Xamarin.Forms", "Sean", new DateTime(2017, 3, 21)),
            };
        }

        public async void ItemTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new TopicPage((Topic)((ListView)sender).SelectedItem));
        }
    }
}
