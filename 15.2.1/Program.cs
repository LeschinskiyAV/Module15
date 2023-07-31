var a = Factorial(3);
static long Factorial(int number)
{
    var ListOfNums = new List<int>();
    for (var i = 1; i <= number; i++) { ListOfNums.Add(i); }
    long result = ListOfNums.Aggregate((x, y) => x * y);
    return result;
}