using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class cFloat { float real; float img; public cFloat(float r, float i) { this.real = r; this.img = i; } public float getReal() { return real; } public void setReal(float r) { real = r; } public float getImg() { return img; } public void setImg(float i) { img = i; }
    public override string ToString()
    {
        return (String.Format("{0} + {1}i", real, img));
    }
    }
    interface iComplexCalc { cFloat add(cFloat c1, cFloat c2); cFloat subtract(cFloat c1, cFloat c2); cFloat multiply(cFloat c1, cFloat c2); cFloat divide(cFloat c1, cFloat c2); }
    public class ComplexCalc:iComplexCalc

    {
        
        public cFloat add(cFloat c1, cFloat c2)
        {
            float a=0, b=0;
            cFloat c3=new cFloat(a,b);
            a = c1.getReal() + c2.getReal();
            b = c1.getImg() + c2.getImg();
            c3.setReal(a);
            c3.setImg(b);
            return c3;

        }
        public cFloat subtract(cFloat c1, cFloat c2)
        {
            float a = 0, b = 0;
            cFloat c3 = new cFloat(a, b);
            a = c1.getReal() -c2.getReal();
            b = c1.getImg() - c2.getImg();
            c3.setReal(a);
            c3.setImg(b);
            return c3;

        }
        public cFloat multiply(cFloat c1, cFloat c2)
        {
            float a = 0, b = 0;
            cFloat c3 = new cFloat(a, b);
            a = c1.getReal()*c2.getReal()-c1.getImg()*c2.getImg();
            b = c1.getReal()*c2.getImg()+c2.getReal()*c1.getImg();
            c3.setReal(a);
            c3.setImg(b);
            return c3;
            
        }
        public cFloat divide(cFloat c1, cFloat c2)
        {
            float a = 0, b = 0;
            cFloat c3 = new cFloat(a, b);
            a = (c1.getReal() * c2.getReal() + c1.getImg() * c2.getImg()) / ((c2.getReal() * c2.getReal()) + (c2.getImg() * c2.getImg()));
            b = (c1.getImg() * c2.getReal() - c1.getReal() * c2.getImg()) / ((c2.getReal() * c2.getReal()) + (c2.getImg() * c2.getImg()));
            c3.setReal(a);
            c3.setImg(b);
            return c3;

        }
        
    }
}
