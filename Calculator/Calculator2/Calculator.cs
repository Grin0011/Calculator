using System;
namespace Calculator2
{
    public class Calculator : CalculatorMusthaves
    {
        public Calculator()
        {
            
        }

        int CalculatorMusthaves.Diff(int getal1, int getal2)
        {
            return getal1 - getal2;
            throw new NotImplementedException();
        }

        int CalculatorMusthaves.Product(int getal1, int getal2)
        {
            return getal1 * getal2;
            throw new NotImplementedException();
        }

        int CalculatorMusthaves.Quotient(int getal1, int getal2)
        {
            return getal1 % getal2;
            throw new NotImplementedException();
        }

        int CalculatorMusthaves.Sum(int getal1, int getal2)
        {
            return getal1 + getal2;
            throw new NotImplementedException();
        }
    }
}
