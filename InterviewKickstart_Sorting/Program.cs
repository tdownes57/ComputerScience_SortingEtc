﻿using System;
using static System.Console;  //Added 3/9/2020 td

namespace InterviewKickstart_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //
            //Encapsulated 3/9/2020 td
            //
            if (false) Test_SortingKArrays();

            //
            //Added 3/9/2020 td
            //
            Test_EvenAndOddNums(); 

        }

        static void Test_EvenAndOddNums()
        {
            //
            //Added 3/9/2020 
            //
            int[] array_input = new int[] { 1, 2, 3, 4, 5, 6 };

            EvenAndOddNums.solve(array_input);


        }


         static void Test_SortingKArrays()
         { 
            //
            //Encapsulated 3/9/2020 thomas downes
            //
            short shortMax = short.MaxValue;
            shortMax++;

            //
            // Added 3/9/2020 td
            //
            int[][] arraysForInput = new int[3][]
            {
                new int[6] {  1,  3, 5, 7, 12, 399  },
                new int[4] {  0,  2, 4, 6 },
                new int[9] { 6, 11, 22, 66, 166, 205, 400, 500, 600 }
            };

            Array.ForEach(arraysForInput[0], Console_WriteNumber);
            System.Console.WriteLine("  ");
            Array.ForEach(arraysForInput[1], Console_WriteNumber);
            System.Console.WriteLine("  ");
            Array.ForEach(arraysForInput[2], Console_WriteNumber);
            System.Console.WriteLine("  ");

            //
            // Added 3/9/2020 td
            //
            int[] array_result = 
            InterviewKickstart_Sorting.Program.mergeArrays(arraysForInput);


            System.Console.WriteLine("Result of merging:  ");  // + array_result.ToString());

            //array_result.ToList().ForEach(i => Console.WriteLine(i.ToString()));
            Array.ForEach(array_result, Console_WriteNumber);

            //ReadLine();  //Added 3/9/2020 td; 
            //ReadLine();
            System.Console.WriteLine("  ");
            System.Console.WriteLine("Thanks for playing!  ");
            System.Console.WriteLine("  ");
            System.Console.WriteLine("Press the Enter key to exit the program.");
            System.Console.WriteLine("  ");
            ReadLine();

        }

        static void Console_WriteNumber(int par_number)
        {
            //
            //Added 3/9/2010 thomas downes
            //
            Console.Write(par_number.ToString() + "   ");

        }



        /*
         * 
         * Merge_K_sorted_arrays

        Problem Statement:

        This is a popular facebook problem.

        Given K sorted arrays arr, of size N each, merge them into a new array res, such that res is a sorted array.


        Assume N is very large compared to K. N may not even be known. The arrays could be just sorted streams, for instance, timestamp streams.



        All arrays might be sorted in increasing manner or decreasing manner. Sort all of them in the manner they appear in input.



        Note:

        Repeats are allowed.
        Negative numbers and zeros are allowed.
        Assume all arrays are sorted in the same order. Preserve that sort order in output.
        It is possible to find out the sort order from at least one of the arrays.


        Input/Output Format For The Function:



        Input Format:



        There is only one argument: 2D Integer array arr.

        Here, arr[i][j] denotes value at index j of ith input array, 0-based indexing. So, arr is K * N size array.

        Output Format:

        Return an integer array res, containing all elements from all individual input arrays combined.

        Input/Output Format For The Custom Input:

        Input Format:

        The first line of input should contain an integer K. The second line should contain an integer N, denoting size of each input array.

        In next K lines, ith line should contain N space separated integers, denoting content of ith array of K input arrays, where jth element in this ith line is nothing but arr[i][j], i.e. value at index j of ith array, 0-based indexing.  

        If K = 3, N = 4 and arr = [

        [1, 3, 5, 7],

                    [2, 4, 6, 8],

                    [0, 9, 10, 11]

        ], then input should be:

        3
        4
        1 3 5 7
        2 4 6 8
        0 9 10 11

        Output Format:



        There will be (N*K) lines of output, where ith line contains an integer res[i], denoting value at index i of res.

        Here, res is the result array returned by solution function.



        For input K = 3, N = 4 and arr = [

        [1, 3, 5, 7],

                    [2, 4, 6, 8],

                    [0, 9, 10, 11]

        ], output will be:

        0
        1
        2
        3
        4
        5
        6
        7
        8
        9
        10
        11

        Constraints:

        1 <= N <= 500
        1 <= K <= 500
        -10^6 <= arr[i][j] <= 10^6, for all valid i,j

        Sample Test Case:

        Sample Input:   K = 3, N =  4

        arr[][] = { {1, 3, 5, 7},

                   {2, 4, 6, 8},

                   {0, 9, 10, 11}} ;

        Sample Output:

        [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]

        Note:   A solution which dumps all elements from all arrays into one massive heap, and then extracts the elements one by one into a sorted output may pass, but is not acceptable. These issues should go away when we have a more nuanced backend.

         * 
         * 
         * 
        * Complete the mergeArrays function below.
        * 
         */
        static int[] mergeArrays(int[][] arr)
        {
            /*
             *   Solution 3/9/2020 by Thomas Downes. 
             */
            int intCountItemsInAllArrays = 0;
            int intSection = 1; //Added 3/9/2020 td
            //int[] res = new int[intCountItemsInAllArrays];

            //
            //Check that all of the arrays have the same length. 
            //
            intSection = 10;
            for (short shArrayIndexI = 0; shArrayIndexI < arr.GetLength(0); shArrayIndexI++)
            {
                intSection = 11; 
                intCountItemsInAllArrays += arr[shArrayIndexI].Length;
            }
            intSection = 15;
            int[] res = new int[intCountItemsInAllArrays];
            int intCurrentResIndex = 0;

            //
            // Start the processing. 
            //
            try
            {
                //---Moved to top.----int intCountItemsInAllArrays = 0;

                //short shNumArraysK = (short)arr.GetLength(0);
                //short shNumItemsN = (short)arr.GetLength(1);

                intSection = 20; 
                short shNumArraysK = (short)arr.Length;  // This is the correct syntax for jagged arrays. 
                short shNumItemsN = (short)arr[0].Length;   //This is the correct syntax for jagged arrays.

                //
                //Check that all of the arrays have the same length. 
                //
                //---Moved to top.----for (short shArrayIndexI = 0; shArrayIndexI < arr.GetLength(0); shArrayIndexI++)
                //---Moved to top.----{
                //---Moved to top.----    intCountItemsInAllArrays += arr[shArrayIndexI].Length;
                //---Moved to top.----}

                //Check to see if the arrays have variable length. 
                bool bArraysAreJagged = (intCountItemsInAllArrays != (shNumArraysK * shNumItemsN));

                intSection = 21; 
                bool boolAscendingArrays = false; // Initialize.  (arr[0][0] < arr[0][shNumItemsN]);
                int intCurrentArrayLen = 0;  //Added 3/9/2020 td
                int intLastValueInArray = 0; //Added 3/9/2020 td

                intSection = 22;
                for (short shArrayIndexI = 0; shArrayIndexI < arr.GetLength(0); shArrayIndexI++)
                {
                    //Check all of the arrays, as some arrays might have equal values 
                    //  for all array items.    If one of the arrays is confirmed 
                    //  to be ascending, then (by the stated problem from Interview Kickstart) 
                    //  we are safe to conclude that they all are ascending.
                    //   -----3/9/2020 thomas downes
                    //
                    //boolAscendingArrays = (boolAscendingArrays ||
                    //    (arr[shArrayIndexI][0] < arr[shArrayIndexI][-1 + shNumItemsN]));

                    intSection = 23;
                    intCurrentArrayLen = arr[shArrayIndexI].Length;
                    intLastValueInArray = arr[shArrayIndexI][-1 + intCurrentArrayLen] ;

                    intSection = 24;
                    boolAscendingArrays = (boolAscendingArrays ||
                                             (arr[shArrayIndexI][0] < intLastValueInArray));

                    //We don't need to check every array.  
                    if (boolAscendingArrays) break;
                }

                intSection = 25;
                short[] pointerArrayIndexes = new short[shNumArraysK];
                bool[] bArrayIsExhausted = new bool[shNumArraysK];

                //Output. 
                //------int[] res = new int[shNumArraysK * shNumItemsN];
                //---Moved to top.----int[] res = new int[intCountItemsInAllArrays];

                //int intLastOutputMaxOrMin = -1; //  arr[0][0];
                //-----Moved up.---short shCurrentResIndex = 0;
                bool bKeepLooping = true;

                intSection = 26;
                int intProvisionalOutput_value = -1; // arr[0][0];
                short shProvisionalOutput_itemIndex = -1;
                short shProvisionalOutput_arrayIndex = -1;
                short shCurrentArray_Pointer = -1;
                bool bSmallerThanProvisional = false;
                bool bAllArraysHaveBeenExhausted = false;

                intSection = 27;
                do
                {
                    intSection = 28;
                    bAllArraysHaveBeenExhausted = true;  //Initialize to True. 
                    bool bFirstUnexhaustedArrayBeingChecked = true;

                    intSection = 29;
                    for (short shArrayIndexI = 0; shArrayIndexI <= -1 + shNumArraysK; shArrayIndexI++)
                    {
                        //
                        // Let's review what we can "pull" from Array #I.  
                        //
                        int intArrayCurrentValue;

                        intSection = 35;
                        shCurrentArray_Pointer = pointerArrayIndexes[shArrayIndexI];
                        //bArrayIsExhausted[shArrayIndexI] = (shCurrentArray_Pointer > -1 + shNumItemsN);
                        bArrayIsExhausted[shArrayIndexI] = (shCurrentArray_Pointer > -1 + arr[shArrayIndexI].Length);

                        if (bArrayIsExhausted[shArrayIndexI]) continue;

                        intSection = 40;
                        bAllArraysHaveBeenExhausted = false;  //The default of True is ___NOT___ the valid truth.  
                        intArrayCurrentValue = arr[shArrayIndexI][shCurrentArray_Pointer];

                        intSection = 45;
                        if (bFirstUnexhaustedArrayBeingChecked) //(shArrayIndexI == 0)
                        {
                            //
                            // We have to initialize the "Provisional" variables. 
                            //
                            intSection = 50;
                            intProvisionalOutput_value = intArrayCurrentValue;
                            shProvisionalOutput_itemIndex = pointerArrayIndexes[shArrayIndexI];
                            shProvisionalOutput_arrayIndex = shArrayIndexI;
                        }
                        else
                        {
                            //
                            // We have to compare the provisional integer value (vs. short values)
                            //   to the current array value.
                            //
                            // The variable name bSmaller... is for comprehension purposes, the 
                            //    variaable is named as if we know all the arrays are in 
                            //    ascending order (1, 234, 2399, etc.).   Howver, the 
                            //    expression on the right-hand side does not make that
                            //    assumption (see use of var. boolAscendingArrays).
                            //   ----3/9/2020 thomas downes
                            //
                            intSection = 55;
                            bSmallerThanProvisional = (boolAscendingArrays ? (intArrayCurrentValue < intProvisionalOutput_value) :
                                                                             (intArrayCurrentValue > intProvisionalOutput_value));
                            if (bSmallerThanProvisional)
                            {
                                intProvisionalOutput_value = intArrayCurrentValue;
                                shProvisionalOutput_itemIndex = shCurrentArray_Pointer;
                                shProvisionalOutput_arrayIndex = shArrayIndexI;
                            }

                        }

                        //
                        //Prepare for the next iteration of the For-Next loop. 
                        //
                        bFirstUnexhaustedArrayBeingChecked = false; //In the 2nd & subsequent iterations, ... 
                                                                    //  ... this Boolean should be false.  


                    }

                    //Moved here from below. ----3/9/2020 thomas d. 
                    intSection = 60;
                    bKeepLooping = (false == bAllArraysHaveBeenExhausted);
                    if (false == bKeepLooping) break;

                    //
                    //  We have our next output value, and we know where it came from !!
                    //
                    intSection = 65;
                    res[intCurrentResIndex] = intProvisionalOutput_value;

                    //Indicate that we have made progress in populating the output array.  
                    intCurrentResIndex++;

                    //Indicate that we have pulled a value from one of the arrays. 
                    //   (This is the first time I've used the ++ operator on an 
                    //   array item.   It should work okay.)
                    //
                    intSection = 70;
                    pointerArrayIndexes[shProvisionalOutput_arrayIndex]++;

                    //for (int intArrayIndexKL = 0; intArrayIndexKL < )
                    //bKeepLooping = 
                    //Moved above.  3.9.2020 td //bKeepLooping = (false == bAllArraysHaveBeenExhausted);

                } while (bKeepLooping);

            }
            catch (System.IndexOutOfRangeException ex_range)
            {
                //Added 3/9/2020 thomas d. 
                //throw new Exception("We don't know what happened!! " + ex_range.Message);
                throw new Exception("Section " +
                    intSection.ToString() + "   Var. intCountItemsInAllArrays = " +
                    intCountItemsInAllArrays.ToString() + "   Var. shCurrentResIndex = " +
                    intCurrentResIndex.ToString() + "....");
            }

            return res;

            //int[] res = new int[intCountItemsInAllArrays];
            //short shCurrentResIndex = 0;

        }


    }
}
