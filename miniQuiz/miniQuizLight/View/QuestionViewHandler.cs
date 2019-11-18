using miniQuizLight.Interfaces;
using miniQuizLight.ViewModel;

namespace miniQuizLight.View
{
    public class QuestionViewHandler : IQuestionViewHandler
    {
        public void Show(QuestionViewModel questionViewModel)
        {
            QuestionWindow questionWindow = new QuestionWindow();
            questionWindow.DataContext = questionViewModel;
            questionWindow.ShowDialog();
        }
    }
}
