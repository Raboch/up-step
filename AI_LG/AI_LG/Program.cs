using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AI_LG
{
    class Program
    {
        static void Main(string[] args)
        {
            // План:
            // Слышать - crl
            // Отвечать - cw
            // Массивы
            // Создать бесконечный цикл
            // запоминать

            string writePathWords = @"C:\_UpStep_\AI_LG\words.txt";// путь для сох. Списка(words.txt) в фаел
            string writePathAnswers = @"C:\_UpStep_\AI_LG\answers.txt";// путь для сох. Списка(answers.txt) в фаел           

            // Наш вопрос
            string question = Console.ReadLine();

            List<string> words = new List<string>();
            // words.Add("дру");
            // words.Add("как дела");
            //words.Add("Хадукен");
            words = File.ReadAllLines(writePathWords).ToList();

            // Если ИИ не знает
            string iDoNotKnow = "Ты дурак ***** - научи меня";

            List<string> answers = new List<string>(); // Ответ ИИ           
                                                       //   answers.Add("Здорова");
                                                       //   answers.Add("Намана");
                                                       //   answers.Add("Off");
            answers = File.ReadAllLines(writePathAnswers).ToList();

            do
            {
                for (int i = 0; i < words.Count; i++)
                {
                    if (question == words[i])
                    {
                        Console.WriteLine(answers[i]);// выводим ответ
                        break; // выйди зи цыкла for
                    }
                    else if (i == words.Count - 1)
                    {
                        Console.WriteLine(iDoNotKnow);
                       
                        AddWordEducation();// запускаем метод(функция) обучения
                    }
                }

                question = Console.ReadLine();// пишем новый вопрос
            } while (question != words[2]);// проверка, подолж. или нет(пока)

            Console.WriteLine(answers[2]);// прощаемся(пока)
            Console.ReadKey(); // пауза

            void AddWordEducation()//метод(функция) обучения
            {
                words.Add(question);
                answers.Add(Console.ReadLine());

                Console.WriteLine("я запомнил");

                File.WriteAllLines(writePathWords, words);
                File.WriteAllLines(writePathAnswers, answers);
            }
        }
    }
}
