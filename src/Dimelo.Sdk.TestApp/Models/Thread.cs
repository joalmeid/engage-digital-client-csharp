using Dimelo.Sdk.TestApp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk.TestApp.Models
{
    public class Thread : BaseObject
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); OnPropertyChanged(nameof(DisplayName)); }
        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); OnPropertyChanged(nameof(DisplayName)); }
        }

        #region property Categories
        private ObservableCollection<string> _categories;
        public ObservableCollection<string> Categories
        {
            get { return _categories; }
            set { SetProperty(ref _categories, value); }
        }
        #endregion

        #region property Author
        private User _author;
        public User Author
        {
            get { return _author; }
            set { SetProperty(ref _author, value); }
        }
        #endregion

        #region property Body
        private string _body;
        public string Body
        {
            get { return _body; }
            set { SetProperty(ref _body, value); }
        }
        #endregion

        #region property Created
        private DateTime _created;
        public DateTime Created
        {
            get { return _created; }
            set { SetProperty(ref _created, value); }
        }
        #endregion

        #region property Updated
        private DateTime _updated;
        public DateTime Updated
        {
            get { return _updated; }
            set { SetProperty(ref _updated, value); }
        }
        #endregion

        [JsonIgnore]
        public string DisplayName
        {
            get { return $"({Id}) {Title}"; }
        }

        public Thread(int id)
        {
            Id = id.ToString();
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public void Update(Thread thread, bool setUpdated = true)
        {
            Id = thread.Id;
            Title  = thread.Title;
            Body = thread.Body;
            if (Categories != null) Categories.Clear();
            if (thread.Categories != null)
            {
                Categories = new ObservableCollection<string>();
                foreach (string c in thread.Categories) Categories.Add(c);
            }
            Author = thread.Author;
            if (setUpdated) Updated = DateTime.Now;
        }
    }
}
