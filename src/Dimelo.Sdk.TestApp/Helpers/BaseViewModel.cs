using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimelo.Sdk.TestApp.Helpers
{
    public class BaseViewModel : BaseObject
    {
        #region property IsInitialized
        private bool _isInitialized;
        public bool IsInitialized
        {
            get { return _isInitialized; }
            set { SetProperty(ref _isInitialized, value); }
        }
        #endregion

        public BaseViewModel()
        {
            IsInitialized = false;
        }
    }
}
