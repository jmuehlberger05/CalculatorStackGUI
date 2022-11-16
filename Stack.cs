using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CalculatorStackGUI
{
    public class Stack : IStackOperations
    {
        public int TOS = -1;
        private int max_element = 100;
        protected Complex[] array;

        public Stack()
        {
            array = new Complex[this.max_element];
        }
        
        public int len() { return TOS+1; }

        public Stack(int max)
        {
            array = new Complex[max];
            max_element = max;
        }

        public void dup()
        {
            if (TOS > -1)
            {
                array[TOS + 1] = array[TOS];
                TOS++;
            }
            else
            {
                Console.WriteLine("No Item to duplicate");
            }
        }

        public void init()
        {
            for(int i = 0; i < TOS+1; i++)
            {
                array[i] = 0;
            }
            TOS = -1;
        }

        public Complex pop()
        {
            if (TOS <= -1)
            {
                throw new StackUnderflowException("StckUnderflow");
            }
            else
            {
                Complex temp = array[TOS];
                array[TOS] = 0;
                TOS--;
                return temp;
            }
        }

        public void push(Complex element)
        {
            array[TOS + 1] = element;
            TOS++;
            if (TOS > this.max_element-1) {
                throw new StackOverflowException("Stack-Overflow");
            }
            
        }

        public void swap()
        {
            if (TOS > 0)
            {
                Complex temp = array[TOS - 1];
                array[TOS - 1] = array[TOS];
                array[TOS] = temp;
            }
            else
            {
                Console.WriteLine("Not enough items to swap");
            }
        }

        public override string ToString()
        {
            string str = "";
            if(TOS > -1) {
                for (int i = TOS; i >= 0; i--)
                {
                    if (array[i] != 0)
                    {
                        str += array[i] + ", ";
                    }
                }
            }
            else
            {
                str = "Stack is emtpy";
            }
            
            return str;
        }
    }
}
