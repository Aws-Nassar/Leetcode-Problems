public class Solution {
    public int[] PlusOne(int[] digits) {
        if (digits[digits.Length - 1] < 9)
        {
            digits[digits.Length - 1] += 1;
            return digits;
        }

        int i = 2;
        while (i <= digits.Length)
        {
            digits[digits.Length - i + 1] = 0;
            if (digits[digits.Length - i] < 9)
            {
                digits[digits.Length - i] += 1;
                return digits;
            }
            i++;
        }

        int[] newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;

        return newDigits;   
    }
}
