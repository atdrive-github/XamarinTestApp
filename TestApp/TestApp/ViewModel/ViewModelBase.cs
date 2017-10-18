using System;
using System.ComponentModel;
using System.Linq.Expressions;


namespace TestApp.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Implementation of INotifyPropertyChanged

        private void AppPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(e.PropertyName);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public void OnPropertyChanged<T>(Expression<Func<T>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (PropertyChanged != null && memberExpression != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(memberExpression.Member.Name));
            }
        }

        #endregion
    }
}
