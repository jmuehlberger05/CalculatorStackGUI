using System;

namespace CalculatorStackGUI
{
    class StackOverflowException : Exception
    {
        public StackOverflowException()
                : base("UserException")
        {
        }
        public StackOverflowException(String s)
            : base(s)
        {
        }
        public override string ToString()
        {
            return ("StackOverflow");
        }

        public override string Message => ("StackOverflow");
    }

    class StackUnderflowException : Exception
    {
        public StackUnderflowException()
                : base("UserException")
        {
            Console.WriteLine("CalculatorException");
        }
        public StackUnderflowException(String s)
            : base(s)
        {
            Console.WriteLine(s);
        }

        public override string ToString()
        {
            return ("StackUnderflow");
        }

        public override string Message => ("Ein StackUnderflow ist aufgetreten!");
    }

    class DivideByZeroException : Exception
    {
        public DivideByZeroException()
                : base("UserException")
        {
            Console.WriteLine("DivByYZeroException");
        }
        public DivideByZeroException(String s)
            : base(s)
        {
            Console.WriteLine(s);
        }

        public override string ToString()
        {
            return ("StackUnderflow");
        }

        public override string Message => ("Division durch Null nicht zulässig");
    }

    class CalculatorException : Exception
    {
        public CalculatorException()
                : base("UserException")
        {
        }
        public CalculatorException(String s)
            : base(s)
        {
        }

        public override string ToString()
        {
            return ("CalculatorException");
        }

        public override string Message => ("Ein Fehler im CalculatorStack ist aufgetreten!");
    }

    class StackException : Exception
    {
        public StackException()
                : base("UserException")
        {
        }
        public StackException(String s)
            : base(s)
        {
        }

        public override string ToString()
        {
            return ("CalculatorException");
        }

        public override string Message => ("Ein Fehler im Stack ist aufgetreten!");
    }
}
