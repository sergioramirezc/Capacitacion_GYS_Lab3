using Lab3.Service.Computer.Data;
using System.Threading.Tasks;

namespace Lab3.App.ViewModels
{
    public class RamDetailViewModel : Base.ViewModelBase
    {
        #region Fields

        private RAM _ram;

        #endregion Fields

        #region Properties

        public RAM Ram
        {
            get { return _ram; }
            set
            {
                _ram = value;
                RaisePropertyChanged(() => Ram);
            }
        }

        #endregion Properties

        #region Methods

        public override async Task InitializeAsync(object navigationData)
        {
            await base.InitializeAsync(navigationData);
            Ram = navigationData as RAM;
        }

        #endregion Methods
    }
}