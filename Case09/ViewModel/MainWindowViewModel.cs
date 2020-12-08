using System.Collections.ObjectModel;

namespace Case09.ViewModel
{
    public class MainWindowViewModel
    {
        public ObservableCollection<GridDataViewModel> GridData
        {
            get; set;
        } = new ObservableCollection<GridDataViewModel>()
        {
            new GridDataViewModel() { ID = 1, Name = "Hoge" },
            new GridDataViewModel() { ID = 2, Name = "Fuga" },
        };
    }

    public class GridDataViewModel : NotificationObject
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
    }
}
