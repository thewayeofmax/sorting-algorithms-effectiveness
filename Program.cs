namespace algorithms_effectiveness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aa = Generators.GenerateFewUniques(10000);

            foreach (int i in aa) 
            {
                Console.Write(i + " ");
            }
        }
    }
}
