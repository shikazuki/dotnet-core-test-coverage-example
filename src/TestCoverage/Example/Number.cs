using System;

namespace Example
{
    public class Number
    {
        public static bool IsEven(int num)
        {
            // Bad Code! But, To Confirm Test Converage.
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
