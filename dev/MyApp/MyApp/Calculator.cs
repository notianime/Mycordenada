using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MyApp
{
    public class Calculator
    {
        public double multiplie(string numero, string numero2)
        {
            double number1;
            double number2;

            try
            {
                number1 = Double.Parse(numero2);
                number2 = Double.Parse(numero2);
            }
            catch (FormatException ex) {
                return -1;
            }
            catch (OverflowException ex) {
                return -2;
            }
            catch (ArgumentNullException ex) {
                return -3;
            }
            catch (Exception ex) {
                return 0;
            }
            return number1 * number2;
        }
        public double sum(string numero, string numero2)
        {
            double number1;
            double number2;
            Double.TryParse(numero, out number1);

            if (Double.TryParse(numero2, out number2))
            {
                //
            }
            else
            {
                throw new System.FormatException("Haz ingresado un numero incorrect");
                // Esto es un error
                //row new IndexOutOfRangeException();i
                //throw new ArgumentNullException("Name cannot be null", nameof(value));
            }
            
            return number2 + number1;
                
        }
    }
}
