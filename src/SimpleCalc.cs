using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;


namespace calc
{
    interface iSimpleCalc { float add(float f1, float f2); float subtract(float f1, float f2); float multiply(float f1, float f2); float divide(float f1, float f2); }
    public class SimpleCalc :iSimpleCalc
    {
        public float add(float i, float j)
        {
            return (i + j);
        }
        public float subtract(float i, float j)
        {
            if (i > j)
                return (i - j);
            else
                return (j - i);
        }
        public float multiply(float i, float j)
        {
            return (i * j);
        }
        public float divide(float i, float j)
        {
            return (i / j);
        }
       
    }
}
