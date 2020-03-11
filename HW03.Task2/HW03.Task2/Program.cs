using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Value types

            sbyte sb1 = 27;
            SByte sb2 = 28;
            Console.WriteLine(sb1.GetType());
            Console.WriteLine(sb2.GetType());

            short sh1 = 32000;
            Int16 sh2 = 32767;
            Console.WriteLine(sh1.GetType());
            Console.WriteLine(sh2.GetType());

            int i1 = 753;
            Int32 i2 = 357;
            Console.WriteLine(i1.GetType());
            Console.WriteLine(i2.GetType());

            long ln1 = 8544555;
            Int64 ln2 = 8544556;
            Console.WriteLine(ln1.GetType());
            Console.WriteLine(ln2.GetType());

            byte bt1 = 254;
            Byte bt2 = 255;
            Console.WriteLine(bt1.GetType());
            Console.WriteLine(bt2.GetType());

            ushort ush1 = 65534;
            UInt16 ush2 = 65535;
            Console.WriteLine(ush1.GetType());
            Console.WriteLine(ush2.GetType());

            char ch1 = 'b';
            Char ch2 = 'c';
            Console.WriteLine(ch1.GetType());
            Console.WriteLine(ch2.GetType());

            uint ui1 = 4294967294;
            UInt32 ui2 = 4294967295;
            Console.WriteLine(ui1.GetType());
            Console.WriteLine(ui2.GetType());

            ulong uln1 = 551615;
            UInt64 uln2 = 551616;
            Console.WriteLine(uln1.GetType());
            Console.WriteLine(uln2.GetType());

            float fl1 = 1.001f;
            Single fl2 = 1.002F;
            Console.WriteLine(fl1.GetType());
            Console.WriteLine(fl2.GetType());

            double db1 = 45.45;
            Double db2 = 54.54;
            Console.WriteLine(db1.GetType());
            Console.WriteLine(db2.GetType());

            decimal dcm1 = 12222222222222;
            Decimal dcm2 = 12222222222223;
            Console.WriteLine(dcm1.GetType());
            Console.WriteLine(dcm2.GetType());

            bool trueFlag = true;
            Boolean falseFlag = false;
            Console.WriteLine(trueFlag.GetType());
            Console.WriteLine(falseFlag.GetType());


            //Simple Reference Types

            object obj1 = new object();
            Object obj2 = new object();
            Console.WriteLine(obj1.GetType());
            Console.WriteLine(obj2.GetType());

            string str1 = "Hi!";
            String str2 = "Hello!";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());
        }
    }
}
