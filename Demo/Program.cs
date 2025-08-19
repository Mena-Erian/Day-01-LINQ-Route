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


        }
    }
}
