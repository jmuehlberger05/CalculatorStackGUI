using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CalculatorStackGUI
{
    interface IStackOperations
    {
        void init();					// Stack wird geleert
	    void push(Complex element);		// das 'element' wird auf den Stack gelegt, es wird zum 'Top of Stack' (TOS)
	    Complex pop();					// das oberste Element wird vom Stack geholt
	    void swap();					// die beiden obersten Element am Stack werden vertauscht
	    void dup();						// das oberste Element am Stack wird dupliziert (liegt dann 2x am Stack)

    }
}
