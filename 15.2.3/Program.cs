static double Average(int[] numbers)
{
    // если делить два целых числа, которые не делятся без остатка, при делении остаток будет отброшен
    // чтобы этого не случилось, нужно привести одно из чисел к типу double
    return numbers.Sum() / (double)numbers.Length;
}