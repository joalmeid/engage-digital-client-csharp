using Dimelo.Sdk.TestApp.Helpers;
using Dimelo.Sdk.TestApp.Models;
using Dimelo.Sdk.TestApp.Services;
using Dimelo.Sdk.TestApp.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk.TestApp.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainPage MainPage { get; set; }

        #region property Settings
        private Settings _settings;
        public Settings Settings
        {
            get { return _settings; }
            set { SetProperty(ref _settings, value); }
        }
        #endregion

        #region property CurrentUser
        private User _currentUser;
        public User CurrentUser
        {
            get { return _currentUser; }
            set { SetProperty(ref _currentUser, value); OnPropertyChanged(nameof(IsUserSelected)); }
        }
        #endregion

        #region property IsUserSelected
        public bool IsUserSelected
        {
            get { return CurrentUser != null; }
        }
        #endregion

        private Thread _currentThread;
        public Thread CurrentThread
        {
            get { return _currentThread; }
            set { SetProperty(ref _currentThread, value); OnPropertyChanged(nameof(IsThreadSelected)); }
        }

        public bool IsThreadSelected
        {
            get { return CurrentThread != null; }
        }

        #region property NewMessage
        private Message _newMessage;
        public Message NewMessage
        {
            get { return _newMessage; }
            set { SetProperty(ref _newMessage, value); }
        }
        #endregion

        #region property MessageCategories
        private string _messageCategories;
        public string MessageCategories
        {
            get { return _messageCategories; }
            set { SetProperty(ref _messageCategories, value); }
        }
        #endregion

        public MainViewModel()
        {
            Settings = new Settings();
            CurrentUser = null;
            CurrentThread = null;
            ResetMessage();

            InitializeSettingsAsync();
        }

        private async void InitializeSettingsAsync()
        {
            try
            {
                Settings = await SettingsService.LoadAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Load settings failed {ex.Message}");
            }
        }

        public async Task SaveSettings()
        {
            try
            {
                await SettingsService.SaveAsync(Settings);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Save settings failed {ex.Message}");
            }
        }

        public async Task<bool> SendNewUser(User user)
        {
            bool result = false;
            try
            {
                MainPage.Log($"===== CREATE USER {user.DisplayName} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                MainPage.Log($"Create UserRequest");
                DimeloRequest request = new DimeloRequest();
                request.Action = Sdk.Models.CreateAction.User;

                Sdk.Models.User sdkUser = new Sdk.Models.User();
                sdkUser.Id = user.Id;
                sdkUser.Firstname = user.FirstName;
                sdkUser.Lastname = user.LastName;
                sdkUser.Screenname = user.ScreenName;
                sdkUser.Email = user.Email;
                sdkUser.CreatedAt = user.Created;
                sdkUser.UpdatedAt = user.Updated;
                request.Params = sdkUser;

                MainPage.Log("\n" + request.GetJson() + "\n");

                MainPage.Log($"Send request");
                string response = await client.SendAsync(request);

                MainPage.Log($"Response: {response}");
                result = true;
            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public async Task<bool> SendUpdateUser(User user)
        {
            bool result = false;
            try
            {
                MainPage.Log($"===== UPDATE USER {user.DisplayName} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                MainPage.Log($"Create UserRequest");
                DimeloRequest request = new DimeloRequest();
                //request.Action = Sdk.Models.CreateAction.UserUpdate;

                //Sdk.Models.User sdkUser = new Sdk.Models.User();
                //sdkUser.Id = user.Id;
                //sdkUser.Firstname = user.FirstName;
                //sdkUser.Lastname = user.LastName;
                //sdkUser.Screenname = user.ScreenName;
                //sdkUser.Email = user.Email;
                //sdkUser.CreatedAt = user.Created;
                //sdkUser.UpdatedAt = user.Updated;
                //request.Params = sdkUser;

                //MainPage.Log("\n" + request.GetJson() + "\n");

                //MainPage.Log($"Send request");
                //string response = await client.SendAsync(request);

                //MainPage.Log($"Response: {response}");
                //result = true;
            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public async Task<bool> SendDeleteUser(User user)
        {
            bool result = false;
            try
            {
                MainPage.Log($"===== DELETE USER {user.DisplayName} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                DimeloRequest request = new DimeloRequest();
                //request.Action = Sdk.Models.CreateAction.UserDelete;

                //Sdk.Models.User sdkUser = new Sdk.Models.User();
                //sdkUser.Id = user.Id;
                //request.Params = sdkUser;

                //MainPage.Log("\n" + request.GetJson() + "\n");

                //MainPage.Log($"Send request");
                //string response = await client.SendAsync(request);

                //MainPage.Log($"Response: {response}");
                //result = true;
            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public async Task<bool> SendNewThread(Thread thread)
        {
            bool result = false;
            try
            {
                MainPage.Log($"===== CREATE THREAD {thread.DisplayName} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                MainPage.Log($"Create ThreadRequest");
                DimeloRequest request = new DimeloRequest();
                request.Action = Sdk.Models.CreateAction.Thread;

                Sdk.Models.Thread sdkThread = new Sdk.Models.Thread();
                sdkThread.Id = thread.Id;
                sdkThread.Title = thread.Title;
                sdkThread.Body = thread.Body;
                sdkThread.Categories = thread.Categories.ToArray();
                if (thread.Author != null)
                {
                    sdkThread.Author = new Sdk.Models.User();
                    sdkThread.Author.Id = thread.Author.Id;
                    sdkThread.Author.Firstname = thread.Author.FirstName;
                    sdkThread.Author.Lastname = thread.Author.LastName;
                    sdkThread.Author.Screenname = thread.Author.ScreenName;
                    sdkThread.Author.Email = thread.Author.Email;
                    sdkThread.Author.CreatedAt = thread.Author.Created;
                    sdkThread.Author.UpdatedAt = thread.Author.Updated;
                }
                sdkThread.Format = Sdk.Models.Formatting.Text;
                sdkThread.CreatedAt = thread.Created;
                sdkThread.UpdatedAt = thread.Updated;
                request.Params = sdkThread;

                MainPage.Log("\n" + request.GetJson() + "\n");

                MainPage.Log($"Send request");
                string response = await client.SendAsync(request);

                MainPage.Log($"Response: {response}");
                result = true;
            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public async Task<bool> SendUpdateThread(Thread thread)
        {
            bool result = false;
            try
            {
                MainPage.Log($"===== UPDATE THREAD {thread.DisplayName} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                MainPage.Log($"Create ThreadRequest");
                DimeloRequest request = new DimeloRequest();
                //request.Action = Sdk.Models.CreateAction.Thread;

                //Sdk.Models.Thread sdkThread = new Sdk.Models.Thread();
                //sdkThread.Id = thread.Id;
                //sdkThread.Title = thread.Title;
                //sdkThread.Body = thread.Body;
                //sdkThread.Categories = thread.Categories.ToArray();
                //if (thread.Author != null)
                //{
                //    sdkThread.Author = new Sdk.Models.User();
                //    sdkThread.Author.Id = thread.Author.Id;
                //    sdkThread.Author.Firstname = thread.Author.FirstName;
                //    sdkThread.Author.Lastname = thread.Author.LastName;
                //    sdkThread.Author.Screenname = thread.Author.ScreenName;
                //    sdkThread.Author.Email = thread.Author.Email;
                //    sdkThread.Author.CreatedAt = thread.Author.Created;
                //    sdkThread.Author.UpdatedAt = thread.Author.Updated;
                //}
                //sdkThread.CreatedAt = thread.Created;
                //sdkThread.UpdatedAt = thread.Updated;
                //request.Params = sdkThread;

                //MainPage.Log("\n" + request.GetJson() + "\n");

                //MainPage.Log($"Send request");
                //string response = await client.SendAsync(request);

                //MainPage.Log($"Response: {response}");
                //result = true;
            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public async Task<bool> SendDeleteThread(Thread thread)
        {
            bool result = false;
            try
            {
                MainPage.Log($"===== DELETE THREAD {thread.DisplayName} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                MainPage.Log($"Create ThreadRequest");
                DimeloRequest request = new DimeloRequest();
                //request.Action = Sdk.Models.CreateAction.Thread;

                //Sdk.Models.Thread sdkThread = new Sdk.Models.Thread();
                //sdkThread.Id = thread.Id;
                //request.Params = sdkThread;

                //MainPage.Log("\n" + request.GetJson() + "\n");

                //MainPage.Log($"Send request");
                //string response = await client.SendAsync(request);

                //MainPage.Log($"Response: {response}");
                //result = true;
            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public async Task<bool> SendNewMessage(Message message)
        {
            bool result = false;
            UpdateMessageWithMessageCategories(message);
            try
            {
                MainPage.Log($"===== SEND MESSAGE {message.Id} =====", true);
                MainPage.Log($"Create DimeloClient");
                DimeloClient client = new DimeloClient(Settings.EndpointUrl, Settings.AccountToken);

                MainPage.Log($"Create MessageRequest");
                DimeloRequest request = new DimeloRequest();
                request.Action = Sdk.Models.CreateAction.Message;

                Sdk.Models.Message sdkMessage = new Sdk.Models.Message();
                sdkMessage.Id = message.Id;
                if (!string.IsNullOrWhiteSpace(message.ThreadId)) sdkMessage.ThreadId = message.ThreadId;
                if (!string.IsNullOrWhiteSpace(message.ReplyToId)) sdkMessage.InReplyToId = message.ReplyToId;
                sdkMessage.Categories = message.Categories.ToArray();
                if (message.Author != null)
                {
                    sdkMessage.Author = new Sdk.Models.User();
                    sdkMessage.Author.Id = message.Author.Id;
                    sdkMessage.Author.Firstname = message.Author.FirstName;
                    sdkMessage.Author.Lastname = message.Author.LastName;
                    sdkMessage.Author.Screenname = message.Author.ScreenName;
                    sdkMessage.Author.Email = message.Author.Email;
                    sdkMessage.Author.CreatedAt = message.Author.Created;
                    sdkMessage.Author.UpdatedAt = message.Author.Updated;
                }
                sdkMessage.Body = message.Body;
                sdkMessage.CreatedAt = message.Created;
                sdkMessage.UpdatedAt = message.Updated;
                request.Params = sdkMessage;

                MainPage.Log("\n" + request.GetJson() + "\n");

                MainPage.Log($"Send request");
                string response = await client.SendAsync(request);

                MainPage.Log($"Response: {response}");
                result = true;

            }
            catch (Exception ex)
            {
                MainPage.Log($"\nERROR: {ex.Message}");
                MainPage.Log(ex.ToString());
            }
            return result;
        }

        public void ResetMessage()
        {
            NewMessage = new Message(Settings.NextMessageId);
            UpdateMessageCategoriesWithMessage(NewMessage);
        }

        private void UpdateMessageWithMessageCategories(Message message)
        {
            if (message.Categories != null) message.Categories = null;
            if (!string.IsNullOrWhiteSpace(MessageCategories.Trim()))
            {
                message.Categories = new System.Collections.ObjectModel.ObservableCollection<string>();
                string[] categories = MessageCategories.Trim().Split(',');
                foreach (string category in categories)
                {
                    if (!string.IsNullOrWhiteSpace(category.Trim()))
                        message.Categories.Add(category.Trim());
                }
            }
        }

        private void UpdateMessageCategoriesWithMessage(Message message)
        {
            MessageCategories = "";
            if (message.Categories != null)
            {
                foreach (string c in message.Categories)
                {
                    if (MessageCategories != "") MessageCategories += ", ";
                    MessageCategories += c;
                }
            }
        }
    }
}
