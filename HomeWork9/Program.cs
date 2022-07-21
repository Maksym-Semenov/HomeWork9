using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HomeWork9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HomeWork9-A-1
            List<Shape> Shapes = new List<Shape>();
            Shapes.Add(new Circle("Trainee circle", 2));
            Shapes.Add(new Circle("Junior circle", 3));
            Shapes.Add(new Circle("Middle circle", 4));
            Shapes.Add(new Square("Trainee square", 3));
            Shapes.Add(new Square("Junior square", 4));
            Shapes.Add(new Square("Middle square", 5));
            Console.WriteLine("\tTask 1 - set list of Shapes");
            foreach (Shape s in Shapes)
            {
                if (s.GetType() == typeof(Circle) || s.GetType() == typeof(Square))
                {
                    s.Area();
                    s.Perimeter();
                    s.Print();
                }
            }
            Console.WriteLine();
            //HomeWork9-A-2
            Console.WriteLine("\tTask 2 - select areas of Shapes");
            string path = @"D:\Task 9\task9.txt";
            IEnumerable<Shape> selectArea = from s in Shapes
                                            where s.Area() >= 15 && s.Area() <= 100
                                            select s;
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (Shape s in selectArea)
                {
                    sw.WriteLine($"Shape: {s.Name} has area {s.Area()}");
                    s.Print();
                }
            }
            Console.WriteLine();
            //HomeWork9-A-3
            Console.WriteLine("\tTask 3 - select Shapes, which has letter 'a'");
            IEnumerable<Shape> selectLetter = from s in Shapes
                                              where s.Name.Contains("o")
                                              select s;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Shape s in selectLetter)
                {
                    sw.WriteLine($"Shape: {s.Name} has letter 'o'.");
                    s.Print();
                }
            }
            Console.WriteLine();
            //HomeWork9-A-4
            Console.WriteLine("\tTask 4 - select Shapes, which has Perimeter < 15");
            IEnumerable<Shape> selecPerimeter = from s in Shapes
                                              where s.Perimeter() <= 15
                                              select s;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                foreach (Shape s in selecPerimeter)
                {
                    sw.WriteLine($"Shape: {s.Perimeter()} less then minimum");
                    s.Print();
                }
            }
            //HomeWork9-B-1
            string path2 = @"D:\Task 9\about Ukraine.txt";
            List<string> words = new List<string>();
            string row;
            using (StreamReader sr = new StreamReader(path2, true))
            {
                while((row = sr.ReadLine()) != null)
                {
                    words.Add(row);
                } 
            }
            //HomeWork9-B-2
            int minValue = 0;
            int maxValue;
            foreach (string str in words)
            {
                if (minValue < str.Length)
                {
                    minValue  = str.Length;
                }
                else if (minValue > str.Length)
                {
                    maxValue = str.Length;
                }
            }
            //HomeWork9-B-3
            foreach (string str in words)
            {
                IEnumerable<string> stringVar = from s in words
                                                where s.Contains("var")
                                                select s;
                Console.WriteLine(stringVar);
            }
            Console.ReadLine();
        }
    }
}
