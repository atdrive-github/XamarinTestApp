using System;
using System.Reflection;
using TestApp.ViewModel;
using Xamarin.Forms;

namespace TestApp.View
{
    public partial class MainPage
    {
        #region constructor

        public MainPage()
        {
            InitializeComponent();
            var viewModel = BindingContext as MainPageViewModel;
            if (viewModel != null)
            {
                viewModel.onItemSelect += RedirectTo;
            }

        }

        #endregion

        #region events action

        private void RedirectTo(object sender, EventArgs e)
        {
            var viewModel = sender as MainPageViewModel;
            if (viewModel == null) return;
            var constructors =viewModel.SelectedItem.PageType.GetTypeInfo().DeclaredConstructors;
            foreach (ConstructorInfo constructor in constructors)
            {
                if (constructor.GetParameters().Length == 0)
                {
                    var page = (Page)constructor.Invoke(null);
                    Navigation.PushAsync(page);
                    break;
                }
            }
        }
        
        #endregion
    }
}