using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCompareUtil
{
    class test
    {
        void testCompare()
        {
            string str1 = "3.14";
            string str2 = "3.15";
            log(str1.CompareNumericValueTo(str2), -1);

            str1 = "3.24";
            str2 = "3.15";
            log(str1.CompareNumericValueTo(str2), 1);

            str1 = "3.14";
            str2 = "3.14";
            log(str1.CompareNumericValueTo(str2), 0);

            str1 = "3.14";
            str2 = "-3.15";
            log(str1.CompareNumericValueTo(str2), 1);

            str1 = "-3.14";
            str2 = "3.15";
            log(str1.CompareNumericValueTo(str2), -1);

            str1 = "-3.14";
            str2 = "-3.15";
            log(str1.CompareNumericValueTo(str2), 1);

            str1 = "-3.24";
            str2 = "-3.15";
            log(str1.CompareNumericValueTo(str2), -1);


            str1 = "-3.14";
            str2 = "-3.14";
            log(str1.CompareNumericValueTo(str2), 0);

            str1 = "3.14";
            str2 = "31";
            log(str1.CompareNumericValueTo(str2), -1);

            str1 = "13";
            str2 = "3.15";
            log(str1.CompareNumericValueTo(str2), 1);

            str1 = "3.1401";
            str2 = "3.14";
            log(str1.CompareNumericValueTo(str2), 1);



        }

        static int count = 0;
        static void log(int i, int s)
        {
            Console.Write(count + "\t");
            Console.WriteLine(i == s);
        }
    }
}
