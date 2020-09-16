using System;
using System.Collections.Generic;

namespace TheForest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[5];
            name[0] = "Varg";
            name[1] = "Fladdermus";
            name[2] = "Delfin";
            name[3] = "Örn";
            name[4] = "Häst";

            Random rnd = new Random();
            var forest = new List<Animal>();

            for(int i = 0; i < 5; i++)
            {
                Animal animals = new Animal();
                animals.animalSpecies = name[i];
                animals.Nocturnal = (rnd.Next(1, 100) < 50);
                forest.Add(animals);
            }


            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.KeyChar == 'd')
                {
                    Console.Clear();
                    foreach(var a in forest)
                    {
                        switch (a.animalSpecies)
                        {
                            case "Varg":
                                if (a.Nocturnal)Console.WriteLine("Vargen sover i grottan.");
                                else Console.WriteLine("Vargen är ute och jagar.");
                                break;
                            case "Fladdermus":
                                if (a.Nocturnal) Console.WriteLine("Fladdermusen sover i grottan.");
                                else Console.WriteLine("Fladdermusen flyger runt bland träden i jakt på mat.");
                                break;
                            case "Delfin":
                                if (a.Nocturnal) Console.WriteLine("Delfinen sover.");
                                else Console.WriteLine("Delfinen jagar fisk i vattnet.");
                                break;
                            case "Örn":
                                if (a.Nocturnal) Console.WriteLine("Örnen sover.");
                                else Console.WriteLine("Örnen flyger runt letar mat.");
                                break;
                            case "Häst":
                                if (a.Nocturnal) Console.WriteLine("Hästen sover i stallet.");
                                else Console.WriteLine("Är ute och betar.");
                                break;
                        }

                    }
                }
                if (key.KeyChar == 'n')
                {
                    Console.Clear();
                    foreach (var a in forest)
                    {
                        switch (a.animalSpecies)
                        {
                            case "Varg":
                                if (!a.Nocturnal) Console.WriteLine("Vargen sover i grottan.");
                                else Console.WriteLine("Vargen är ute och jagar.");
                                break;
                            case "Fladdermus":
                                if (!a.Nocturnal) Console.WriteLine("Fladdermusen sover i grottan.");
                                else Console.WriteLine("Fladdermusen flyger runt bland träden i jakt på mat.");
                                break;
                            case "Delfin":
                                if (!a.Nocturnal) Console.WriteLine("Delfinen sover.");
                                else Console.WriteLine("Delfinen jagar fisk i vattnet.");
                                break;
                            case "Örn":
                                if (!a.Nocturnal) Console.WriteLine("Örnen sover.");
                                else Console.WriteLine("Örnen flyger runt letar mat.");
                                break;
                            case "Häst":
                                if (!a.Nocturnal) Console.WriteLine("Hästen sover i stallet.");
                                else Console.WriteLine("Är ute och betar.");
                                break;
                        }
                    }
                }
            }


        }

    }

    public class Animal
    {
        public string animalSpecies { get; set; }
        public bool Nocturnal { get; set; }
    }
}
