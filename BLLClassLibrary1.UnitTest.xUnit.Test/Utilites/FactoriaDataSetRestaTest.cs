using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test.Utilites
{
    public class FactoriaDataSetRestaTest : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // colocar los conjutoas de valores de prueba 
             yield return new object[] { -2, 3, 5 };
             yield return new object[] { 0, 0, 0 };
             yield return new object[] { -14, -8, 6 };
             yield return new object[] { 0, -12, -12 };
             yield return new object[] { -1.75, 3.5, 5.25 };
             yield return new object[] { -15.225, -8.875, 6.35 };
             yield return new object[] { -0.2, -12.65, -12.45 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
