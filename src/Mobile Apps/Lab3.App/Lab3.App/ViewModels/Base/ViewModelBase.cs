using Lab3.App.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Lab3.App.ViewModels.Base
{
    public abstract class ViewModelBase : ExtendedBindableObject
    {
        #region Fields

        public bool IsLoaded;
        protected readonly INavigationService NavigationService;

        private bool _isBusy;
        private bool _isNotConnected = false;
        private object _navigationData;

        #endregion Fields

        #region Constructors

        protected ViewModelBase()
        {
            NavigationService = ViewModelLocator.Resolve<INavigationService>();
        }

        #endregion Constructors

        #region Destructors

        ~ViewModelBase()
        {
            Connectivity.ConnectivityChanged -= Connectivity_ConnectivityChanged;
        }

        #endregion Destructors

        #region Properties

        public bool IsBusy
        {
            get
            {
                return _isBusy;
            }

            set
            {
                _isBusy = value;
                RaisePropertyChanged(() => IsBusy);
            }
        }

        public bool IsNotConnected
        {
            get { return _isNotConnected; }
            set
            {
                _isNotConnected = value;
                RaisePropertyChanged(() => IsNotConnected);
            }
        }

        #endregion Properties

        #region Methods

        public virtual async Task InitializeAsync(object navigationData)
        {
            IsNotConnected = false;
            _navigationData = navigationData;

            Connectivity.ConnectivityChanged += Connectivity_ConnectivityChanged;
            IsNotConnected = Connectivity.NetworkAccess != NetworkAccess.Internet;
        }

        private async void Connectivity_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            IsNotConnected = Connectivity.NetworkAccess != NetworkAccess.Internet;
            await TryReloadAsync();
        }

        private async Task TryReloadAsync()
        {
            try
            {
                if (!IsNotConnected && !IsLoaded)
                {
                    await InitializeAsync(_navigationData);
                }
            }
            catch (Exception)
            {
                //Do nothing
            }
        }

        #endregion Methods
    }
}