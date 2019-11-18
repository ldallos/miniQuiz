using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

using miniQuizLight.Model;

using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace miniQuizLight.ViewModel
{
    public class QuestionViewModel : ViewModelBase
    {
        public QuestionViewModel(Question question)
        {
            myQuestion = question;
            Answers = myQuestion.Answers;
            AnswerSearchCommand = new RelayCommand(AnswerSearch);
        }

        public ICommand AnswerSearchCommand { get; set; }

        public string QuestionText
        {
            get { return myQuestion.QuestionText; }
        }

        public List<string> Answers { get; private set; }

        public string SelectedAnswer{ get; set; }

        public string AnswerSearchText { get; set; }

        private Question myQuestion;

        private void AnswerSearch()
        {
            Answers = myQuestion.Answers.Where(answer => answer.Contains(AnswerSearchText)).ToList();
            RaisePropertyChanged("Answers");
        }

    }
}
