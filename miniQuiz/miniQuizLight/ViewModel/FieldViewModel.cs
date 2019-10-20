using System.Globalization;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using miniQuizLight.Model;

namespace miniQuizLight.ViewModel
{
    public class FieldViewModel : ViewModelBase
    {
        public FieldViewModel(Field field)
        {
            CanShow = false;
            myField = field;
            ShowMessageCommand = new RelayCommand(ShowMessage);
        }

        public ICommand ShowMessageCommand { get; set; }

        public string Message
        {
            get
            {
                if (CanShow)
                {
                    string message = myField.Reward.ToString(CultureInfo.InvariantCulture);
                    if (!string.IsNullOrWhiteSpace(myField.Message))
                    {
                        message = $"{myField.Message}: {myField.Reward}";
                    }
                    return message;
                }
                else
                {
                    return string.Empty;
                }
            }
        }

        public int X
        {
            get { return myField.X; }
        }

        public int Y
        {
            get { return myField.Y; }
        }

        public bool CanShow { get; set; }

        private Field myField;

        private void ShowMessage()
        {
            CanShow = true;
            RaisePropertyChanged("Message");
        }
    }
}
