using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace CalculatorStackGUI
{
    public partial class Form1 : Form
    {

        private CalculatorStack opStack;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(CalculatorStack stack) 
        {
            InitializeComponent();
            opStack = stack;
            //listBox1.DataSource = opStack.InnerArray;
        }

        private void push_Click(object sender, EventArgs e)
        {
            Complex number = new Complex((double)real.Value, (double)imag.Value);
            output.Text = "" + number;
            real.Value = 0; 
            imag.Value = 0;
            error_msg.Visible = false;
            //CalculatorStack myStack = new CalculatorStack();
            opStack.push(number);
            refresh();
        }

        private void refresh()
        {
            this.listBox1.Items.Clear();
            for (int i = 0; i < opStack.len(); i++)
            {
                listBox1.Items.Add(opStack.InnerArray[i]);
            }
            //this.listBox1.Items.AddRange(new List<string>().Add(opStack.InnerArray)));
        }

        private void init_Click(object sender, EventArgs e)
        {
            opStack.init();
            output.Text = "Cleared";
            error_msg.Visible = false;
            refresh();
        }

        private void add_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try {
                opStack.add();
                output.Text = "" + opStack.InnerArray[opStack.len()-1];
            }
            catch (CalculatorException ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
            
        }

        private void pop_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            Complex popped;
            try
            {
                popped = opStack.pop();
                output.Text = ""+ popped;
            }
            catch (StackUnderflowException ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.sub();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (CalculatorException ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.mul();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (CalculatorException ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void div_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.add();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (CalculatorException ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void rez_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.reciprocal();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (CalculatorException ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void dup_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.dup();
                output.Text = "Duplicated " + opStack.InnerArray[opStack.len() - 1];
            }
            catch (Exception ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void quad_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.quad();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (Exception ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void konj_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.konj();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (Exception ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }

        private void inv_Click(object sender, EventArgs e)
        {
            error_msg.Visible = false;
            try
            {
                opStack.inv();
                output.Text = "" + opStack.InnerArray[opStack.len() - 1];
            }
            catch (Exception ex)
            {
                error_msg.Visible = true;
                error_msg.Text = ex.Message;
            }
            refresh();
        }
    }
}
