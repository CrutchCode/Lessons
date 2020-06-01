using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class TrainingСlass
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public static int sum;

        public string Name2 { get; set; } = "John";
    }
    public class OverloadedOperators
    {
        public int Value { get; set; }
        private static int count = 0;
        public OverloadedOperators()
        {

        }
        public OverloadedOperators(int initialparameter)
        {
            Value = initialparameter;
            count++;
            Console.WriteLine($"Object with parameter {count}: {initialparameter}");
        }

        // Перегружений оператор плюс
        public static OverloadedOperators operator +(OverloadedOperators FirstNumeric, OverloadedOperators SecondNumeric)
        {
            return new OverloadedOperators { Value = FirstNumeric.Value + SecondNumeric.Value };

        }
        // Перегружений оператор мінус
        public static OverloadedOperators operator -(OverloadedOperators FirstNumeric, OverloadedOperators SecondNumeric)
        {
            return new OverloadedOperators { Value = FirstNumeric.Value - SecondNumeric.Value };
        }
        // Перегружений оператор більше
        public static bool operator >(OverloadedOperators FirstNumeric, OverloadedOperators SecondNumeric)
        {
            return FirstNumeric.Value > SecondNumeric.Value;
        }
        // Перегружений оператор менше
        public static bool operator <(OverloadedOperators FirstNumeric, OverloadedOperators SecondNumeric)
        {
            return FirstNumeric.Value < SecondNumeric.Value;
        }
        // Перегружений оператор інкременту
        public static OverloadedOperators operator ++(OverloadedOperators number)
        {
            return new OverloadedOperators { Value = number.Value + 1 };
        }
        // Перегружений оператор декременту
        public static OverloadedOperators operator --(OverloadedOperators number)
        {
            return new OverloadedOperators { Value = number.Value - 1 };
        }
    }
    //public class Person 
    //{
    //    private string _name;

    //    public string Name
    //    {
    //        get { return _name; }
    //        set { _name = value; }
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine(Name);
    //    }
    //}
    //public class Emploee : Person
    //{

    //}
}
