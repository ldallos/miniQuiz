using System;

namespace miniQuizOld.View
{
    public class FieldEventArgs : EventArgs
    {
        public FieldEventArgs(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }
    }
}
