using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using miniQuiz.Commands;
using miniQuiz.Model;

namespace miniQuiz.ViewModel
{
    public class FieldViewModel : INotifyPropertyChanged
    {
        public FieldViewModel(Field field)
        {
            CanShow = false;
            myField = field;
            ShowMessageCommand = new RelayCommand(_ => ShowMessage());
        }

        public event PropertyChangedEventHandler PropertyChanged;

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

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Field myField;

        private void ShowMessage()
        {
            CanShow = true;
            OnPropertyChanged("Message");
        }
    }
}
