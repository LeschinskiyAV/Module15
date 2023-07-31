var punctuation = new List<char>() { ' ', ',', '.', ';', ':', '!', '?' };
var input = Console.ReadLine();
if (!string.IsNullOrEmpty(input))
{
    var processedInput = input.Except(punctuation);
    Console.WriteLine(processedInput.ToArray());
}