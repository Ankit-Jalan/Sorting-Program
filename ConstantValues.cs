using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingValue
{
    /// <summary>
    /// This class  contain all the constant values used in this program which can be string and integer.
    /// </summary>
    class ConstantValues
    {
        /// <summary>
        /// Program menu keys information statement.
        /// </summary>
        internal const string MenuStatement = "\n\t\t\t--{0} : Create New data List--\n\t\t\t--{1} : Ascending--\n\t\t\t--{2} : Descending--\n\t\t\t--{3} : Enter data again--\n\t\t\t--{4} : Exit--\n\t\t\t";
        /// When user chooses option2 and option3 before entering values.
        /// </summary>
        internal const string CreateListStatement = "Before Sorting order you have to create List";
        /// <summary>
        /// When user chooses option4 before entering values.
        /// </summary>
        internal const string EnterData = "Before entering values again you have to create List";
        internal const string Tab = "\t\t\t";
        internal const string NewlineTab = "\n\t\t\t";
        internal const string Desh = "--";
        internal const string ExcStatement = "\t\t\t--Exception occured ";
        /// <summary>
        /// It allows to execute again.
        /// </summary>
        internal const string Pass = "y";
        /// <summary>
        /// It terminate program flow.
        /// </summary>
        internal const string Quit = "n";
        internal const string AscendOrder = "Ascending Value";
        internal const string DescendOrder = "Descending Value";
        internal const string DataList = " Data List ";
        internal const string RangeRequest = "Enter Range for elements";
        internal const string ValueRequest = "Now you can enter {0} values";
        internal const string ValueIncorrect = "Only numeric value can be entered. Enter value again";
        internal const string ValueUnfeasible = "Your Entered value is not feasible.Your value can be upto '+' or '-' {0}.Enter value again";
        internal const string OrderKeyInformation = "Enter {0} for descending and {1} for ascending";
        internal const string RangeUnfeasible = "Your Range is not feasible. Enter value must be in {0} to {1}";
        internal const string RangeIncorrect = "Your Range input is not Correct. Enter again";
        internal const string OptionIncorrect = "Your Option input is not Correct. Enter again";
        internal const string InvalidInput = "Invlid Input. Press again";
        /// <summary>
        /// Range Lowest value.
        /// </summary>
        internal const int LoweLimitRange = 2;
        /// <summary>
        ///  Range maximum value.
        /// </summary>
        internal const int UpperLimitRange = 20;
        /// <summary>
        /// Option Max value.
        /// </summary>
        internal const int UpperLimitOption = 5;
        /// <summary>
        /// Option Lowest value.
        /// </summary>
        internal const int LowerLimitOption = 1;
        /// <summary>
        /// Maximum value limit.
        /// </summary>
        internal const int ValueLimit = 9999999;
        internal const int CreateList = 1;
        internal const int Ascending = 2;
        internal const int Descending = 3;
        internal const int EnterDataList = 4;
        internal const int Exit = 5;
    }
}
