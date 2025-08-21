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
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var Result = Arr.Where((str, index) => str.Length < index);
            #endregion

            Result.PrintAll();
            #endregion
        }
    }
}
