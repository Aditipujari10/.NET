using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid
{
    abstract class Discount
    {
        public abstract double GetDiscount();
    }

    // Step 2: Extension classes
    class FestivalDiscount : Discount
    {
        public override double GetDiscount()
        {
            Console.WriteLine("Festival discount applied");
            return 15;
        }
    }

    class SeniorCitizenDiscount : Discount
    {
        public override double GetDiscount()
        {
            Console.WriteLine("Senior citizen discount applied");
            return 20;
        }
    }

    class EmployeeDiscount : Discount
    {
        public override double GetDiscount()
        {
            Console.WriteLine("Employee discount applied");
            return 30;
        }
    }

    // Step 3: Closed for modification
    class DiscountCalculator
    {
        public double CalculateDiscount(Discount discount)
        {
            Console.WriteLine("Calculating discount...");
            return discount.GetDiscount();
        }
    }
    internal class OpenClosed
    {

    }
}
