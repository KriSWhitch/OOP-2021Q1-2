using Dasync.Collections;
using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using TrueFriendsApp.View;

namespace TrueFriendsApp.ViewModel
{
    class HomePageViewModel : ViewModelBase
    {
        private MainWindow mainForm;
        public HomePageViewModel(MainWindow mainForm)
        {
            this.mainForm = mainForm;
            AdList = DB.GetAdverts();
        }

        private List<Advert> adList;
        private Advert selectedItem;

        public List<Advert> AdList
        {
            get
            {
                return adList;
            }
            set
            {
                adList = value;
                RaisePropertyChanged("AdList");
            }
        }
        public Advert SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                RaisePropertyChanged("SelectedItem");
            }
        }
        public ICommand rowDoubleClick => new DelegateCommand(RowDoubleClick);
        private void RowDoubleClick()
        {
            mainForm.LoadView(ViewType.Advert, SelectedItem);
        }
    }
}
