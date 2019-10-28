using Dimelo.Sdk.TestApp.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk.TestApp.Models
{
    public class Settings : BaseObject
    {
        #region property EndpointUrl
        private string _endpointUrl;
        public string EndpointUrl
        {
            get { return _endpointUrl; }
            set { SetProperty(ref _endpointUrl, value); }
        }
        #endregion

        #region property AccountToken
        private string _accountToken;
        public string AccountToken
        {
            get { return _accountToken; }
            set { SetProperty(ref _accountToken, value); }
        }
        #endregion

        #region property Users
        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set { SetProperty(ref _users, value); }
        }
        #endregion

        #region property Threads
        private ObservableCollection<Thread> _threads;
        public ObservableCollection<Thread> Threads
        {
            get { return _threads; }
            set { SetProperty(ref _threads, value); }
        }
        #endregion

        #region property Messages
        private ObservableCollection<Message> _messages;
        public ObservableCollection<Message> Messages
        {
            get { return _messages; }
            set { SetProperty(ref _messages, value); }
        }
        #endregion

        #region property NextUserId
        private int _nextUserId;
        public int NextUserId
        {
            get { return _nextUserId; }
            set { SetProperty(ref _nextUserId, value); }
        }
        #endregion

        #region property NextThreadId
        private int _nextThreadId;
        public int NextThreadId
        {
            get { return _nextThreadId; }
            set { SetProperty(ref _nextThreadId, value); }
        }
        #endregion

        #region property NextMessageId
        private int _nextMessageId;
        public int NextMessageId
        {
            get { return _nextMessageId; }
            set { SetProperty(ref _nextMessageId, value); }
        }
        #endregion

        public Settings()
        {
            Users = new ObservableCollection<User>();
            Threads = new ObservableCollection<Thread>();
            Messages = new ObservableCollection<Message>();

            NextUserId = 1000;
            NextThreadId = 1000;
            NextMessageId = 1000;
        }
    }
}
