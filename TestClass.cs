using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest
{

    internal class TestClass : IComparable<TestClass>
    {
        public int digit { get; set; }
        public static TestClass operator + (TestClass a, TestClass b) => new TestClass() { digit = a.digit + b.digit };
        public static implicit operator TestClass(long a) => new TestClass() { digit = (int)a };

        public static implicit operator long(TestClass a) => a.digit;
        public int this[int index] { get => 0; }

        public int CompareTo(TestClass? other) =>  this.digit.CompareTo(other?.digit);

    }
}
