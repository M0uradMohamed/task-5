namespace searchProgramList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool going = true;
            do
            {
                Console.Write("Enter a number to add : ");
                int number = int.Parse(Console.ReadLine());
                try
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                            throw new Exception("this number already in the list");
                    }
                    numbers.Add(number);
                }
                catch(Exception exe) 
                {
                    Console.WriteLine(exe.ToString());
                    going = false;
                }

            }while (going);
        }
    }
}
