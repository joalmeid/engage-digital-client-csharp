using Dimelo.Sdk.TestApp.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk.TestApp.Models
{
    public class User : BaseObject
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); OnPropertyChanged(nameof(DisplayName)); }
        }

        #region property FirstName
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        #endregion

        #region property LastName
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { SetProperty(ref _lastName, value); }
        }
        #endregion

        private string _screenName;
        public string ScreenName
        {
            get { return _screenName; }
            set { SetProperty(ref _screenName, value); OnPropertyChanged(nameof(DisplayName)); }
        }

        #region property Email
        private string _email;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
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
            get { return $"({Id}) {ScreenName}"; }
        }

        public User(int id)
        {
            Id = id.ToString();
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }

        public void Update(User user, bool setUpdated = true)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            ScreenName = user.ScreenName;
            Email = user.Email;
            if (setUpdated) Updated = DateTime.Now;
        }
    }
}
