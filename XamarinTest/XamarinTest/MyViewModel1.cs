using System.Collections.ObjectModel;
using System.Windows.Input;
using MVVMBase.Command;
using MVVMBase.ViewModel;

namespace XamarinTest
{
    class MyViewModel1 : ViewModelBase
    {
        #region Left
        private int left;
        public int Left
        {
            get { return left; }
            set
            {
                if (value == left)
                    return;

                left = value;
                OnPropertyChanged("Left");
            }
        }

        #endregion

        #region Right
        private int right;
        public int Right
        {
            get { return right; }
            set
            {
                if (value == right)
                    return;

                right = value;
                OnPropertyChanged("Right");
            }
        }
        #endregion

        #region Result
        private double result;
        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                OnPropertyChanged("Result");
            }
        }
        #endregion


        #region Operations
        /*private string[] operations = new string[4] { "+", "-", "*", "/" };

        public string[] Operations
        {
            get
            {
                return operations;
            }
        }*/
        #endregion

        #region SelectedOperation
        private string selectedOperation;

        public string SelectedOperation
        {
            get { return selectedOperation; }
            set
            {
                if (selectedOperation == value)
                    return;

                selectedOperation = value;
                OnPropertyChanged("SelectedOperation");
            }
        }
        #endregion operation


        #region AddCommand
        private ICommand operationCommand;

        public ICommand OperationCommand
        {
            get
            {
                return operationCommand ?? (operationCommand = new AppCommand(
                    (object obj) =>
                    {
                        
                        switch (SelectedOperationIndex)
                        {
                            case 0:
                                Result = Left + Right;
                                break;

                            case 1:
                                Result = Left - Right;
                                break;

                            case 2:
                                Result = (double)Left * (double)Right;
                                break;

                            case 3:
                                Result = (double)Left / (double)Right;
                                break;
                        }

                        //Result = Left + Right;
                        OnPropertyChanged("Result");
                    }
                ));
            }
        }
        #endregion


        #region Operations
        private ObservableCollection<string> operations = new ObservableCollection<string>() { "+", "-", "*", "/" };

        public ObservableCollection<string> Operations
        {
            get { return operations; }
            set
            {
                operations = value;
                OnPropertyChanged("Operations");
            }
        }

        //public string[] Operations = new string[] { "+", "-", "*", "/" };
        #endregion

        #region SelectedOperationIndex
        private int selectedOperationIndex;

        public int SelectedOperationIndex
        {
            get { return selectedOperationIndex; }
            set
            {
                if (selectedOperationIndex == value)
                    return;

                selectedOperationIndex = value;
                OnPropertyChanged("SelectedOperationIndex");
            }
        }

        #endregion
    }
}
