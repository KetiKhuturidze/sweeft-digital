using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweeft
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************task 1************************/

            bool sPalindrome(string text)
            {
                int size = text.Length;
                char[] arr = text.ToCharArray();
                char[] arr1 = text.ToCharArray();
                Array.Reverse(arr1);
                for (int i = 0; i < size; i++)
                {
                    if (arr[i] == arr1[i])
                        continue;
                    else
                        return false;

                }
                return true;
            }
            bool ans = sPalindrome("rotator");
            if (ans == true)
                Console.WriteLine("palindrome");
            else
                Console.WriteLine("not a palindrome");




            /*********************task 3************************/
            
            int NotContains(int[] array)
            {
                Array.Sort(array);
                if (array[0] > 0)
                {
                    return array[0] - 1;
                }
                else
                    return -1;
            }

            int[] arrr = new int[] { 9, 5, 6, 0, 2, 55, 11, 254, 5, 23, 543, 9 };
            NotContains(arrr);
            int answ = NotContains(arrr);
            Console.Write(ans);




            /*********************task 5************************/

            int CountVariants(int stairCount)
            {
                if (stairCount == 0)
                {
                    return 1;
                }
                else if (stairCount < 0)
                    return 0;
                else
                    return CountVariants(stairCount - 1) + CountVariants(stairCount - 2);
            }

            Console.WriteLine(CountVariants(5));

        }




    }
}
