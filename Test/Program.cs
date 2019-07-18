using System;
using Test.One;
using Test.Three;
using Test.Two;
using Test.Five;
using Test.Eight;
using Test.Ten;
using Test.Eleven;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //One();

            //Two();

            //Three();

            //Five();

            //Eight();

            //Ten();

            int[] arr = new int[] { 9,4, 4};
            Console.WriteLine(string.Join(',',arr));
            Console.WriteLine(B1(arr, 0, arr.Length - 1).ToString());
            Console.WriteLine(arr[B1(arr, 0, arr.Length - 1)].ToString());

            //Eleven();
        }


        public static int B1withXor(int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res = res ^ arr[i];
            }
            return res;
        }

        /// <summary>
        /// Section B, Question 1 (20 Points)
        /// Gets an array, which has every number twice but one number that appears only once, and returns the number that appears only once.
        /// </summary>
        /// <param name="arr">An "almost double array"</param>
        /// <param name="i">array start index</param>
        /// <param name="j">array end index</param>
        /// <returns>The number which appears only once.</returns>
        public static int B1(int[] arr, int i, int j)
        {
            if (j - i == 1)
            {
                // The answer can only appear on an even index
                if (i % 2 == 0) return i; 
                else return j;
            }
            int mid = (i + j) / 2;
            if (arr[mid] == arr[mid + 1])
            {
                if (mid % 2 == 0)
                    return B1(arr, mid, j);
                else
                    return B1(arr, i, mid);
            }
            else
            {
                if (mid % 2 == 1)
                    return B1(arr, mid, j);
                else
                    return B1(arr, i, mid);
            }
        }


        public static void One()
        {
            ShipGame shipGame = new ShipGame();
            shipGame.TakeDamage(10);
            shipGame.NextStage();
            shipGame.TakeDamage(10);
            shipGame.TakeDamage(10);
            shipGame.TakeDamage(10);
            shipGame.NextStage();
            shipGame.NextStage();
            shipGame.TakeDamage(10);
        }

        public static void Two()
        {
            Component root = new Composite(2);
            Component circle1 = new Leaf(2);
            Component rectangle = new Leaf(1);
            root.AddChild(circle1);
            root.AddChild(rectangle);

            Component container1 = new Composite(4);
            Component circle2 = new Leaf(2);
            Component circle3 = new Leaf(4);
            container1.AddChild(circle2);
            container1.AddChild(circle3);

            root.AddChild(container1);

            Component container2 = new Composite(6);
            Component t1 = new Leaf(4);
            Component t2 = new Leaf(2);
            container2.AddChild(t1);
            container2.AddChild(t2);

            root.AddChild(container2);

            root.Draw("");

            Console.WriteLine("Sum:" +root.Sum());
            Console.WriteLine("IsEven:" + Component.IsEven(root));
        }

        public static void Three()
        {
            CarMonitorProxy proxy = new CarMonitorProxy();
            proxy.GetPosition();
            proxy.GetTankStatus();
            Car c = new Car();
            c.Start();
            c.SpeedUp();
            c.Left();
            c.Stop();
        }

        public static void Five()
        {
            LogHandler fatal = new FatalLogHandler();
            LogHandler error = new ErrorLogHandler();
            LogHandler info = new InfoLogHandler();

            LogHandler logger = info;
            info.SetNext(error);
            error.SetNext(fatal);

            logger.Log("Fatalic thing", LogLevel.Fatal);
            logger.Log("Bad Error", LogLevel.Error);
            logger.Log("Have a nice day", LogLevel.Info);
        }

        public static void Eight()
        {
            RunningPractice rp = new RunningPractice();
            rp.Run();

            PowerliftingPractice plp = new PowerliftingPractice();
            plp.Run();
        }

        public static void Ten()
        {
            Window window = new BaseWindow();
            Console.WriteLine(window);
            Window blinking = new BlinkingWindow(window);
            Console.WriteLine(blinking);
            Window shadow = new ShadowWindow(window);
            Console.WriteLine(shadow);
            Window bs = new ShadowWindow(blinking);
            Console.WriteLine(bs);
        }

        public static void Eleven()
        {
            Game g = new Game();

            while (!g.IsFinished)
            {
                Console.Write("Command:");
                char key = Console.ReadKey().KeyChar;
                Console.Clear();
                g.HandleInput(key);
                Console.WriteLine(g);
            }
            Console.WriteLine("Bye Bye");
        }
    }
}
