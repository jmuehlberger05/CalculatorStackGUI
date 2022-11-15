using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorStackGUI
{
    interface ICalculatorOperations
    {
        void add();			// Holt die beiden obersten Elemente vom Stack, addiert sie 
								// und 'pushed' das Ergebnis wieder auf den Stack
	    void sub();			// siehe add()
	    void mul();			// siehe add()
	    void div();			// siehe add()
	    void reciprocal();  // Holt das oberste Element (TOS) vom Stack,
							// berechnet den Kehrwert und 'pushed' diesen auf den Stack	
		void konj();
		void inv();
    }
}
