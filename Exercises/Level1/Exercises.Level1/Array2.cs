﻿using System;

namespace Exercises.Level1;

/// <summary>
/// Medium array problems at least one loop.
/// </summary>
public class Array2
{
    /// <summary>
    ///  Return the number of even ints in the given array. Note: the % "mod" operator computes
    ///  the remainder, e.g. 5 % 2 is 1.
    /// 
    /// countEvens([2, 1, 2, 3, 4]) → 3
    /// countEvens([2, 2, 0]) → 3
    /// countEvens([1, 3, 5]) → 0
    /// </summary>
    public int CountEvens(int[] nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                count++;
            }
        }

        return count;


    }

    /// <summary>
    /// Given an array length 1 or more of ints, return the difference between the largest and
    /// smallest values in the array. Note: the built-in Math.min(v1, v2) and Math.max(v1, v2)
    /// methods return the smaller or larger of two values.
    /// 
    /// bigDiff([10, 3, 5, 6]) → 7
    /// bigDiff([7, 2, 10, 9]) → 8
    /// bigDiff([2, 10, 7, 2]) → 8
    /// </summary>
    public int BigDiff(int[] nums)
    {

        int max = int.MinValue;
        int min = int.MaxValue;


        foreach (int num in nums)
        {
            min = Math.Min(num, min);
            max = Math.Max(num, max);
        }

        return max - min;

    }

    //for (int i = 0; i < nums.Length; i++)
    //if(nums[i] > max)
    //{
    //    max = nums[i];
    //}

    //if (nums[i] < min)
    //{
    //    min = nums[i];
    //}





    /// <summary>
    /// Return the "centered" average of an array of ints, which we'll say is the mean average of
    /// the values, except ignoring the largest and smallest values in the array. If there are
    /// multiple copies of the smallest value, ignore just one copy, and likewise for the largest
    /// value. Use int division to produce the final average. You may assume that the array is
    /// length 3 or more.
    /// 
    /// centeredAverage([1, 2, 3, 4, 100]) → 3
    /// centeredAverage([1, 1, 5, 5, 10, 8, 7]) → 5
    /// centeredAverage([-10, -4, -2, -4, -2, 0]) → -3
    /// </summary>
    public int CenteredAverage(int[] nums)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        int garums = nums.Length;

        foreach (int num in nums)
        {
            min = Math.Min(num, min);
            max = Math.Max(num, max);
            sum = num + sum;
        }

        int augsa = sum - max - min;
        int apaksa = garums - 2;

        return augsa / apaksa;



        throw new NotImplementedException();
    }

    /// <summary>
    /// Return the sum of the numbers in the array, returning 0 for an empty array. Except the
    /// number 13 is very unlucky, so it does not count and number that come immediately after
    /// a 13 also do not count.
    /// 
    /// sum13([1, 2, 2, 1]) → 6
    /// sum13([1, 1]) → 2
    /// sum13([1, 2, 2, 1, 13]) → 6
    /// </summary>
    public int Sum13(int[] nums)
    {

        int summa = 0;
        int max = int.MaxValue;
        int min = int.MinValue;

        for (int i = 0; i < nums.Length; i++)

            if (nums[i] % 13 == 0)
            {
                i++;
            }

            else if (nums[i] % 13 != 0)
            {
                summa = summa + nums[i];
            }

        return summa;


    }

    /// <summary>
    /// Return the sum of the numbers in the array, except ignore sections of numbers starting
    /// with a 6 and extending to the next 7 (every 6 will be followed by at least one 7). Return 0
    /// for no numbers.
    /// 
    /// sum67([1, 2, 2]) → 5
    /// sum67([1, 2, 2, 6, 99, 99, 7]) → 5
    /// sum67([1, 1, 6, 7, 2]) → 4
    /// </summary>
    public int Sum67(int[] nums)
    {


        int sum = 0;
        bool pieskaitam = true;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] != 6 && pieskaitam == true)

                sum = sum + nums[i];

            else if (nums[i] == 6)

                pieskaitam = false;
            else if (nums[i] == 7)
                pieskaitam = true;

        }


        return sum;

    }

    /// <summary>
    /// Given an array of ints, return true if the array contains a 2 next to a 2 somewhere.
    /// 
    /// has22([1, 2, 2]) → true
    /// has22([1, 2, 1, 2]) → false
    /// has22([2, 1, 2]) → false
    /// </summary>
    public bool Has22(int[] nums)
    {


        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == 2 && nums[i] == nums[i + 1])
            {
                return true;
            }

        }

        return false;


    }

    /// <summary>
    /// Given an array of ints, return true if the array contains no 1's and no 3's.
    /// 
    /// lucky13([0, 2, 4]) → true
    /// lucky13([1, 2, 3]) → false
    /// lucky13([1, 2, 4]) → false
    /// </summary>
    public bool Lucky13(int[] nums)
    {


        foreach (var num in nums)
        {
            if (num == 3 || num == 1)
            {
                return false;

            }
        }


        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] == 3 || nums[i] == 1)
        //    {
        //        return false;

        //    }
        //}
        return true;
    }

    /// <summary>
    /// Given an array of ints, return true if the sum of all the 2's in the array is exactly 8.
    /// 
    /// sum28([2, 3, 2, 2, 4, 2]) → true
    /// sum28([2, 3, 2, 2, 4, 2, 2]) → false
    /// sum28([1, 2, 3, 4]) → false
    /// </summary>
    public bool Sum28(int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 2)
            {
                sum = sum + nums[i];

            }

        }
        if (sum == 8)
            return true;
        return false;

    }

    /// <summary>
    /// Given an array of ints, return true if the number of 1's is greater than the number of 4's
    /// 
    /// more14([1, 4, 1]) → true
    /// more14([1, 4, 1, 4]) → false
    /// more14([1, 1]) → true
    /// </summary>
    public bool More14(int[] nums)
    {
        int sumofOnes = 0;
        int sumOfFores = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] == 1)
            {
                sumofOnes++;
            }
            else if (nums[i] == 4)
            {
                sumOfFores++;
            }


        }

        if (sumofOnes == sumOfFores)
        {
            return false;
        }

        if (sumofOnes > sumOfFores)
        {
            return true;
        }


        return false;



    }

    /// <summary>
    /// Given a number n, create and return a new int array of length n, containing the numbers
    /// 0, 1, 2, ... n-1. The given n may be 0, in which case just return a length 0 array. You do
    /// not need a separate if-statement for the length-0 case; the for-loop should naturally
    /// execute 0 times in that case, so it just works.
    /// 
    /// fizzArray(4) → [0, 1, 2, 3]
    /// fizzArray(1) → [0]
    /// fizzArray(10) → [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
    /// </summary>
    public int[] FizzArray(int n)
    {

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }
        return array;




        throw new NotImplementedException();
    }

    /// <summary>
    /// Given an array of ints, return true if every element is a 1 or a 4.
    /// 
    /// only14([1, 4, 1, 4]) → true
    /// only14([1, 4, 2, 4]) → false
    /// only14([1, 1]) → true
    /// </summary>
    public bool Only14(int[] nums)
    {

        //foreach (int num in nums)
        //{
        //    if (num < 1 || num > 1 || num < 4 || num > 4)
        //    {
        //        return false;


        //    }
        //    //else return true;
        //}

        //foreach (int num in nums)
        //{
        //    if (num != 1 && num != 4)
        //    {
        //        return false;
        //    }
        //    else return true;
        //}

        for (int i = 0; i < nums.Length; i++)

            if (nums[i] != 1 && nums[i] != 4)
            {
                return false;
            }

        return true;
    }

    /// <summary>
    /// Given a number n, create and return a new string array of length n, containing the strings
    /// "0", "1" "2" .. through n-1. N may be 0, in which case just return a length 0 array. Note:
    /// String.valueOf(xxx) will make the String form of most types.
    /// 
    /// fizzArray2(4) → ["0", "1", "2", "3"]
    /// fizzArray2(10) → ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]
    /// fizzArray2(2) → ["0", "1"]
    /// </summary>
    public string[] FizzArray2(int nums)
    {


        int[] array = new int[nums];
        string[] array2 = new string[nums];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i;
        }


        for (int i = 0; i < array.Length; i++)
        {
            array2[i] = array[i].ToString();
        }

        return array2;

    }

    /// <summary>
    /// Given an array of ints, return true if it contains no 1's or it contains no 4's.
    /// 
    /// no14([1, 2, 3]) → true
    /// no14([1, 2, 3, 4]) → false
    /// no14([2, 3, 4]) → true
    /// </summary>
    public bool No14(int[] nums)
    {
        bool vaisatur1 = false;
        bool vaisatur4 = false;

        if (nums == null || nums.Length <= 1)
        {
            return true;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                vaisatur1 = true;
            }

            if (nums[i] == 4)
            { vaisatur4 = true; }

        }

        if ((vaisatur1 && !vaisatur4) || (!vaisatur1 && vaisatur4))
        {
            return true;
        }

        //if (vaisatur1 && vaisatur4)
        //{
        //    return false;
        //}


        return false;
    }




    /// <summary>
    /// We'll say that a value is "everywhere" in an array if for every pair of adjacent elements in
    /// the array, at least one of the pair is that value. Return true if the given value is everywhere
    /// in the array.
    /// 
    /// isEverywhere([1, 2, 1, 3], 1) → true
    /// isEverywhere([1, 2, 1, 3], 2) → false
    /// isEverywhere([1, 2, 1, 3, 4], 1) → false
    /// </summary>
    public bool IsEverywhere(int[] nums, int val)
    {
        if (nums.Length <= 1)
        {
            return true;
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != val && nums[i + 1] != val)
                return false;

        }

        //if (nums[i] == val || nums[i + 1] == val) // nav pareizs
        //    return true;



        return true;
    }

    /// <summary>
    /// Given an array of ints, return true if the array contains a 2 next to a 2 or a 4 next to a 4,
    /// but not both.
    /// 
    /// either24([1, 2, 2]) → true
    /// either24([4, 4, 1]) → true
    /// either24([4, 4, 1, 2, 2]) → false
    /// </summary>
    public bool Either24(int[] nums)
    {

        bool vaiIr22 = false;
        bool vaiir44 = false;

        for (int i = 0; i < nums.Length - 1; i++)
        {

            if (nums[i] == 2 && nums[i + 1] == 2)
            {
                vaiIr22 = true;

            }
            if (nums[i] == 4 && nums[i + 1] == 4)
            {
                vaiir44 = true;

            }


        }

        if (vaiIr22 && vaiir44)
        {
            return false;
        }

        if (vaiIr22 || vaiir44)
        {
            return true;
        }


        return false;


    }

    /// <summary>
    /// Given arrays nums1 and nums2 of the same length, for every element in nums1, consider
    /// the corresponding element in nums2 (at the same index). Return the count of the number
    /// of times that the two elements differ by 2 or less, but are not equal.
    /// 
    /// matchUp([1, 2, 3], [2, 3, 10]) → 2
    /// matchUp([1, 2, 3], [2, 3, 5]) → 3
    /// matchUp([1, 2, 3], [2, 3, 3]) → 2
    /// </summary>
    public int MatchUp(int[] nums1, int[] nums2)
    {

        int sum = 0;

        for (int i = 0; i < nums1.Length; i++)

        {
            if (nums1[i] == nums2[i])
            {
                continue;

            }

            if (Math.Abs(nums1[i] - nums2[i]) <= 2)
            {
                sum++;
            }

        }
        return sum;



    }

    /// <summary>
    /// Given an array of ints, return true if the array contains two 7's next to each other, or there
    /// are two 7's separated by one element, such as with {7, 1, 7}.
    /// 
    /// has77([1, 7, 7]) → true
    /// has77([1, 7, 1, 7]) → true
    /// has77([1, 7, 1, 1, 7]) → false
    /// </summary>
    public bool Has77(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1] && nums[i] == 7)
            {
                return true;
            }
        }

        for (int i = 0; i < nums.Length - 2; i++)
            if (nums[i] == nums[i + 2] && nums[i] == 7)
            {
                return true;
            }

        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if there is a 1 in the array with a 2 somewhere later in
    /// the array.
    /// 
    /// has12([1, 3, 2]) → true
    /// has12([3, 1, 2]) → true
    /// has12([3, 1, 4, 5, 2]) → true
    /// </summary>
    public bool Has12(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)

        {
            if (nums[i] == 1)

            {

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == 2)
                    {
                        return true;
                    }
                }

            }


        }


        return false;


    }

    /// <summary>
    /// Given an array of ints, return true if the array contains either 3 even or 3 odd values all
    /// next to each other.
    /// 
    /// modThree([2, 1, 3, 5]) → true
    /// modThree([2, 1, 2, 5]) → false
    /// modThree([2, 4, 2, 5]) → true
    /// </summary>
    public bool ModThree(int[] nums)
    {


        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] % 2 == 0 && nums[i + 1] % 2 == 0 && nums[i + 2] % 2 == 0)
            {
                return true;
            }
        }
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (nums[i] % 2 == 1 && nums[i + 1] % 2 == 1 && nums[i + 2] % 2 == 1)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// Given an array of ints, return true if the value 3 appears in the array exactly 3 times, and
    /// no 3's are next to each other.
    /// 
    /// haveThree([3, 1, 3, 1, 3]) → true
    /// haveThree([3, 1, 3, 3]) → false
    /// haveThree([3, 4, 3, 3, 4]) → false
    /// </summary>
    public bool HaveThree(int[] nums)
    {

        int trisskaits = 0;
        bool irblakus = false;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 3)
            {
                trisskaits++;
            }
        }

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == 3 && nums[i + 1] == 3)
            {
                irblakus = true;
            }
        }

        if (trisskaits == 3 && !irblakus)
        {
            return true;
        }

        return false;

    }

    /// <summary>
    /// Given an array of ints, return true if every 2 that appears in the array is next to another 2.
    /// 
    /// twoTwo([4, 2, 2, 3]) → true
    /// twoTwo([2, 2, 4]) → true
    /// twoTwo([2, 2, 4, 2]) → false
    /// </summary>
    public bool TwoTwo(int[] nums)
    {

        if (nums.Length < 2)
        {
            return false;
        }

        if (nums.Length < 2)
        {
            return false;
        }


        if (nums[nums.Length - 2] !=2 && nums[nums.Length -1] ==2)
            {
            return false;
            }

        for (int i = 1; i < nums.Length-1; i++)
        {

            if (nums[i] == 2 && nums[i + 1] != 2 && nums[i-1] !=2)
                return false;

        }


        return true;





        //for (int i = 0; i < nums.Length-2; i++)

        //     if (nums[i] == 2)
        //     {
        //        i =i+2;

        //        if (nums[i-1]!=2 )
        //        {
        //            if (nums[i - 1] == 2)
        //            {

        //                continue;
        //                i++;
        //                return true;
        //            }
        //                return false;
        //        }
        //        return false;
        //     }



        //for (int i = 0; i < nums.Length; i++)
        // if (nums[i]==2) // vajag ||
        //    {
        //        i++;
        //        if (i != 2)
        //        {
        //            i++;
        //            if (nums[i] == 2)
        //            {
        //                i++;
        //                if (nums[i-1]!=2 && nums[i]==2 && nums[i+1]!=2)
        //                {
        //                    return false;
        //                }
        //                return false;
        //            }
        //        }
        //        return false;
        //    }








        //if (nums.Length < 2)
        //{
        //    return false;
        //}

        //for (int i = 0; i < nums.Length; i++)

        //    //if (nums.Length == 2 && nums[i] != 2)
        //    //{
        //    //    return false;
        //    //}

        //    if (nums[i]==2)
        //    {
        //        i++;
        //        if (nums[i]==2)
        //        {
        //            i++;
        //            if(nums[i]!=2)
        //            {
        //                i++;
        //                if (nums[i]==2)
        //                {
        //                    i++; // varbūt kaut kad jākāpjas atpakaļ i--;
        //                    if (nums[i] == 2)
        //                    {
        //                        i++;
        //                        if (nums[i] != 2)
        //                        {
        //                            i++;
        //                            if (nums[i]==2)
        //                            {
        //                                return false;
        //                            }
        //                            return true;
        //                        }
        //                            return true;
        //                    }
        //                    return false;
        //                }
        //                return true;
        //            }
        //            return true;
        //        }
        //        return false;

        //    }




        //if (nums.Length < 2)
        //{
        //    return false;
        //}


        //for (int i = 1; i < nums.Length; i++)
        //{

        //    if (nums.Length == 2 && nums[i - 1] != 2) 
        //    {
        //        return false;
        //    }

        //    if ((nums.Length > 2 && nums[i - 1] != 2 && nums[i] == 2 && nums[i - 1] != 2) || (nums.Length > 2 && nums[i - 1] != 2 && nums[i] != 2 && nums[i - 1] == 2)) // izdzēsu || (nums.Length > 2 && nums[i - 1] == 2 && nums[i] != 2 && nums[i - 1] == 2)
        //             { 
        //                if ((nums[i-1]==2 && nums[i]==2) || (nums[i + 1] == 2 && nums[i] == 2))
        //                 {

        //                    //if (nums.Length-1==2)
        //                    //{
        //                    // return false;
        //                    //}

        //                    //i++;
        //                    //if ((nums[i-1]==2 && nums[i]!=2 && nums[i+1]==2)|| (nums[i - 1] != 2 && nums[i] == 2 && nums[i + 1] != 2) || (nums[i - 1] != 2 && nums[i] != 2 && nums[i + 1] == 2))
        //                    // { 
        //                    // return false; 
        //                    //}
        //                  return true;
        //                 }


        //            return false; 
        //                }

        
    }

          
        
        
        
        
        
        //if (nums.Length == 2 && nums[i] = !2)
            //{
            //    return false;
            //}

            //else if ((nums.Length > 2 && nums[i - 1] != 2 && nums[i] == 2 && nums[i - 1] != 2) || (nums.Length > 2 && nums[i - 1] != 2 && nums[i] != 2 && nums[i - 1] == 2))
            //{
            //    return false;
            //}



            //return true;











            //for (int i = 0; i < nums.Length-1; i++) 
            //{
            //    if ((nums[i] != 2 && nums[i + 1] == 2) || (nums[i] == 2 && nums[i + 1] == 2) || (nums[i] == 2 && nums[i + 1] != 2)) // ŠĪ KONSTRUKCIJA NODROŠINA 1,3,4, testa izpildi
            //    {
            //        if ((nums[i] == 2 && nums[i + 1] != 2 && nums.Length == i+2 )|| (nums[i]!=2 && nums[i+1]==2 &&  nums.Length==i+2)) // izņēmu ārā (nums[i] != 2 && nums[i + 1] == 2 && nums.Length == i+2) ||
            //        {
            //            return false;
            //            }
            //        else if ((nums[i] != 2 && nums[i + 1] == 2) || (nums[i] == 2 && nums[i + 1] == 2)) 
            //        {
            //             i++;
            //        }
            //            //if (nums.Length-1==nums.Length && nums.Length==i+2)


            //            if ((nums[i] == 2 && nums[i+i] != 2) || (nums[i-1] == 2 && nums[i] == 2 && nums[i + i] != 2))
            //                //{
            //                //    if (i <= nums.Length) // varbūt jānoņem = vai jāieliek -1
            //                     {
            //                         return false;
            //                     }

            //            else if ((nums[i] == 2 && nums[i+1] == 2) || (nums[i] == 2 && nums[i - 1] == 2)) // ŠIS IR LIEKS PAŠLAIK NEKO NEDOD
            //        {
            //            return true;
            //        }
            //}

            ///*return true; /*// šo ieliku un neizpildās 4,5,6 tests
            //if (nums[i] == 2 && nums[i + 1] != 2)
            //{
            //    if (i >= nums.Length)
            //    {
            //        return false;

            //    }
            //    else i++;
            //    if (nums[i - 1] == 2 && nums[i] != 2 && nums[i + 1] != 2)
            //    {
            //        if (i >= nums.Length)
            //        {
            //            return false;

            //        }
            //        else i++;
            //        Console.WriteLine("IR FALSE");
            //        if (nums[i - 1] != 2 && nums[i] == 2)
            //            if (i >= nums.Length)
            //            {
            //                return false;

            //            }
            //            else i++;
            //        if (nums[i - 1] != 2 && nums[i] == 2 && nums[i + 1] != 2)
            //        {
            //            return false;
            //        }


            //    }
            //    // true
            //}


            //if (nums[i - 1] == 2 && nums[i] == 2 && nums[i + 1] == 2)
            //{
            //    i++;
            //    Console.WriteLine(i + "pēc palielinasanas");
            //}


            //Console.WriteLine(nums + "@@@");
            //    } // so ne
            //    //else if (nums[i] == 2 && nums[i + 1] == 2)
            //    //{

            //    //}
            //}

            //return true;
            
        //if (nums.Length < 2)
        //    return false;


        //for (int i = 0; i < nums.Length - 1; i++)
        //    if (nums[i] == 2 && nums[i + 1] == 2) // ja abi būs 2 tad turpinās
        //    {
        //        i++;

        //    }
        //    if (nums[i] == 2 && nums[i + 1] != 2)
        //    {
        //        if (i >= nums.Length)
        //        {
        //            return false;

        //        }
        //        else i++;
        //        if (nums[i - 1] == 2 && nums[i] != 2 && nums[i + 1] != 2)
        //        {
        //            if (i >= nums.Length)
        //            {
        //                return false;

        //            }
        //            else i++;

        //            if (nums[i - 1] != 2 && nums[i] == 2)
        //                if (i >= nums.Length)
        //                {
        //                    return false;

        //                }
        //                else i++;
        //            if (nums[i - 1] != 2 && nums[i] == 2 && nums[i + 1] != 2)
        //            {
        //                return false;
        //            }


        //        }

        //    }




        //for (int i = 0; i < nums.Length - 1; i++)
        //{
        //    if (nums[i]!=2 && nums[i+1]!=2) // ja abi būs 2 tad turpinās
        //    {
        //        i++

        //        if (nums[i-1] != 2 && nums[i] != 2 && nums[i + 1] != 2)
        //        {

        //        }


        //        return false;
        //    }
        //    else if (nums[i]==2 && nums[i + 1] == 2)
        //    {

        //    }
        //}



        //    //    for (int i = 1; i < nums.Length - 1; i++)
        //    //    {
        //    //        if ((nums[i - 1] != 2 && nums[i] == 2 && nums[i + 1] != 2) || nums[i] != 2 && nums[i + 1] == 2))
        //    //        {
        //    //        if ((nums[i - 1] == 2 && nums[i] == 2) || (nums[i + 1] == 2 && nums[i] == 2))
        //    //        {
        //    //            return true;
        //    //        }
        //    //        return false;
        //    //    }

        //    //}
        //if (nums.Length < 2)
        //{ return false; }

        ////if (nums[0] == 2 && nums[1] == 2)
        ////    return true;


        //for (int i = 1; i < nums.Length-1; i++)
        //{
        //    if (nums[i]==2 && nums[i+1]==2)
        //    {
        //        continue;
        //        {
        //            if ( nums[i - 1] == 2 && nums[i] == 2) //nums[i + 1] == 2 &&
        //            {
        //                continue;
        //                { 


        //                    if ((nums[i - 1] != 2 && nums[i] == 2 && nums[i + 1] != 2) || (nums[i-1] != 2 && nums[nums.Length] ==2)) //nums[i] = nums.Length-1 && 
        //                    {
        //                     return false;

        //                    }
        //                }


        //            }return true;
        //        }





        //    }return true;

        //    //if (nums.Length>2 && nums[i-1] !=2 && nums[i]==2 && nums[i+1] !=2)
        //    //{
        //    //    if (nums[0] != 2 && nums[1] == 2)
        //    //    return false; 
        //    //}
        //    //else if (nums.Length <= 2 && nums[0] != 2 && nums[1] == 2)
        //    //{
        //    //    return false;
        //    //}

        //}
        //if(nums.Length <2)
        //        {
        //            return false;
        //        }



        //int pozicijaKursakas2 = 0;
        //int pozicijaKurBeidzas2 = 0;
        //bool visparnav2 = false;  // 1;3;4 jābūt false bet testos True
        //bool vaiirVismaz22 = false;
        //bool vaiVelir2 = false;


        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i]==2)
        //    {
        //        pozicijaKursakas2 = i;
        //        pozicijaKurBeidzas2 = i;
        //        break;
        //    }
        //    if (nums[i]!=2)
        //    {
        //        visparnav2 = true;
        //    }
        //}

        //for (int j = pozicijaKursakas2+1; j < nums.Length; j++)
        //{
        //    if (nums[j] == 2)
        //    {
        //        pozicijaKurBeidzas2++;
        //        vaiirVismaz22 = true;
        //        continue;
        //    }
        //    else if (nums[j] != 2);
        //    {
        //        break;
        //    }

        //}

        //for (int p = pozicijaKurBeidzas2+1; p < nums.Length; p++)
        //{

        //    if (nums[p]==2)
        //    {
        //        vaiVelir2 = true;
        //    }

        //}




        //if (vaiVelir2)
        //{
        //    return false;
        //}

        //if (vaiirVismaz22 && !vaiVelir2)
        //{
    //    return true;
    //}









    /// <summary>
    /// Return true if the group of N numbers at the start and end of the array are the same. For
    /// example, with {5, 6, 45, 99, 13, 5, 6}, the ends are the same for n=0 and n=2, and false
    /// for n=1 and n=3. You may assume that n is in the range 0..nums.length inclusive.
    /// 
    /// sameEnds([5, 6, 45, 99, 13, 5, 6], 1) → false
    /// sameEnds([5, 6, 45, 99, 13, 5, 6], 2) → true
    /// sameEnds([5, 6, 45, 99, 13, 5, 6], 3) → false
    /// </summary>
    public bool SameEnds(int[] nums, int val)
    {

       if (val < 1)
        { return true; }

        for (int i = 0; i <nums.Length ; i--) 
        {

            if (nums[i] == nums[nums.Length - val])
            {
                return true;
                val--;
            }

            if (nums[i] != nums[nums.Length - val])
            {
                return false;               
            }

        }
        return false;
        
    }

    /// <summary>
    /// Return true if the array contains, somewhere, three increasing adjacent numbers like ....
    /// 4, 5, 6, ... or 23, 24, 25.
    /// 
    /// tripleUp([1, 4, 5, 6, 2]) → true
    /// tripleUp([1, 2, 3]) → true
    /// tripleUp([1, 2, 4]) → false
    /// </summary>
    public bool TripleUp(int[] nums)
    {
       if (nums.Length< 3)
        {
            return false ;
        }

        for (int i = 0; i < nums.Length-2; i++)
        {
            if ((nums[i] + 1 == nums[i + 1]) && (nums[i + 1] + 1 == nums[i + 2]))
            {
                return true;
            }
        }

        return false;

    }

    /// <summary>
    /// Given start and end numbers, return a new array containing the sequence of integers
    /// rom start up to but not including end, so start=5 and end=10 yields {5, 6, 7, 8, 9}. The
    /// end number will be greater or equal to the start number. Note that a length-0 array is
    /// valid.
    /// 
    /// fizzArray3(5, 10) → [5, 6, 7, 8, 9]
    /// fizzArray3(11, 18) → [11, 12, 13, 14, 15, 16, 17]
    /// fizzArray3(1, 3) → [1, 2]
    /// </summary>
    public int[] FizzArray3(int start, int end)
    {
        int [] nums = new int[end - start];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = start;
            start++;
        }

        return nums;
    }

    /// <summary>
    /// Return an array that is "left shifted" by one -- so {6, 2, 5, 3} returns {2, 5, 3, 6}. You
    /// may modify and return the given array, or return a new array.
    /// 
    /// shiftLeft([6, 2, 5, 3]) → [2, 5, 3, 6]
    /// shiftLeft([1, 2]) → [2, 1]
    /// shiftLeft([1]) → [1]
    /// </summary>
    public int[] ShiftLeft(int[] nums)
    {
        
        if (nums.Length < 1)
        {
            return nums;
        }
        int rezerve = nums[0];

        for (int i = 0; i < nums.Length - 1; i++)
        {

            nums[i] = nums[i + 1];

        }

        nums[nums.Length - 1] = rezerve;
                     

        return nums;
          
    }

    /// <summary>
    /// For each multiple of 10 in the given array, change all the values following it to be that
    /// multiple of 10, until encountering another multiple of 10. So {2, 10, 3, 4, 20, 5} yields {2,
    /// 10, 10, 10, 20, 20}.
    /// 
    /// tenRun([2, 10, 3, 4, 20, 5]) → [2, 10, 10, 10, 20, 20]
    /// tenRun([10, 1, 20, 2]) → [10, 10, 20, 20]
    /// tenRun([10, 1, 9, 20]) → [10, 10, 10, 20]
    /// </summary>
    public int[] TenRun(int[] nums)
    {

        // skatamies kad ir kāds skaitlis kurš ir 10

        // Kā atrast ka tas ir 10

        for (int i = 0; i < nums.Length-1; i++)
        {

            if(nums[i] %10 == 0 && nums[i+1] %10 !=0)
            {
                nums[i+1] = nums[i];
            }

        }

        return nums;
        
        
        
    }

    /// <summary>
    /// Given a non-empty array of ints, return a new array containing the elements from the
    /// original array that come before the first 4 in the original array. The original array will
    /// contain at least one 4. Note that it is possible to create an array of length 0.
    /// 
    /// pre4([1, 2, 4, 1]) → [1, 2]
    /// pre4([3, 1, 4]) → [3, 1]
    /// pre4([1, 4, 4]) → [1]
    /// </summary>
    public int[] Pre4(int[] nums)
    {


        int arrayGarums = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 4)
            {
                arrayGarums++;
            }

            if (nums[i] == 4)
            {
                break;
            }

        }

        int[] newArray = new int[arrayGarums];

        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = nums[i];
        }


        return newArray;


        // Kāds būs jaunā masīva garums?

        //tad jārada jauns masīvs

        // jāievoeto tur skaitļi ņemot vērā kā  i<nums1.length
        
        
    }

    /// <summary>
    /// Given a non-empty array of ints, return a new array containing the elements from the
    /// original array that come after the last 4 in the original array. The original array will contain
    /// at least one 4. Note that it is possible to create an array of length 0.
    /// 
    /// post4([2, 4, 1, 2]) → [1, 2]
    /// post4([4, 1, 4, 2]) → [2]
    /// post4([4, 4, 1, 2, 3]) → [1, 2, 3]
    /// </summary>
    public int[] Post4(int[] nums)
    {
        int arrayGarums = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[nums.Length - i] != 4)
            {

                arrayGarums++;
            }

            if (nums[nums.Length - i] == 4)
            {

                break;
            }
        }

        int[] newArray = new int[arrayGarums];


        for (int i = 1; i < newArray.Length + 1; i++)
        {

            newArray[newArray.Length - i] = nums[nums.Length - i];


        }


        return newArray;



        // skaitām no beigām līdz 4 kad 4 tad break
        // 
        // atrodam 4 poziciju un 

    }

    /// <summary>
    /// We'll say that an element in an array is "alone" if there are values before and after it, and
    /// those values are different from it. Return a version of the given array where every instance
    /// of the given value which is alone is replaced by whichever value to its left or right is larger.
    /// 
    /// notAlone([1, 2, 3], 2) → [1, 3, 3]
    /// notAlone([1, 2, 3, 2, 5, 2], 2) → [1, 3, 3, 5, 5, 2]
    /// notAlone([3, 4], 3) → [3, 4]
    /// </summary>
    public int[] NotAlone(int[] nums, int val)
    {
       
        if(nums.Length < 3)
        {
            return nums;
        }

        int lielakais = 0;

        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] == val && nums[i - 1] != nums[i] && nums[i + 1] != nums[i]) 
            {
                lielakais = Math.Max(nums[i - 1], nums[i + 1]);

                nums[i] = lielakais;

            }

        }

        return nums;

        // sākam meklēt ar to skaitli kuram ir kaimiņi
        // ja i != i-1 un i!= i+1
        // izvērtējam kurš no i-1 un i+1 ir lielāks
        // padaram i par to skaitli
        // nevar būt mazāk par 3 nums.length

    }

    /// <summary>
    /// Return an array that contains the exact same numbers as the given array, but rearranged
    /// so that all the zeros are grouped at the start of the array. The order of the non-zero
    /// numbers does not matter. So {1, 0, 0, 1} becomes {0 ,0, 1, 1}. You may modify and
    /// return the given array or make a new array.
    /// 
    /// zeroFront([1, 0, 0, 1]) → [0, 0, 1, 1]
    /// zeroFront([0, 1, 1, 0, 1]) → [0, 0, 1, 1, 1]
    /// zeroFront([1, 0]) → [0, 1]
    /// </summary>
    public int[] ZeroFront(int[] nums)
    {
        int[] newArray = new int[nums.Length];

        int pozicija = 1;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] != 0)
            {

                newArray[newArray.Length - pozicija] = nums[i];
                pozicija++;

            }

        }
        return newArray;
       
    }

    /// <summary>
    /// Return a version of the given array where all the 10's have been removed. The remaining
    /// elements should shift left towards the start of the array as needed, and the empty spaces
    /// a the end of the array should be 0. So {1, 10, 10, 2} yields {1, 2, 0, 0}. You may modify
    /// and return the given array or make a new array.
    /// 
    /// withoutTen([1, 10, 10, 2]) → [1, 2, 0, 0]
    /// withoutTen([10, 2, 10]) → [2, 0, 0]
    /// withoutTen([1, 99, 10]) → [1, 99, 0]
    /// </summary>
    public int[] WithoutTen(int[] nums)
    {

        int[] newArray = new int[nums.Length];

        int pozicija = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 10)
            {
                newArray[pozicija] = nums[i];
                pozicija++;
            }


        }
        return newArray;

        // cik vietās ir 10
        // jaunā masīva garums būs vecā masīva garums - 10 nieku skaits GARUMU NEVAJAG

        // ierakstām katru skaitli ja tas nav 10 ja 10 izlaižam TIAKI KA IZLAIŽAM AR COUNTIUE VAI I++?


       
    }

    /// <summary>
    /// Return a version of the given array where each zero value in the array is replaced by the
    /// largest odd value to the right of the zero in the array. If there is no odd value to the right
    /// of the zero, leave the zero as a zero.
    /// 
    /// zeroMax([0, 5, 0, 3]) → [5, 5, 3, 3]
    /// zeroMax([0, 4, 0, 3]) → [3, 4, 3, 3]
    /// zeroMax([0, 1, 0]) → [1, 1, 0]
    /// </summary>
    public int[] ZeroMax(int[] nums)
    {
        

        for (int i = 0; i < nums.Length-1; i++) 
        {
            if (nums[i]==0) 
            {
                int jaunsLielakais = 0;
                for (int j = i+1; j < nums.Length; j++)
                {
                    
                    if (nums[j]%2==1) 
                    {
                       
                        if (jaunsLielakais < nums[j])
                        {
                            jaunsLielakais = nums[j];
                        }                        
                    }                                  
                }
           
                if (jaunsLielakais>0)
                { nums[i] = jaunsLielakais; }            
            }
        }

        return nums;


        // Atrodam 0 

        // pēc nulles atrodam 

    }

    /// <summary>
    /// Return an array that contains the exact same numbers as the given array, but rearranged
    /// so that all the even numbers come before all the odd numbers. Other than that, the
    /// numbers can be in any order. You may modify and return the given array, or make a new
    /// array.
    /// 
    /// evenOdd([1, 0, 1, 0, 0, 1, 1]) → [0, 0, 0, 1, 1, 1, 1]
    /// evenOdd([3, 3, 2]) → [2, 3, 3]
    /// evenOdd([2, 2, 2]) → [2, 2, 2]
    /// </summary>
    public int[] EvenOdd(int[] nums)
    {

        int[] newArray = new int[nums.Length];

        int pozicija = 1;
        int pozicijaPara = 0;

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] % 2 ==  1)
            {

                newArray[newArray.Length - pozicija] = nums[i];
                pozicija++;

            }

            if (nums[i] % 2 == 0)
            {

                newArray[pozicijaPara] = nums[i];
                pozicijaPara++;

            }


        }
        return newArray;

        // izveidojam jaunu masīvu ar tādu pašu garumu kāds ir
        // atrodam pāraskaitli un liekam masīvā no kreisās puses 
        // atrodam nepāra un liekam jaunajā masīvā no kreisās puses

    }

    /// <summary>
    /// This is slightly more difficult version of the famous FizzBuzz problem which is sometimes
    /// given as a first problem for job interviews. Consider the series
    /// of numbers beginning at start and running up to but not including end, so for example
    /// start=1 and end=5 gives the series 1, 2, 3, 4. Return a new String[] array containing the
    /// string form of these numbers, except for multiples of 3, use "Fizz" instead of the number,
    /// for multiples of 5 use "Buzz", and for multiples of both 3 and 5 use "FizzBuzz".
    /// This version is a little more complicated than the usual version since you have to
    /// allocate and index into an arrayinstead of just printing, and we vary the start/end instead of just always doing 1..100.
    /// 
    /// fizzBuzz(1, 6) → ["1", "2", "Fizz", "4", "Buzz"]
    /// fizzBuzz(1, 8) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7"]
    /// fizzBuzz(1, 11) → ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz"]
    /// </summary>
    public string[] FizzBuzz(int start, int end)
    {

        int[] newArray = new int[end - start];
        string[] newArrayString = new string[end - start];

        for (int i = 0; start < end; i++)
        {
            newArray[i] = start;
            newArrayString[i] = start.ToString();
            start++;

        }


        for (int j = 0; j < newArrayString.Length; j++)
        {

            if (newArray[j] % 3 == 0 && newArray[j] % 5 == 0)
            {
                newArrayString[j] = "FizzBuzz";
            }

            if (newArray[j] % 3 == 0 && newArray[j] % 5 != 0)
            {
                newArrayString[j] = "Fizz";
            }

            if (newArray[j] % 5 == 0 && newArray[j] % 3 != 0)
            {
                newArrayString[j] = "Buzz";
            }

        }


        return newArrayString;


    }
}

