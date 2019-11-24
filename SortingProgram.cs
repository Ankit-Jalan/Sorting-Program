using System;
namespace SortingValue
{   
    /// <summary>
    /// Program is sorting some range of values into 
    /// ascending and descending which is provided by user. 
    /// </summary>
    class SortingProgram 
    {

        /// <summary>
        /// Entered values is sorted in SortValue method.
        /// </summary>
        /// <param name="uValue">Value array.</param>
        /// <returns>Sorted array.</returns>
        private float[] SortValue(float[] uValue)
        {   
            float tmp;
            // This is a Bubble Sort algorithm which sort values by repeatedly swapping the adjacent elements if they are in wrong order.
            for (int i = 0; i < uValue.Length; i++) 
            {
                for (int j = i; j < uValue.Length; j++)
                {
                    // Here first of all lowest value get sorted.
                    if (uValue[i] > uValue[j]) // Here first of all lowest value get sorted.
                    {
                        tmp = uValue[i];
                        uValue[i] = uValue[j];
                        uValue[j] = tmp;
                    }
                }
            }
            return uValue;
        }
        
        /// <summary>
        /// Method sorts user values.
        /// </summary>
        /// <param name="uValue">Value array.</param>
        /// <param name="order">Order is enumeration type variable Which provides order of sorting.</param>
        /// <returns>Sorted array.</returns>
        private float[] SortValue(float[] uValue,OrderType order)
        {
            if (order == OrderType.Descending)
            {
                float tmp;
                // This is a Bubble Sort algorithm which sort values by repeatedly swapping the adjacent elements if they are in wrong order.
                for (int i = 0; i < uValue.Length; i++)
                {
                    for (int j = i; j < uValue.Length; j++)
                    {
                        // Here first of all largest value get sorted.
                        if (uValue[i] < uValue[j])
                        {
                            tmp = uValue[i];
                            uValue[i] = uValue[j];
                            uValue[j] = tmp;
                        }
                    }
                }                
            }
            else
            {
                uValue = SortValue(uValue);
            }
            return uValue;
        }
     
        /// <summary>
        /// Get values for Sorting. 
        /// If there is any Exception occurs at runtime
        /// user needed to enter value again.
        /// </summary>
        /// <param name="range">This parameter contains  no of value user wants to sort. </param>
        private float[] GetValue(int range)
        {
            float[] uValue = new float[range];
            bool check;
            Console.WriteLine(ConstantValues.NewlineTab + ConstantValues.Desh + ConstantValues.ValueRequest + ConstantValues.Desh, range);
            for (int i = 0; i < range; i++)
            {
                Console.Write(ConstantValues.Tab);
                //Getting values
                check = float.TryParse(Console.ReadLine(), out uValue[i]);             
                if (check == true)
                {
                    //Value Accepted
                    if (uValue[i] < ConstantValues.ValueLimit && uValue[i] > -ConstantValues.ValueLimit)
                    { }
                    //Needed to enter value again.
                    else
                    {
                        Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.ValueUnfeasible + ConstantValues.Desh, ConstantValues.ValueLimit);
                        i--;
                    }
                }                
                //Needed to enter value again.
                else
                {
                    Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.ValueIncorrect + ConstantValues.Desh);
                    i--;
                }      
            }
            return uValue;
        }             
         
        /// <summary>
        /// Method prints arranged values.
        /// </summary>
        /// <param name="uValue">Array of values</param>
        private void PrintValue(float[] uValue)
        {            
            for (int i = 0; i < uValue.Length; i++)
            {
                Console.WriteLine(ConstantValues.Tab + uValue[i]);
            }
        }

        /// <summary>
        /// Method is taking vlaue of range.
        /// </summary>
        /// <param name="range">Range of values</param>
        private void GetRange(ref int range)
        {
            bool check = true;
            while (true)
            {
                Console.Write(ConstantValues.NewlineTab + ConstantValues.Desh + ConstantValues.RangeRequest + ConstantValues.Desh + ConstantValues.NewlineTab);
                //Getting no of values user wants to sort.
                check = int.TryParse(Console.ReadLine(), out range);
                if (range <= ConstantValues.UpperLimitRange && range >= ConstantValues.LoweLimitRange)
                {
                    break;
                }
                else if (check == false)
                {
                    Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.RangeIncorrect + ConstantValues.Desh);
                }
                else
                {
                    Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.RangeUnfeasible + ConstantValues.Desh, ConstantValues.LoweLimitRange, ConstantValues.UpperLimitRange);
                }
            }                        
        }

        /// <summary>
        /// This is a main method.
        /// </summary>
        static void Main(string[] args)
        {   
            SortingProgram objSortingProgram = new SortingProgram(); 
            int optionValue;            
            string runAgain = null;
            int range = 0;
            float[] uValue = { };
            while (runAgain!=ConstantValues.Quit)
            {
                try
                {  
                    Console.Write(ConstantValues.MenuStatement,ConstantValues.CreateList,ConstantValues.Ascending,ConstantValues.Descending,ConstantValues.EnterDataList,ConstantValues.Exit);
                    while (true)
                    {
                        bool check = int.TryParse(Console.ReadLine(), out optionValue);
                        // When value is accepted
                        if (optionValue <= ConstantValues.UpperLimitOption && optionValue >= ConstantValues.LowerLimitOption)
                        {
                            break;
                        }
                        // Needed to enter again
                        else if (check == false)
                        {
                            Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.OptionIncorrect + ConstantValues.Desh);
                        }
                        // Needed to enter again
                        else
                        {
                            Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.OptionIncorrect + ConstantValues.Desh, ConstantValues.LowerLimitOption, ConstantValues.UpperLimitOption);
                        }
                    }                    
                    switch (optionValue)
                    {
                        // Create new List with different range.
                        case ConstantValues.CreateList:
                            Console.Clear(); 
                            objSortingProgram.GetRange(ref range);                            
                            uValue = objSortingProgram.GetValue(range);
                            Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.DataList + ConstantValues.Desh);
                            objSortingProgram.PrintValue(uValue);
                            break;
                        // Arrange values in Ascending order.
                        case ConstantValues.Ascending:
                            Console.Clear();
                            // If the range is Provided by the user than only it allows to enter
                            if (range >= ConstantValues.LoweLimitRange)
                            {
                                uValue = objSortingProgram.SortValue(uValue);
                                Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.AscendOrder + ConstantValues.Desh);
                                objSortingProgram.PrintValue(uValue);
                            }
                            else
                            {
                                Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.CreateListStatement + ConstantValues.Desh);
                            }                            
                            break;
                        // Arrange values in Descending order.
                        case ConstantValues.Descending:
                            Console.Clear();
                            // If the range is Provided by the user than only it allows to enter.
                            if (range >= ConstantValues.LoweLimitRange)
                            {
                                uValue = objSortingProgram.SortValue(uValue, OrderType.Descending);
                                Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.DescendOrder + ConstantValues.Desh);
                                objSortingProgram.PrintValue(uValue);
                            }
                            else
                            {
                                Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.CreateListStatement + ConstantValues.Desh);
                            }                            
                            break;
                        // Take data list again with same range.
                        case ConstantValues.EnterDataList:
                            Console.Clear();
                            // If the range is Provided by the user than only it allows to enter.
                            if (range >= ConstantValues.LoweLimitRange)
                            {
                                uValue = objSortingProgram.GetValue(range);
                                Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.DataList + ConstantValues.Desh);
                                objSortingProgram.PrintValue(uValue);
                            }
                            else
                            {
                                Console.WriteLine(ConstantValues.Tab + ConstantValues.Desh + ConstantValues.EnterData + ConstantValues.Desh);
                            }                            
                            break;
                        // Program Terminated
                        case ConstantValues.Exit: 
                            runAgain = ConstantValues.Quit;
                            break;
                    }                     
                }
                catch (Exception e)
                {
                    Console.WriteLine(ConstantValues.ExcStatement + e + ConstantValues.Desh);
                    break;
                }
            }
        }
    }
}
