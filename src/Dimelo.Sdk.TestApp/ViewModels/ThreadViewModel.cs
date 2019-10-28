using Dimelo.Sdk.TestApp.Helpers;
using Dimelo.Sdk.TestApp.Models;
using Dimelo.Sdk.TestApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk.TestApp.ViewModels
{
    public class ThreadViewModel : BaseViewModel
    {
        public MainPage MainPage { get; set; }

        #region property CurrentThread
        private Thread _currentThread;
        public Thread CurrentThread
        {
            get { return _currentThread; }
            set { SetProperty(ref _currentThread, value); }
        }
        #endregion

        #region property CurrentCategoryIndex
        private int _currentCategoryIndex;
        public int CurrentCategoryIndex
        {
            get { return _currentCategoryIndex; }
            set { SetProperty(ref _currentCategoryIndex, value); OnPropertyChanged(nameof(IsCategorySelected)); }
        }
        #endregion

        #region property IsCategorySelected
        public bool IsCategorySelected
        {
            get { return CurrentCategoryIndex > -1; }
        }
        #endregion

        #region property Categories
        private string _categories;
        public string Categories
        {
            get { return _categories; }
            set { SetProperty(ref _categories, value); }
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


        #region property IsNew
        private bool _isNew;
        public bool IsNew
        {
            get { return _isNew; }
            set { SetProperty(ref _isNew, value); }
        }
        #endregion

        public ThreadViewModel()
        {
            CurrentThread = new Thread(0);
            Users = new ObservableCollection<User>();
            IsNew = true;
        }

        public void UpdateCurrentThreadWithCategories()
        {
            if (CurrentThread.Categories != null) CurrentThread.Categories = null;
            if (!string.IsNullOrWhiteSpace(Categories.Trim()))
            {
                CurrentThread.Categories = new System.Collections.ObjectModel.ObservableCollection<string>();
                string[] categories = Categories.Trim().Split(',');
                foreach (string category in categories)
                {
                    if (!string.IsNullOrWhiteSpace(category.Trim()))
                        CurrentThread.Categories.Add(category.Trim());
                }
            }
        }

        public void UpdateCategoriesWithCurrentThread()
        {
            Categories = "";
            if (CurrentThread.Categories != null)
            {
                foreach (string c in CurrentThread.Categories)
                {
                    if (Categories != "") Categories += ", ";
                    Categories += c;
                }
            }
        }
    }
}
