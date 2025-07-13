public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        int n = digits.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] newNumber = new int[n + 1];
        newNumber[0] = 1;

        return newNumber;
    }

}
class Program
{
    static void Main()
    {
        int[] digits = { 1, 2, 3 };
        Solution s = new Solution();
        int[] result = s.PlusOne(digits);

        Console.WriteLine(string.Join(", ", result));
    }
}
