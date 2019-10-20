using System.Collections.ObjectModel;

using miniQuizLight.Model;

namespace miniQuizLight.ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
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
            f00.Questions.AddRange(new string[] { "Mi a neved?", "Hány éves vagy?" });
            Fields.Add(new FieldViewModel(f00));

            Fields.Add(new FieldViewModel(new Field { X = 0, Y = 1 }));
            Fields.Add(new FieldViewModel(new Field { X = 0, Y = 2 }));
            Fields.Add(new FieldViewModel(new Field { X = 0, Y = 3 }));

            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 0 }));
            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 1, Reward = 100, Message = "Nyeremény" }));
            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 2, Reward = 200, Message = "Nyeremény" }));
            Fields.Add(new FieldViewModel(new Field { X = 1, Y = 3 }));

            Field f20 = new Field
            {
                Message = "Kérdés 2",
                Reward = 50,
                X = 2,
                Y = 0,
            };
            f20.Questions.Add("Mi legyen a kérdés?");
            Fields.Add(new FieldViewModel(f20));

            Fields.Add(new FieldViewModel(new Field { X = 2, Y = 1 }));

            Field f22 = new Field
            {
                Message = "Nehéz kérdések!",
                Reward = 50,
                X = 2,
                Y = 2,
            };
            f22.Questions.Add("Mi a ");
            f22.Questions.AddRange(new string[] { "Mi a kedvenc színed?", "Mi a töketlen fecske repülési sebessége?" });
            Fields.Add(new FieldViewModel(f22));

            Fields.Add(new FieldViewModel(new Field { X = 2, Y = 3, Reward = 2000, Message = "Nagy Nyeremény!" }));

            #endregion ------------------ Ez a rész csak be van égetve. Élesben majd valami file-ból jöhetne ---------------
        }

        public ObservableCollection<FieldViewModel> Fields { get; }
    }
}
