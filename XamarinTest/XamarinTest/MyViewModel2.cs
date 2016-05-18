using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MVVMBase.Command;
using MVVMBase.ViewModel;


namespace XamarinTest
{
    class MyViewModel2 : ViewModelBase
    {
        public MyViewModel2()
        {
            ListItems.Add("Hello");
            ListItems.Add("World");
        }

        #region ListItems
        private ObservableCollection<string> listItems = new ObservableCollection<string>();

        public ObservableCollection<string> ListItems
        {
            get { return listItems; }
        }
        #endregion

        #region ListSelectedItem
        private string listSelectedItem;

        public string ListSelectedItem
        {
            get { return listSelectedItem; }
            set
            {
                if (listSelectedItem == value)
                    return;

                listSelectedItem = value;
                OnPropertyChanged("ListSelectedItem");
            }
        }
        #endregion


        #region InputValue
        private string inputValue;

        public string InputValue
        {
            get { return inputValue; }
            set
            {
                if (inputValue == value)
                    return;

                inputValue = value;
                OnPropertyChanged("InputValue");
            }
        }
        #endregion

        #region AddCommand
        private ICommand addCommand;

        public ICommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new AppCommand((object obj) =>
                {
                    ListItems.Add(InputValue);
                    InputValue = "";
                }));
            }
        }
        #endregion

        #region RemoveCommand
        private ICommand removeCommand;

        public ICommand RemoveCommand
        {
            get
            {
                return removeCommand ?? (removeCommand = new AppCommand((object obj) =>
                {
                    if (InputValue == null)
                        return;

                    ListItems.Remove(InputValue);
                }));
            }
        }
        #endregion
    }
}
