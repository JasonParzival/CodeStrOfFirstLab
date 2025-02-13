namespace TheThirdCode
{
    public class Logic
    {
        public static string Message(string str)
        {
            string[] words = str.Split();
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
            string str = "I wanna eat guobaorou with rice and di san xian dad";
            
            string message = Logic.Message(str);

            Console.WriteLine(message);
        }
    }
}
