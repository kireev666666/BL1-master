using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравсвуйте, меня зовут Василиса. Предоставьте список документов");

            var documents = new  string [1];
            const bool Photo = true;

            var document = Console.ReadLine();
            documents[0] = document;

            Console.WriteLine("Do you have a photo?");
            bool Photo1 = bool.Parse(Console.ReadLine());

            if (Photo1 == Photo)
            {
                Console.WriteLine("Ok. Go to pay");
            }
            else
            {
                Console.WriteLine("Go ot photo room");

                Console.WriteLine("Do you have a photo?");
                int Photo2 = Int32.Parse(Console.ReadLine());

                if (Photo2 <= 3)
                {
                    Console.WriteLine("Ok. Go to pay");
                }
                else
                {
                    Console.WriteLine("Go to photo room");

                    Console.WriteLine("Do you use photo in passport?");
                    bool Photo3 = bool.Parse(Console.ReadLine());

                    if (Photo3 == Photo)
                    {
                        Console.WriteLine("Go to photo room");
                    }
                    else
                    {
                        Console.WriteLine("Ok. Go to pay");

                        Console.WriteLine("Do you paste photo in passport?");
                        bool Photo4 = bool.Parse(Console.ReadLine());

                        if (Photo4 == Photo)
                        {
                            Console.WriteLine("Ok. Go to pay");
                        }
                        else
                        {
                            Console.WriteLine("Go to photo room");
                        }

            }

            Console.ReadLine();
        }
    }
}
