using FormsSample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsSample.Pages
{
    public partial class TopicPage : ContentPage
    {
        public TopicPage(Topic topic)
        {
            InitializeComponent();
            BindingContext = this;
            Title = topic.Title;
        }
    }
}
