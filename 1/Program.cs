internal class Program
{
    private static void Main(string[] args)
    {
        List<int> elves = new List<int>() { 0 };
        int elfIndex = 0;

        using (StreamReader sr = File.OpenText("input.txt"))
        {
            string? s = "";
            while ((s = sr.ReadLine()) != null)
            {
                if (s == "")
                {
                    elfIndex += 1;
                    elves.Add(0);
                    continue;
                }
                elves[elfIndex] += Int32.Parse(s);
            }
        }

        Console.WriteLine("Max Value: " + elves.Max().ToString());

        elves.Sort();
        elves.Reverse();
        Console.WriteLine("Top three: " + elves.GetRange(0, 3).Sum().ToString());


    }
}