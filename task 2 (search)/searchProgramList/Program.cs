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
                
                try
                {
                    Console.Write("Enter a number to add : ");
                    int number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == number)
                            throw new Exception("this number already in the list");
                    }
                    numbers.Add(number);
                }
                catch(FormatException exe) 
                {
                    Console.WriteLine($"input is not an intger ");
                }
                catch( Exception exe)
                {
                    Console.WriteLine(exe.Message);
                }

            }while (going);
        }
    }
}
