
using static Demo.ListGenerator;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region Implicitly-Typed Local Variable
            #region Var
            /// // var: is a C# keyword [C# 3.0 Feature]
            /// 
            /// var Name = "Mena";
            /// // Compiler Can Detect the type of the Variable based on its Initial Value at Compilation Time.
            /// // Must be Initialized
            /// // Can't be Initialized
            /// // Can't be Initialized with NULL
            /// // After Initilization, U Can't Change the Variable DataType
            #endregion

            #region dynamic
            /// // dynamic: is a C# Keyword [C# 4.0 Feature]
            /// 
            /// dynamic Data;
            /// // NOT Type Safte
            /// /// Compiler will Escape Type Checking at Compilation Time.
            /// /// CLR will Resolve the actual type of a DynamicType Variable at RunTime and will be changed bassed on the assigned value.
            /// /// Not Must be Initialized.
            /// /// Can be Initialized with NULL
            /// /// After Initialization, U Can Change its DataType.
            /// 
            /// Data = "Mena";
            /// Data = 10;
            /// Data = 10.5;
            /// Data = true;
            /// Data = 'M';
            #endregion

            //var employee = new {Id  = 1, Name = "Mena",Salary = 8_000};
            //Console.WriteLine(employee.Name);
            #endregion

            #region Anonymous Types [AnonymousType Object is an Immutable Object & ..]
            /// var employee = new { Id = 10, Name = "Mena", Salary = 8_000 };
            /// Console.WriteLine(employee.GetType());
            /// Console.WriteLine(employee.ToString());
            /// 
            /// // Here not create new Anonymous type, but it will to be the same, But how?!!
            /// // last anonymous type was generic so, it can be the same
            /// 
            /// // The Same Anonymous Type as long as:
            /// // 1. The Same Properties Naming [Case Sensitive]
            /// // 2. The Same Properties Order
            /// var employee01 = new { Id = 10, Name = "Mena", Salary = 8_000F };
            /// Console.WriteLine(employee01.GetType());
            /// //----------------------------------------
            /// 
            /// // The Object That will be created from "Anonymous Type" => is an Immutable Object
            /// // [Can't be chagned] => employee1.Id = 10 // That Not Vaid
            /// 
            /// // So To Change do this
            /// 
            /// //employee = new { Id = 11,employee.Name,employee.Salary};
            /// employee = employee with { Id = 20 }; // Syntax sugar [C# 10.0 Feature]

            /// // Will Generate New Type Becouse the diffrent Naming or Orders
            /// var employee = new { Id = 10, Name = "Mena", Salary = 8_000 };
            /// 
            /// var product = new { ProductName = "Meat", Price = 120 };


            #endregion

            #region Extension Method
            // Should to be in Static Class NonGeneric
            //8956.Reverse().Print();
            #endregion

            #region LINQ Introduction

            #region What is a LINQ?
            /// // How LINQ transfare to SQL => by ORM (Using Entity Framwork)
            /// 
            /// // LINQ: stands for Language-Integrated Query
            /// // LINQ: +40 Extension Methods for BuiltIn-Interface "IEnumerable" (foreach)
            /// //     : Named as "LINQ Operators" Existed in Class  "IEnumerable"
            /// //     : Categorized into 13 Categories. 
            /// //          => 3  Categories Work Imeduate
            /// //          => 10 Categories Work Defferd
            /// //          if i want to Defferd work Imedute => Using with Imedute (Like ToList())
            /// 
            /// // Use LINQ Operators against Data (Stored in Sequence), Regardless Data Store (File, Database Provider [SQL Server, MySql, Oracle])
            /// // Sequence: is an Object from Class Implements "IEnumerable" Interface like List, HashSet, ArrayList, Dictionary,...
            /// // 1. Local  Sequence: L2O          L2XML
            /// // 2. Remote Sequence: L2EF(SQL)    L2SQL
            /// 
            /// List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// 
            /// //                                  Where Using Like Find
            /// /*IEnumerable<int>*/ var Odds = Numbers.Where(n => n % 2 == 1); // Defferd Excution
            /// 
            /// Numbers.AddRange([11, 12, 13, 14, 15]);
            /// 
            /// Odds.PrintAll();
            #endregion

            #region LINQ Syntax
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            #region Fluent Syntax
            // 1. Fluent Syntax

            /// 1.1 Call "LINQ Operator" as => Static Method through "Enumerable" Class
            //var OddNumbers = Enumerable.Where(Numbers, i => i % 2 == 1);

            /// 1.2 Call "LINQ Operator" as => Extension Method
            //OddNumbers = Numbers.Where((N) => N % 2 == 1);
            #endregion

            #region Query Syntax
            /// // 2. Query Syntax: Query Expression (Like: SQLServer Style)
            /// /// Starting with keyword "from"
            /// /// Introducing Range Variable (N): Represents each and every Element in the Input Sequence
            /// /// Ending with keyword "select" Or "group by"
            /// 
            /// /*
            ///  * select n 
            ///  * from numbes n
            ///  * where n %2==1
            ///  * **/
            /// // Should Start with from and end with select or group by
            /// OddNumbers = from N in Numbers
            ///              where N % 2 == 1
            ///              select N; 
            #endregion

            //OddNumbers.PrintAll();
            #endregion

            #region LINQ Excution Ways

            #region Differed Excution
            /// // 1. Differed Excution (Latest Version of Data)
            /// List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// 
            /// var Result = Numbers.Where((N) => N % 2 == 1);
            /// 
            /// Numbers.AddRange([11, 12, 13, 14, 15]);
            /// 
            /// Result.PrintAll();
            #endregion


            #region Immediate Excution
            /// // 2. Immediate Excution (Element Operators, Casting Operators, Aggregate Operators)
            /// List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /// 
            /// var Result = Numbers.Where((N) => N % 2 == 1).ToList(); /*.First() <= Element Operator */
            /// 
            /// Numbers.AddRange([11, 12, 13, 14, 15]);
            /// 
            /// Result.PrintAll();
            #endregion

            #endregion

            #endregion


            #region Filteration (Restruction) Operators - Where
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0);
            // Result = from p in ProductsList
            //             where p.UnitsInStock == 0
            //             select p;

            //var Result = ProductsList.Where(P => P.UnitsInStock == 0 && P.Category == "Meat/Poultry");
            //Result = from P in ProductsList
            //         where P.UnitsInStock == 0 && P.Category == "Meat/Poultry"
            //         select P;


            //Indexed Where
            /// Valid Only with Fluent Syntax. Can't be Written in Query Expression
            //var Result = ProductsList.Where((P, I) => P.UnitsInStock == 0 && I < 11);
            #endregion

            #region TypeOf
            //var Result = ProductsList.OfType<Product02>();
            //ProductID:0,ProductName:,Category,UnitPrice:0,UnitsInStock:0, Serial Number: 2323423
            #endregion


            //Result.PrintAll();
        }
    }
}
