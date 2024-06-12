using System;


namespace Ref_Out
{
   class Calculator
    {
        /** Referencia de Ref
        public static void Triple(ref int x)
        {
            x = x * 3;
        }
        **/

        public static void Triple(int orign, out int result)
        {
            result = orign * 3;
        }
    }
}
