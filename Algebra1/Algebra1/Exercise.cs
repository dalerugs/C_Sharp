using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algebra1
{
    class Exercise
    {
        public long Factorial(long x)
        {
            if (x <= 1)
                return 1;
            else
                return x * Factorial(x - 1);
        }

        public long Permutation(long n, long r)
        {
            if (r == 0)
                return 0;
            else if (n == 0)
                return 0;
            else if (r >= 0 && r <= n)
                return Factorial(n) / Factorial(n - r);
            else
                return 0;
        }

        public long Combinatorial(long a, long b)
        {
            if (a <= 1)
                return 1;
            else
                return Factorial(a) / (Factorial(b) * Factorial(a - b));
        }
    }
}
