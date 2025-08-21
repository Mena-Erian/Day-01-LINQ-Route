using System.Linq;
using static Assignment.ListGenerator;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock.
            /// var Result = ProductsList.Where(p => p.UnitsInStock == 0);
            /// 
            /// Result = from p in ProductsList
            ///          where p.UnitsInStock == 0
            ///          select p;
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            /// var Result = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            /// 
            /// Result = from p in ProductsList
            ///          where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
            ///          select p;
            #endregion

            #region 3. Return digits whose name is shorter than their value.
            /// string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            /// 
            /// var Result = Arr.Where((str, index) => str.Length < index);
            #endregion

            //Result.PrintAll();
            #endregion

            #region LINQ - Element Operators

            #region 1. Get first Product out of Stock 
            /// var Result = ProductsList.First(p => p.UnitsInStock == 0);
            /// 
            /// Result = (from p in ProductsList
            ///           where p.UnitsInStock == 0
            ///           select p).First();
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            /// var Result = ProductsList.FirstOrDefault((p) => p.UnitPrice > 1000);
            /// 
            /// Result = (from p in ProductsList
            ///           where p.UnitPrice > 1000
            ///           select p).FirstOrDefault();
            #endregion

            #region 3. Retrieve the second number greater than 5 
            /// int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 }; // 8
            /// var Result = Arr
            ///     .Where(num => num > 5)
            ///     .ElementAt(1);
            /// 
            /// Result = (from num in Arr
            ///          where num > 5
            ///          select num).ElementAt(1);
            #endregion

            //Result.Print();
            #endregion
        }
    }
}
