using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Eleven
{
    class GameState
    {
        public int number, i, j;

        public GameState(int number, int i, int j)
        {
            this.number = number;
            this.i = i;
            this.j = j;
        }
        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="state"></param>
        public GameState(GameState state) : this(state.number, state.i, state.j)
        {
        }
    }
}
