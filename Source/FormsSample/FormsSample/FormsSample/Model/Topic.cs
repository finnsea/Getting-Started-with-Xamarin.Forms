using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSample.Model
{
    public class Topic
    {
        public string Title { get; set; }
        public string Presenter { get; set; }
        public DateTime Date { get; set; }

        public Topic(string title, string presenter, DateTime? date = null)
        {
            Title = title;
            Presenter = presenter;
            Date = date;
        }
    }
}
