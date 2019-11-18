﻿using System.Collections.ObjectModel;
using miniQuizLight.Interfaces;
using miniQuizLight.Model;

namespace miniQuizLight.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel(IQuestionViewHandler questionViewHandler)
        {
            Fields = new ObservableCollection<FieldViewModel>();

            #region ------------------ Ez a rész csak be van égetve. Élesben majd valami file-ból jöhetne ------------------

            Field f00 = new Field
            {
                Message = "Kérdés 1",
                Reward = 100,
                X = 0,
                Y = 0,
            };
            f00.Questions.AddRange(new Question[]
            {
                new Question { QuestionText = "Mi a neved?", GoodAnswer = "Aladár" },
                new Question { QuestionText = "Hány éves vagy?", GoodAnswer = "23" }
            });
            f00.Questions[0].Answers.AddRange(new string[] { "Aladár", "Béla", "Géza" });
            f00.Questions[1].Answers.AddRange(new string[] { "1", "100", "23", "99" });

            Fields.Add(new FieldViewModel(f00, questionViewHandler));

            Fields.Add(new FieldViewModel(new Field { X = 0, Y = 1 }, questionViewHandler));
            Fields.Add(new FieldViewModel(new Field { X = 0, Y = 2 }, questionViewHandler));
            Fields.Add(new FieldViewModel(new Field { X = 0, Y = 3 }, questionViewHandler));

            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 0 }, questionViewHandler));
            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 1, Reward = 100, Message = "Nyeremény" }, questionViewHandler));
            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 2, Reward = 200, Message = "Nyeremény" }, questionViewHandler));
            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 3 }, questionViewHandler));

            Field f20 = new Field
            {
                Message = "Kérdés 2",
                Reward = 50,
                X = 2,
                Y = 0,
            };
            f20.Questions.Add(new Question { QuestionText = "Mi legyen a kérdés?", GoodAnswer = "Nem tudom..." });
            f20.Questions[0].Answers.AddRange(new string[] { "Kettőt könnyebbet.", "Nem tudom...", "Mit tudom én?" });
            Fields.Add(new FieldViewModel(f20, questionViewHandler));

            Fields.Add(new FieldViewModel(new Field { X = 2, Y = 1 }, questionViewHandler));

            Field f22 = new Field
            {
                Message = "Nehéz kérdések!",
                Reward = 50,
                X = 2,
                Y = 2,
            };
            f22.Questions.AddRange(new Question[]
            {
                new Question { QuestionText = "Mi a kedvenc színed?", GoodAnswer = "kék" }, 
                new Question { QuestionText = "Mi a töketlen fecske repülési sebessége?", GoodAnswer = "Afrikai vagy ázsiai?" } 
            });
            f22.Questions[0].Answers.AddRange(new string[] { "barna", "kék", "kék" });
            f22.Questions[1].Answers.AddRange(new string[] { "Afrikai vagy ázsiai?", "100 km/h", "10 km/h", "100 m/s" });
            Fields.Add(new FieldViewModel(f22, questionViewHandler));

            Fields.Add(new FieldViewModel(new Field { X = 2, Y = 3, Reward = 2000, Message = "Nagy Nyeremény!" }, questionViewHandler));

            #endregion ------------------ Ez a rész csak be van égetve. Élesben majd valami file-ból jöhetne ---------------
        }

        public ObservableCollection<FieldViewModel> Fields { get; }
    }
}
