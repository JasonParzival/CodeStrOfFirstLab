namespace TheThirdCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "I wanna eat guobaorou with rice and di san xian";
            string dubl = "";
            string[] words = str.Split();

            foreach (string word in words)
            {
                if(word.Length % 2 == 1) //если нечетное число букв
                {
                    Console.Write(word + " " + word + " ");
                }
                //Console.WriteLine(word);
            }

        }
    }
}
