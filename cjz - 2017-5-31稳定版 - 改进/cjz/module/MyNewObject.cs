using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cjz.module
{
    // Creates a new type.
    [Serializable]
    public class MyNewObject : Object
    {
        private string myValue;

        // Creates a default constructor for the class.
        public MyNewObject()
        {
            myValue = "This is the value of the class";
        }

        // Creates a property to retrieve or set the value.
        public string MyObjectValue
        {
            get
            {
                return myValue;
            }
            set
            {
                myValue = value;
            }
        }
    }

}
