
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

        }
    }
}
