using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Eleven
{
    public class Game
    {
        GameState gameState;
        Memento memento;
        int boardSize;
        public bool IsFinished { get; private set; }
        public Game(int size=5)
        {
            gameState = new GameState(1, 2, 2);
            memento = new Memento();
            boardSize = size;
            IsFinished = false;
        }

        public void HandleInput(char input)
        {
            switch (input)
            {
                case '1':
                    gameState.i--;
                    break;
                case '2':
                    gameState.i++;
                    break;
                case '3':
                    gameState.j++;
                    break;
                case '4':
                    gameState.j--;
                    break;
                case '+':
                    if (gameState.number < 9)
                        gameState.number++;
                    break;
                case '-':
                    if (gameState.number > 0)
                        gameState.number--;
                    break;
                case 'S':
                    Save();
                    break;
                case 'L':
                    Load();
                    break;
                case 'X':
                    IsFinished = true;
                    break;
            }

            if (gameState.i >= boardSize  || gameState.j >= boardSize 
                || gameState.i < 0 || gameState.j < 0)
            {
                Console.WriteLine("Out of Bounds!");
                if (!Load())
                {
                    IsFinished = true;
                    Console.WriteLine("Quiting...");
                }
            }
        }


        private bool Load()
        {
            if (memento.Load() != null)
            {
                gameState = memento.Load();
                Console.WriteLine("Game Loaded successfully");
                return true;
            }
            Console.WriteLine("No saved game...");
            return false;

        }

        private void Save()
        {
            memento.Save(gameState);
            Console.WriteLine("Game Saved :)");
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (i == gameState.i && j == gameState.j)
                        str += $" {gameState.number} ";
                    else
                        str += " . ";
                }
                str += "\n";
            }
            return str;
        }

    }
}
