using System;
using System.Collections.ObjectModel;
using TestApp.Model;
using TestApp.View;
namespace TestApp.ViewModel
{
    class MainPageViewModel : ViewModelBase
    {
        #region EventHandlers
        public event EventHandler onItemSelect;
        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            MenuItems = new ObservableCollection<AppPage>
            {
                new AppPage(){ PageName = "About", PageType = typeof(About)},
                new AppPage(){ PageName = "Contact", PageType = typeof(Contact)},
                new AppPage(){ PageName = "Details", PageType = typeof(Details)},
                new AppPage(){ PageName = "Industry Verticals", PageType = typeof(IndustryVerticals)},
            };
            
        }
        #endregion

        #region Properties

        private ObservableCollection<AppPage> _menuItems;
        public ObservableCollection<AppPage> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;

                OnPropertyChanged(() => MenuItems);
            }
        }

        private AppPage _selectedItem;
        public AppPage SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;


                OnPropertyChanged(() => SelectedItem);
                if (onItemSelect != null)
                {
                    onItemSelect(this, null);
                }
            }
        }

        #endregion
        
    }

   
}

