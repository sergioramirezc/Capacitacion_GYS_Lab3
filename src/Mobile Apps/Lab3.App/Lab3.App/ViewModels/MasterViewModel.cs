using Lab3.App.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Lab3.App.ViewModels
{
    public class MasterViewModel : Base.ViewModelBase
    {
        public ObservableCollection<MasterDetailViewMenuItem> MenuItems = new ObservableCollection<MasterDetailViewMenuItem>(new[]
                {
                    new MasterDetailViewMenuItem { Id = 0, Title = "Page 1" },
                    new MasterDetailViewMenuItem { Id = 1, Title = "Page 2" },
                    new MasterDetailViewMenuItem { Id = 2, Title = "Page 3" },
                    new MasterDetailViewMenuItem { Id = 3, Title = "Page 4" },
                    new MasterDetailViewMenuItem { Id = 4, Title = "Page 5" },
                });
    }
}
