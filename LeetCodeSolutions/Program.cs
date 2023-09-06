using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeetCodeSolutions
{
    internal class Program
    {
        //E - easy M - medium H - hard
        static void Main(string[] args)
        {
            Program program = new Program();
            program.M3();
        }
        private void M1()
        {
            GroupAnagrams groupAnagrams = new GroupAnagrams();
            var result = groupAnagrams.GroupAnagramss(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        }
        private void M2()
        {
            TopKFrequientElements topKFrequientElements = new TopKFrequientElements();
            var result = topKFrequientElements.TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
            foreach (var element in result)
                Console.WriteLine(element);
           
        }
        private void M3()
        {
            NextGreaterElementI nextGreaterElementI = new NextGreaterElementI();
            var result = nextGreaterElementI.NextGreaterElement(new int[] { 4,1,2 }, new int[] {1,3,4,2});
            foreach (var element in result)
                Console.WriteLine(element);
        }

        private void E5()
            {
            RemoveDuplicatesFromSortedArray removeDuplicatesFromSortedArray = new RemoveDuplicatesFromSortedArray();
            int a = removeDuplicatesFromSortedArray.RemoveDuplicates(new int[] { 1, 1, 2, 3, 4 });
            Console.WriteLine(a);
            int[] nums = new int[] { 1, 1, 2, 3, 4 }; // Input array
            int[] expectedNums = new int[] { 1, 2, 3, 4 }; // The expected answer with correct length

            int z = removeDuplicatesFromSortedArray.RemoveDuplicates(nums); // Calls your implementation

            for (int i = 0; i < z; i++)
            {
                Console.WriteLine($"{nums[i]} {expectedNums[i]}");
                if (nums[i] == expectedNums[i])
                {
                    Console.WriteLine("good");
                }
                else
                {
                    Console.WriteLine("bad");
                }
            }
            }
        private void E6()
        {
            RemoveElement removeElement = new RemoveElement();
            int[] nums = new int[] { 1, 1, 2, 3 }; // Input array
            int val = 1; // Value to remove
            int[] expectedNums = new int[] { 2, 3 }; // The expected answer with correct length.
                                                     // It is sorted with no values equaling val.

            int k = removeElement.RemoveElements(nums, val); // Calls your implementation
            Console.WriteLine(k);
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine($"{nums[i]} {expectedNums[i]}");
                if (nums[i] == expectedNums[i])
                {
                    Console.WriteLine("good");
                }
                else
                {
                    Console.WriteLine("bad");
                }
            }
        }
        private void E7()
        {
            FindTheIndexOfTheFirstOccurrenceInAString findTheIndexOfTheFirstOccurrenceInAString = new FindTheIndexOfTheFirstOccurrenceInAString();
            findTheIndexOfTheFirstOccurrenceInAString.StrStr("re","adg");
        }
        private void E8()
        {
            SearchInsertPosition searchInsertPosition = new SearchInsertPosition();
            searchInsertPosition.SearchInsert(new int[] {1,3,5,6}, 2);
        }
        private void E9()
        {
            LengthOfLastWord lengthOfLastWord = new LengthOfLastWord();
            Console.WriteLine(lengthOfLastWord.LengthOfLastWords("day    "));
        }
        private void E10()
        {
            PlusOne plusOne = new PlusOne();
            int[] a = plusOne.PlusOnes(new int[] { 9,9,9,9,9 });
            for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        private void E11()
        {
            SqrtX sqrtX = new SqrtX();
            Console.WriteLine(sqrtX.MySqrt(9));
        }
        private void E12()
        {
            ClimbStairs climbStairs = new ClimbStairs();
            Console.WriteLine(climbStairs.ClimbStairss(15));
        }
        private void E13()
        {
            RemoveDublicatesFromSortedList removeDublicatesFromSortedList = new RemoveDublicatesFromSortedList();
            removeDublicatesFromSortedList.DeleteDuplicates(new ListNode(1));
        }
        private void E14()
        {
            MergeSortedArray mergeSortedArray = new MergeSortedArray();
            mergeSortedArray.Merge(new int[] {1,1,2,4,7,0,0}, 5, new int[] {1,2,9}, 3);
        }
        private void E15()
        {
            PascalsTriangle pascalsTriangle = new PascalsTriangle();
            pascalsTriangle.Generate(2);
        }
        private void E16()
        {
            PascalsTriangle pascalsTriangle = new PascalsTriangle();
            IList<int> a = pascalsTriangle.GetRow(3);
            a = a.ToArray();
            for(int i =0;i<a.Count;i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        private void E17()
        {
            BestTimeToBuyAndSellStock bestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();
            Console.WriteLine(bestTimeToBuyAndSellStock.MaxProfit(new int[] {5,3,6,2,4,1}));
        }
        private void E18()
        {
            ValidPalindrome validPalindrome = new ValidPalindrome();
            Console.WriteLine(validPalindrome.IsPalindrome("0P"));
        }
        private void E19()
        {
            SingleNumber singleNumber = new SingleNumber();
            Console.WriteLine(singleNumber.SingleNumbers(new int[] {1,4,1,5,4}));
        }
        private void E20()
        {
            ExcelSheetColumnTitle excelSheetColumnTitle = new ExcelSheetColumnTitle();
            Console.WriteLine(excelSheetColumnTitle.ConvertToTitle(189));
        }
        private void E21()
        {
            MajorityElement majority = new MajorityElement();
            majority.MajorityElements(new int[] {1,1,1,2,2,2,2});
        }
        private void E22()
        {
            ReversBits reversBits = new ReversBits();
            Console.WriteLine(reversBits.reverseBits(Convert.ToUInt32("11111111111111111111111111111101"))); 
        }
        private void E23()
        {
            ContainsDuplicate containsDuplicate = new ContainsDuplicate();
            Console.WriteLine(containsDuplicate.ContainsDuplicates(new int[] { 1, 2,3,3 }));
        }
        private void E24()
        {
            SummaryRanges summaryRanges = new SummaryRanges();
            var n = summaryRanges.SummaryRangess(new int[] { 0, 1, 2, 4, 5, 7 });
            foreach (string i in n)
            {
                Console.WriteLine(i);
            }
        }
        private void E25()
        {
            MissingNumber missingNumber = new MissingNumber();
            Console.WriteLine(missingNumber.MissingNumbers(new int[] { 0, 1, 3, 4 }));
        }
        private void E26()
        {
            MoveZeroes moveZeroes = new MoveZeroes();
            moveZeroes.MoveZeroess(new int[] {0,1,0,3,12});
        }
        private void E27()
        {
            NumArray numArray = new NumArray(new int[] {1,2,3,4,5});
            Console.WriteLine(numArray.SumRange(1,3));
        }
        private void E28()
        {
            IntersectOfTwoArrays intersectOfTwoArrays = new IntersectOfTwoArrays();
            intersectOfTwoArrays.Intersection(new int[] { 4, 9, 5 }, new int[] {9,4,9,8,4});
            //intersectOfTwoArrays.Intersection2(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
        }
        private void E29()
        {
            ThirdMaximumNumber thirdMaximumNumber = new ThirdMaximumNumber();
            Console.WriteLine(thirdMaximumNumber.ThirdMax(new int[] { 3, 2, 1 }));
        }
        private void E30()
        {
            FindAllNumbersDissapearedInAnArray findAllNumbersDissapearedInAnArray = new FindAllNumbersDissapearedInAnArray();
            Console.WriteLine(findAllNumbersDissapearedInAnArray.FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }));
        }
        private void E31()
        {
            MaxConsecutiveOnes maxConsecutiveOnes = new MaxConsecutiveOnes();
            Console.WriteLine(maxConsecutiveOnes.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 }));
        }
        private void E32()
        {
            TeemoAtacking teemoAtacking = new TeemoAtacking();
            Console.WriteLine(teemoAtacking.FindPoisonedDuration(new int[] {1,4}, 2));
        }
        private void E33()
        {
            ValidAnagram validAnagram = new ValidAnagram();
            Console.WriteLine(validAnagram.IsAnagram("anagram", "nagrama"));
        }
    }
    }

