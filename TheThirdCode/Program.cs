
//В тексте удалить каждое слово с четным числом символов, продублировать каждое слово с нечетным числом символов, заменив все вхождения букв ‘d’ на букву ‘t’ 

namespace TheThirdCode
{
    public class Logic
    {
        public static string Message(string str)
        {
            char[] chars = {' ', ',', '.', '!', '?', ';', ':'};
            string[] words = str.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            string needword = "";
            string message = "";
            

            foreach (string word in words)
            {
                if (word.Length % 2 == 1) //если нечетное число букв
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == 'd')
                        {
                            needword += "t";
                        }
                        else
                        {
                            needword += word[i];
                        }
                    }
                    message += needword + " " + needword + " ";
                    needword = "";
                }
            }
            return message;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "I wanna eat guobaorou with rice and di san xian dad";
            string str = Console.ReadLine();

            string message = Logic.Message(str);

            Console.WriteLine(message);
        }
    }
}
