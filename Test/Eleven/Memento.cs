using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Eleven
{
    class Memento
    {
        GameState savedState;
        public Memento()
        {
        }

        public void Save(GameState state)
        {
            savedState = new GameState(state);
        }

        public GameState Load()
        {
            return new GameState(savedState);
        }
    }
}
