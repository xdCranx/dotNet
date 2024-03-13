namespace Lab1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of items:");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter seed:");
        int seed = int.Parse(Console.ReadLine());
        KnapsackProblem knp = new KnapsackProblem(num, seed);

        Console.WriteLine(knp.ToString());

        Console.WriteLine("Enter capacity:");
        int cap = int.Parse(Console.ReadLine());

        knp.Solve(cap).PrintResultList();
        
    }
}