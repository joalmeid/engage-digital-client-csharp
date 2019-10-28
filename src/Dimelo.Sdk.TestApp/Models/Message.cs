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
    public class Message : BaseObject
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); OnPropertyChanged(nameof(DisplayName)); }
        }

        #region property ThreadId
        private string _threadId;
        public string ThreadId
        {
            get { return _threadId; }
            set { SetProperty(ref _threadId, value); }
        }
        #endregion

        #region property ReplyToId
        private string _replyToId;
        public string ReplyToId
        {
            get { return _replyToId; }
            set { SetProperty(ref _replyToId, value); }
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

        #region property Categories
        private ObservableCollection<string> _categories;
        public ObservableCollection<string> Categories
        {
            get { return _categories; }
            set { SetProperty(ref _categories, value); }
        }
        #endregion

        private string _body;
        public string Body
        {
            get { return _body; }
            set { SetProperty(ref _body, value); OnPropertyChanged(nameof(DisplayName)); }
        }

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
            get { return $"({Id}) {Body.Substring(0, 20)}..."; }
        }

        public Message(int id)
        {
            Id = id.ToString();
        }
    }
}
