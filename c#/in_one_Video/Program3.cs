
using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Jane", "Frank", "Alice", "Tom"};
            string[] girls = new string[5];

            names.SetValue("Beky", 1);
            names.SetValue("Erzebeth", 3);

            Console.WriteLine(names.GetValue(1));
            Console.WriteLine(names.GetValue(3));

            Console.WriteLine(Array.IndexOf(names, "Erzebeth"));

            Array.Copy(names, girls, names.Length);

            foreach(string girl in girls)
            {
                Console.Write(girl + " ");
            }
        
            Console.Write('\n');

            Array.Clear(names, 0, 2);

            foreach(string name in names)
            {
                Console.Write(name + " ");
            }

            Console.Write('\n');
        }
    }
}
