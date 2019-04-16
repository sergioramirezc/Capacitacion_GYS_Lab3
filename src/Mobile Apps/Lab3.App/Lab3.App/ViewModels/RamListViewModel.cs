using Lab3.App.Extensions;
using Lab3.App.Services.RamService;
using Lab3.Service.Computer.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.App.ViewModels
{
    public class RamListViewModel : Base.ViewModelBase
    {
        #region Fields

        private readonly IRamService _ramService;

        private int _minCapacity = 8;

        private ObservableCollection<RAM> _ramList;

        private RAM _selectedRam;

        #endregion Fields

        #region Constructors

        public RamListViewModel(IRamService ramService)
        {
            _ramService = ramService;
        }

        #endregion Constructors

        #region Properties

        public IEnumerable<RAM> BackRamList { get; private set; }

        public int MinCapacity
        {
            get { return _minCapacity; }
            set
            {
                _minCapacity = value;
                RaisePropertyChanged(() => MinCapacity);
                RamFilterByCapacity();
            }
        }

        public ObservableCollection<RAM> RamList
        {
            get { return _ramList; }
            set
            {
                _ramList = value;
                RaisePropertyChanged(() => RamList);
            }
        }

        public RAM SelectedRam
        {
            get { return _selectedRam; }
            set
            {
                _selectedRam = value;
                if (_selectedRam != null)
                {
                    SelectRam(SelectedRam);
                }
                RaisePropertyChanged(() => SelectedRam);
            }
        }

        #endregion Properties

        #region Methods

        public override async Task InitializeAsync(object navigationData)
        {
            try
            {
                IsBusy = true;
                await base.InitializeAsync(navigationData);
                BackRamList = await _ramService.GetRAMs();
                RamFilterByCapacity();
                IsLoaded = true;
            }
            catch
            {
                //Do nothing
            }
            finally
            {
                IsBusy = false;
            }
        }

        private void RamFilterByCapacity()
        {
            RamList = BackRamList?.Where(s => s.Capacity >= MinCapacity).ToObservableCollection();
        }

        private async Task SelectRam(RAM selectedRam)
        {
            await NavigationService.NavigateToAsync<RamDetailViewModel>(selectedRam);
            SelectedRam = null;
        }

        #endregion Methods
    }
}