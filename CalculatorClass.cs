using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class CalculatorClass
    {
        double _total;

        public double Total
        {
            get { return _total; }
            set { _total = value; }
        }
        double _value;


        public double Value
        {
            get { return _value; }
            set { _value = value; }
        }


        public CalculatorClass()
        {

        }
        public void addition(CalculatorClass obj)
        {
            CalculatorClass val = obj;
            _total += val.Value;
        }
        public void subtract(CalculatorClass obj)
        {
            CalculatorClass val = obj;
            _total -= val.Value;
        }
        public void multiply(CalculatorClass obj)
        {
            CalculatorClass val = obj;
            _total *= val.Value;
           
        }
        public void divide(CalculatorClass obj)
        {
            CalculatorClass val = obj;
            _total /= val.Value;
        }
        public override string ToString()
        {
            return string.Format("Total  {0}", _total);
        }
    }
}
