using Lab1;
using System;
using System.Security.Policy;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Input of CSV File and Creation of needed lists//
            List<videogames> videogame = new List<videogames>();
            IList<videogames> videogameI = new List<videogames>();
            var title = new List<string>();
            bool breaker = true;
            string[] fields = System.IO.File.ReadAllLines("C:\\Users\\Maste\\OneDrive\\Desktop\\CSCI 2910\\labs\\lab1\\Lab1\\videogames.csv");

            for (int i = 1; i < fields.Length; i++)
            {
                string[] row = fields[i].Split(',');

                videogames videogamessaved = new videogames(row[0], row[1], double.Parse(row[2]), row[3], row[4], decimal.Parse(row[5]), decimal.Parse(row[6]),
                                            decimal.Parse(row[7]), decimal.Parse(row[8]), decimal.Parse(row[9]));

                videogame.Add(videogamessaved);
            }
            //////
            ///
            do
            {
                //Menu//
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("                   Project: List of Video Games");
                Console.WriteLine("                              ----");
                Console.WriteLine("                    Created By: Zach Farmer");
                Console.WriteLine("----------------------------------------------------------------\n");

                Menu();
                ////////

                //Choice for Menu//
                int userChoice = 0;
                try
                {
                    Console.Write("       Type the number of your choice from the menu: ");
                    userChoice = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("");
                }
                ///////

                switch (userChoice)
                {

                    case 1:
                        for (int i = 1; i < videogame.Count; i++)
                        {
                            Console.WriteLine(videogame[i]);
                        }
                        break;

                    case 2:
                        for (int i = 1; i < videogame.Count; i++)
                        {
                            videogame.Sort();
                            Console.WriteLine(videogame[i]);
                        }
                        break;
                    case 3:
                        videogame.Clear();
                        for (int i = 1; i < fields.Length; i++)
                        {
                            string[] row = fields[i].Split(',');

                            videogames videogamessaved = new videogames(row[0], row[1], double.Parse(row[2]), row[3], row[4], decimal.Parse(row[5]), decimal.Parse(row[6]),
                                                        decimal.Parse(row[7]), decimal.Parse(row[8]), decimal.Parse(row[9]));

                            videogame.Add(videogamessaved);
                        }
                        Console.WriteLine("       Back to Normal!");
                        break;
                    case 4:
                        PublisherDataList();
                        break;
                    case 5:

                        PublisherData();
                        break;

                    case 6:
                        GenreDataList();
                        break;

                    case 7:

                        GenreData();
                        break;


                    case 8:
                        Console.WriteLine("       thank you for using the program");
                        breaker = false;
                        break;
                        default:
                        Console.WriteLine("       Please Type a number 1-8");
                        break;
                }

            } while (breaker);
            #region Methods
            void Menu()
            {

                Console.WriteLine("\n----------------------------------------------------------------");
                Console.WriteLine("                            Menu");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("       1. Display Everything Normally");
                Console.WriteLine("       2. Sort by Name");
                Console.WriteLine("       3. UnSort");
                Console.WriteLine("       4. Sort and Find Publisher");
                Console.WriteLine("       5. Percent of games by a Publisher");
                Console.WriteLine("       6. Sort and Find Genre");
                Console.WriteLine("       7. Percent of games by a Genre");
                Console.WriteLine("       8. Exit");
                Console.WriteLine("----------------------------------------------------------------");


            }
            void GenreData()
            {
                List<string> gC = new List<string>();
                string gencount = " ";
                Console.Write("       Enter Genre: ");
                gencount = Console.ReadLine();
                string genU2 = char.ToUpper(gencount[0]) + gencount.Substring(1);

                var gens2 = videogame.Where(s => s.genre == genU2);
                foreach (videogames p in gens2)
                {
                    gC.Add("counter");
                }

                Console.WriteLine($"\n       Out of {videogame.Count} games, {gC.Count} are from {genU2} games. That is {((double)gC.Count / videogame.Count * 100).ToString("0.00")}%\n");
            }
            void PublisherData()
            {
                List<string> pC = new List<string>();
                string pubcount = " ";
                Console.Write("       Enter Publisher: ");
                pubcount = Console.ReadLine();
                string pubU2 = char.ToUpper(pubcount[0]) + pubcount.Substring(1);

                var publish2 = videogame.Where(s => s.publisher == pubU2);
                foreach (videogames p in publish2)
                {
                    pC.Add("counter");
                }

                Console.WriteLine($"\n       Out of {videogame.Count} games, {pC.Count} are from {pubU2}. That is {((double)pC.Count / videogame.Count * 100).ToString("0.00")}%\n");
            }
            void GenreDataList()
            {
                string gen = " ";
                Console.Write("       Enter Genre: ");
                gen = Console.ReadLine();
                string genU = char.ToUpper(gen[0]) + gen.Substring(1);

                var gens = videogame.Where(s => s.genre == genU);
                videogame.Sort();

                foreach (videogames p in gens)
                {
                    Console.WriteLine(p);
                }
            }
            void PublisherDataList()
            {
                string pub = " ";
                Console.Write("       Enter Publisher: ");
                pub = Console.ReadLine();
                string pubU = char.ToUpper(pub[0]) + pub.Substring(1);

                var publish = videogame.Where(s => s.publisher == pubU);
                videogame.Sort();

                foreach (videogames p in publish)
                {
                    Console.WriteLine(p);
                }

            }
            #endregion
        }
    }
}
