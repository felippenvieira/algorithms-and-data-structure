internal class Program
{
    private static void Main(string[] args)
    {
        int MaximumWealth(int[][] accounts) =>
            accounts.Max(x => x.Sum());
    }
}
