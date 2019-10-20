using miniQuizOld.Model;
using miniQuizOld.View;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace miniQuizOld.Controller
{
    public class MainController
    {
        public MainController(MainWindow mainWindow)
        {
            myFields = new List<Field>();

            #region ------------------ Ez a rész csak be van égetve. Élesben majd valami file-ból jöhetne ------------------

            Field f00 = new Field
            {
                Message = "Kérdés 1",
                Reward = 100,
                X = 0,
                Y = 0,
            };
            f00.Questions.AddRange(new string[] { "Mi a neved?", "Hány éves vagy?" });
            myFields.Add(f00);

            myFields.Add(new Field { X = 0, Y = 1 });
            myFields.Add(new Field { X = 0, Y = 2 });
            myFields.Add(new Field { X = 0, Y = 3 });

            myFields.Add(new Field { X = 1, Y = 0 });
            myFields.Add(new Field { X = 1, Y = 1, Reward = 100, Message = "Nyeremény" });
            myFields.Add(new Field { X = 1, Y = 2, Reward = 200, Message = "Nyeremény" });
            myFields.Add(new Field { X = 1, Y = 3 });

            Field f20 = new Field
            {
                Message = "Kérdés 2",
                Reward = 50,
                X = 2,
                Y = 0,
            };
            f20.Questions.Add("Mi legyen a kérdés?");
            myFields.Add(f20);

            myFields.Add(new Field { X = 2, Y = 1 });

            Field f22 = new Field
            {
                Message = "Nehéz kérdések!",
                Reward = 50,
                X = 2,
                Y = 2,
            };
            f22.Questions.Add("Mi a ");
            f22.Questions.AddRange(new string[] { "Mi a kedvenc színed?", "Mi a töketlen fecske repülési sebessége?" });
            myFields.Add(f22);

            myFields.Add(new Field { X = 2, Y = 3, Reward = 2000, Message = "Nagy Nyeremény!" });

            #endregion ------------------ Ez a rész csak be van égetve. Élesben majd valami file-ból jöhetne ---------------

            myCanShow = new List<bool>();


            foreach (Field field in myFields)
            {
                myCanShow.Add(false);
                mainWindow.AddField(field.X, field.Y);
            }

            myMainWindow = mainWindow;
            mainWindow.ClickOnField += FieldClicked;
        }

        private void FieldClicked(object sender, FieldEventArgs e)
        {
            Field selectedField = myFields.Single(f => f.X == e.X && f.Y == e.Y);
            myCanShow[myFields.IndexOf(selectedField)] = true;

            string message = selectedField.Reward.ToString(CultureInfo.InvariantCulture);
            if (!string.IsNullOrWhiteSpace(selectedField.Message))
            {
                message = $"{selectedField.Message}: {selectedField.Reward}";
            }

            myMainWindow.ShowMessage(message, selectedField.X, selectedField.Y);
        }

        private List<Field> myFields;

        private List<bool> myCanShow;

        private MainWindow myMainWindow;
    }
}
