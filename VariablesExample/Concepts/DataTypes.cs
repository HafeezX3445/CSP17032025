using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesExample.Concepts
{
    public class DataTypes
    {

        // Add a method to return the definition of Data Types

        public string GetDefinition()
        {
            string definition = "Data types are used to define the type of data that a variable can store";

            return definition;
        }

        // Write each data type with example
        // Value types
        int i = 1086767567;
        short s = 14523;
        long l = 6567575745674577777;
        float f = 12.00f;
        decimal d = 5.9m;
        double db = 23.33;





        // Reference Types
        string str = "Jhanu";

        public void Meth()
        {
            dynamic num = "anu";
            num = 6;
        }
        object obj = "Hafizzeyy";


    }
}
