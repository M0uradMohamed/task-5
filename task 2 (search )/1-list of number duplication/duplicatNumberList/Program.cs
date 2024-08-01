namespace duplicatNumberList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the list of numbers : ");
            string s = Console.ReadLine();
            List<int> numbers = new List<int>();
            char[] separators = new char[] { ' ', ',' };
            numbers = s.Split(separators, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            for(int i=0; i<numbers.Count; i++)
            {
                for (int y = i+1; y < numbers.Count; y++)
                {
                    try
                    {
                        if (numbers[i] == numbers[y])
                        {
                            throw new Exception("this number is duplicated");
                        }
                      
                    }
                    catch (Exception exe)
                    {
                        Console.WriteLine(exe.ToString());
                    }
                }
            }
        }
    }
}
