﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace StackCalculator
{
    public class CalculatorStack : Stack, ICalculatorOperations
    {
        //int TOS = -1;
        private int max_element = 100;
        private Complex[] array;

        public CalculatorStack()
        {
            array = new Complex[this.max_element];
        }

        public CalculatorStack(int max)
        {
            array = new Complex[max];
        }

        public void add()
        {
            if (TOS > 0)
            {
                Complex x = this.pop();
                Complex y = this.pop();
                this.push(x + y);
            }
            else
            {
                throw new CalculatorException();
            }
        }

        public void div()
        {
            if (TOS > 0)
            {
                Complex x = this.pop();
                Complex y = this.pop();
                if(x != 0)
                {
                    this.push(y / x);
                }
                else
                {
                    throw new DivideByZeroException();
                }
            }
            else
            {
                throw new CalculatorException();
            }
        }

        public void mul()
        {
            if (TOS > 0)
            {
                Complex x = this.pop();
                Complex y = this.pop();
                this.push(x * y);
            }
            else
            {
                throw new CalculatorException();
            }
        }

        public void reciprocal()
        {
            if (TOS > -1)
            {
                Complex x = this.pop();
                if(x != 0)
                {
                    this.push(1 / x);
                }
                else
                {
                    throw new DivideByZeroException("Division durch Null nicht zulässig");
                }
                
            }
            else
            {
                throw new CalculatorException();
            }
        }

        public void sub()
        {
            if (TOS > 0)
            {
                Complex x = this.pop();
                Complex y = this.pop();
                this.push(y - x);
            }
            else
            {
                throw new CalculatorException();
            }
        }
    }
}