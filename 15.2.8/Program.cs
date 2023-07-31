var list = new List<int>();
while (true)
{
    var input = Console.ReadLine();
    if (input != null)
    {
        bool Parsed = Int32.TryParse(input, out var intValue);
        if (Parsed)
        {
            list.Add(intValue);
            Console.WriteLine($"Count:{list.Count()}, Sum:{list.Sum()}, Max:{list.Max()}, Avg:{list.Average()}");
        }
    }
}