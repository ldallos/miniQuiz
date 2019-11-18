using System.Globalization;
using System.Windows.Input;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using miniQuizLight.Interfaces;
using miniQuizLight.Model;

namespace miniQuizLight.ViewModel
{
    public class FieldViewModel : ViewModelBase
    {
        public FieldViewModel(Field field, IQuestionViewHandler questionViewHandler)
        {
            CanShow = false;
            myField = field;
            myquestionViewHandler = questionViewHandler;
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

        private IQuestionViewHandler myquestionViewHandler;

        private void ShowMessage()
        {
            if (myField.Questions.Count > 0)
            {
                bool success = true;
                foreach (Question question in myField.Questions)
                {
                    QuestionViewModel questionViewModel = new QuestionViewModel(question);
                    myquestionViewHandler.Show(questionViewModel);
                    if (question.GoodAnswer != questionViewModel.SelectedAnswer)
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    CanShow = true;
                    RaisePropertyChanged("Message");
                }
            }
            else
            {
                CanShow = true;
                RaisePropertyChanged("Message");
            }
        }
    }
}
