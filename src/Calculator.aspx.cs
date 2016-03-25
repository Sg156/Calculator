using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using calc;


namespace Calculator
{
    public partial class Calculaotr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            if (checkbox2.Checked==true || checkbox3.Checked==true || checkbox4.Checked==true || CheckBox6.Checked==true )
            {
                Label2.Visible = Label3.Visible = Label10.Visible = Label11.Visible = Label14.Visible = true;
                TextBox1.Visible = TextBox2.Visible = true;
                if (checkbox2.Checked)
                {
                    Button8.Visible = true;
                }
                if (checkbox3.Checked)
                {
                    Button1.Visible = true;
                }
                if (checkbox4.Checked)
                {
                    Button2.Visible = true;
                }
                if (CheckBox6.Checked)
                {
                    Button3.Visible = true;
                }

            }
            else if (CheckBox8.Checked == true || CheckBox9.Checked == true || CheckBox10.Checked == true || CheckBox7.Checked == true)
            {

                Label5.Visible = Label6.Visible = Label7.Visible = Label8.Visible = Label9.Visible = Label12.Visible = Label13.Visible = true;
                TextBox3.Visible = TextBox4.Visible = TextBox5.Visible = TextBox6.Visible = true;

                if (CheckBox8.Checked)
                {
                    Button9.Visible = true;
                }
                if (CheckBox9.Checked)
                {
                    Button10.Visible = true;
                }
                if (CheckBox10.Checked)
                {
                    Button11.Visible = true;
                }
                if (CheckBox7.Checked)
                {
                    Button12.Visible = true;
                }
            }

        }

        SimpleCalc s = new SimpleCalc();
        ComplexCalc cc = new ComplexCalc();
       

        protected void Button8_Click1(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox1.Text));
            float b = (float)(Convert.ToInt32(TextBox2.Text));
            
            Label11.Text = s.add(a, b).ToString();

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox1.Text));
            float b = (float)(Convert.ToInt32(TextBox2.Text));
        
            Label11.Text = s.subtract(a, b).ToString();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox1.Text));
            float b = (float)(Convert.ToInt32(TextBox2.Text));
           
            Label11.Text = s.multiply(a, b).ToString();
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox1.Text));
            float b = (float)(Convert.ToInt32(TextBox2.Text));
          
            Label11.Text = s.divide(a, b).ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox3.Text));
            float b = (float)(Convert.ToInt32(TextBox4.Text));
            float c = (float)(Convert.ToInt32(TextBox5.Text));
            float d = (float)(Convert.ToInt32(TextBox6.Text));
            cFloat c1 = new cFloat(a, b);
            cFloat c2 = new cFloat(c, d);
            Label13.Text = cc.add(c1,c2).ToString();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox3.Text));
            float b = (float)(Convert.ToInt32(TextBox4.Text));
            float c = (float)(Convert.ToInt32(TextBox5.Text));
            float d = (float)(Convert.ToInt32(TextBox6.Text));
            cFloat c1 = new cFloat(a, b);
            cFloat c2 = new cFloat(c, d);
            Label13.Text = cc.subtract(c1, c2).ToString();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox3.Text));
            float b = (float)(Convert.ToInt32(TextBox4.Text));
            float c = (float)(Convert.ToInt32(TextBox5.Text));
            float d = (float)(Convert.ToInt32(TextBox6.Text));
            cFloat c1 = new cFloat(a, b);
            cFloat c2 = new cFloat(c, d);
            Label13.Text = cc.multiply(c1, c2).ToString();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            float a = (float)(Convert.ToInt32(TextBox3.Text));
            float b = (float)(Convert.ToInt32(TextBox4.Text));
            float c = (float)(Convert.ToInt32(TextBox5.Text));
            float d = (float)(Convert.ToInt32(TextBox6.Text));
            cFloat c1 = new cFloat(a, b);
            cFloat c2 = new cFloat(c, d);
            cFloat c3= cc.divide(c1, c2);
            Label13.Text=cc.divide(c1,c2).ToString();
        }
     
    }
}