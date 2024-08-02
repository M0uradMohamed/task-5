namespace stringVowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Enter a string : ");
            string word= Console.ReadLine();
            checkVowels(word);
        }
        static void checkVowels (string word)
        {
            try
            {
                word = word.ToLower();
                bool check = false;
                foreach (var item in word)
                {
                    if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    {
                        check = true;
                    }
                }
                if (check == false)
                    throw new Exception("This string does not contain any vowels");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
