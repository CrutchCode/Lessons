using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryGenerics
{
    public class ClassGenerics<T>
    {
        public T Id { get; set; }
        public T numb = default(T);
        public int Sum { get; set; }
        public static T session;

    }
}
