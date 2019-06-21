using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace POCity.Properties
{
    public class TextInterface
    {
        private IFormatter formatter = new BinaryFormatter();
        private Map GameBoard = new Map();

        public TextInterface()
        {
            Console.Clear();
            Console.WriteLine("Welcome to POCity!");
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "POCity";
            Console.SetWindowSize(66, 50);
        }

        private void WriteMap()
        {
            //pierwszy rzad
            Console.Write('\u250F'); // katownik lewo dol
            for (int i = 0; i < GameBoard.width * 3 + 2; i++)
            {
                Console.Write('\u2501'); // pozioma
            }
            Console.Write('\u2513'); // katownik prawo dol

            Console.Write("\n");

            //teraz indeksy X
            int index = 0;

            Console.Write('\u2503'); // pionowa
            Console.Write("  ");

            for (int i = 0; i < 20; i++)
            {

                index = i + 1;
                if (index < 10)
                {
                    Console.Write(index + "  ");
                }
                else
                {
                    Console.Write(index + " ");
                }
            }

            Console.Write('\u2503'); // pionowa

            Console.Write("\n");

            for (int i = 0; i < GameBoard.height; i++)
            {
                Console.Write('\u2503'); // pionowa
                index = i + 1;
                if (index < 10)
                {
                    Console.Write(index + " ");
                }
                else
                {
                    Console.Write(index);
                }

                for (int j = 0; j < 20; j++)
                {

                    Console.Write(GameBoard.CallToString(i, j));
                    Console.Write(" ");
                }
                Console.Write("\u2503 \n"); // pionowa

            }

            Console.Write('\u2517'); // katownik prawo gora
            for (int j = 0; j < GameBoard.width * 3 + 2; j++)
            {
                Console.Write('\u2501'); // pozioma
            }

            Console.Write('\u251B'); // katownik lewo gora

            Console.Write("\n");
        }

        private void DrawNews(string last_news)
        {
            for (int i = 0; i < GameBoard.width * 3; i++)
            {
                Console.Write("\u2505");
            }
            Console.Write("\n");
            if (last_news != null)
            {
                Console.Write(last_news);
            }
            Console.Write("\n");
            for (int i = 0; i < GameBoard.width * 3; i++)
            {
                Console.Write("\u2505");
            }
            Console.Write("\nType command:\n>");
        }

        private void DrawMap()
        {
            Console.Clear();
            Console.WriteLine("Welcome to POCity!");
            WriteMap();
        }

        private void Draw(string last_news)
        {
            DrawMap();
            DrawNews(last_news);
        }
        
        private void DrawInformation(string input, string last_news)
        {
            DrawMap();

            int x = -1, y = -1;
            string[] cropped_input = input.Split(' ');

            try
            {
                x = Convert.ToInt32(cropped_input[1]);
                y = Convert.ToInt32(cropped_input[2]);

                x = x - 1;
                y = y - 1;

                var info_data = GameBoard.TellAbout(y, x);

                for(int i=0;i<GameBoard.width*3;i++)
                {
                    Console.Write("\u2550");
                }
                Console.Write("\n");

                Console.Write("Displaying info:\n" + "Property name: " + info_data[0] + "\n");

                int information_count = info_data.Count();
                if (information_count > 1)
                {
                    Console.Write("Power: " + info_data[2] + "\n");
                    Console.Write("Water: " + info_data[3] + "\n");
                    if(information_count > 4)
                    {
                        Console.Write("Police station: " + info_data[4] + "\n");
                        Console.Write("Fire Department: " + info_data[5] + "\n");
                        Console.Write("Hospital: " + info_data[6] + "\n");
                        if(information_count > 7)
                        {
                            Console.Write("Park: " + info_data[7] + "\n");
                            if(information_count > 8)
                            {
                                Console.Write("School: " + info_data[8] + "\n");
                            }
                        }
                    }
                    Console.Write("Operating: " + info_data[1] + "\n");
                }
            }
            catch (Exception e)
            {
                if(e is System.FormatException)
                {
                    last_news = "Numbers Please";
                }
                else if (e is System.IndexOutOfRangeException)
                {

                    last_news = "Wrong coordinates. Maybe try again?";
                }
            }
            DrawNews(last_news);
        }
        
        private void SaveGame(Map map_p)
        {
            Stream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\POcity", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, map_p);

            stream.Close();
        }

        private Map LoadGame()
        {
            Stream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\POcity", FileMode.Open, FileAccess.Read);
            Map objnew = (Map)formatter.Deserialize(stream);

            stream.Close();
            return objnew;
        }

        private string Build(string input)
        {
            string to_build = " ";
            int x = -1, y = -1;
            string[] cropped_input;
            cropped_input = input.Split(' ');
            string info = null;

            try
            {
                x = Convert.ToInt32(cropped_input[1]);
                y = Convert.ToInt32(cropped_input[2]);
                to_build = "POCity.Properties." + cropped_input[3];

                try
                {
                    info = GameBoard.RaiseBuilding((y - 1), (x - 1), to_build);
                }
                catch (Exception e)
                {

                    if (e is System.IndexOutOfRangeException)
                    {
                        info = "Wrong coordinates. Maybe try again?";
                    }

                    if (e is Exceptions.UnableToBuild)
                    {
                        info = "I wasn't able to build that. Maybe try again?";
                    }
                }
                return info;
            }
            catch (Exception e)
            {
                if (e is IndexOutOfRangeException || e is FormatException)
                {
                    info = "Incorrect command format. Maybe try again?";
                }

            }
            return info;
        }

        public void Run()
        {
            GameBoard.ForceRaiseHighway(0, 9);
            Console.WriteLine("GetFolderPath: {0}", Environment.GetFolderPath(Environment.SpecialFolder.System));

            Draw("Start building!");
            string input = " ";
            bool play = true;

            while (play)
            {

                input = Console.ReadLine();
                input = input.Trim();
                if (input == "draw")
                {
                    Draw("Refreshed");
                }

                else if(input == "save")
                {
                    SaveGame(GameBoard);
                    Draw("Game saved.");
                }

                else if(input == "load")
                {
                    GameBoard = LoadGame();
                    Draw("Game loaded.");
                }

                else if (input.StartsWith("info"))
                {
                    DrawInformation(input, "Showing info");
                }

                else if (input.StartsWith("build"))
                {
                    DrawInformation(input,Build(input));
                }

                else if(input == "points")
                {
                    Console.Write("City is worth: " + GameBoard.CountPoints() + "\n");
                }

                else if(input == "end")
                {
                    Console.Write("Congratulations!\nYou've build city worth: " + GameBoard.CountPoints() + " points\n\n");
                    Console.Write("Press any key to quit...");
                    Console.ReadKey();
                    
                    play = false;
                }

                else
                {
                    Console.Write("Incorrect command. See documentation for whole list.\n>");
                }
            }
        }
    }
}
