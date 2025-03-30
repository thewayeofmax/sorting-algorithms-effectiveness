namespace algorithms_effectiveness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = Generators.GenerateFewUniques(10);

            foreach (int i in aa) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
