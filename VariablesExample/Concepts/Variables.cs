using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExample.Concepts
{
    public class Variables
    {
        // Instance Variable (Field) - Belongs to an instance of the class
        public string instanceVariable = "I am an instance variable";

        // Static Variable - Shared among all instances
        public static string staticVariable = "I am a static variable";

        // Constant Variable - Value cannot be changed after initialization
        public const double Pi = 3.14159;

        // Readonly Variable - Can only be assigned inside the constructor
        public readonly string readonlyVariable;

        // Constructor to initialize readonly variable
        public Variables()
        {
            readonlyVariable = "I am a readonly variable";
        }

        // Method to return variable definition
        public string GetDefinition()
        {
            return "Variables are containers to store data values in memory.";
        }

        public List<string> TypesOfVariables()
        {
            return new List<string>
            {
                "1. Local Variable - Declared inside a method, accessible only within that method.",
                "2. Instance Variable (Field) - Declared inside a class but outside methods, belongs to an instance of the class.",
                "3. Static Variable - Declared with the 'static' keyword, shared among all instances of the class.",
                "4. Constant Variable (const) - A variable whose value cannot change after initialization, must be assigned at declaration.",
                "5. Readonly Variable - Can only be assigned inside the constructor, its value cannot be changed later.",
                "6. Var Variable - Compiler infers the type at compile-time based on the assigned value.",
                "7. Dynamic Variable - Type is resolved at runtime, allowing flexibility but reducing type safety.",
                "8. Nullable Variable - Allows value types to store null values using '?' (e.g., int? x = null)."
            };
        }

        // Example of a Local Variable inside a method
        public string LocalVariableExample()
        {
            int localVariable = 10; // Local variable
            return "Local Variable Value: " + localVariable;
        }

        // Method to demonstrate the use of dynamic variable
        public string DynamicVariableExample()
        {
            dynamic value = 100; // Initially an integer
            value = "Now I am a string"; // Type changed at runtime
            return "Dynamic Variable: " + value;
        }
    }
}
