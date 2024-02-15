using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test.Utilites
{
    public class FactoriaDataSetSumaTest : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // colocar los conjutoas de valores de prueba 
             yield return new object[] { 8, 3, 5 };
             yield return new object[] { 0, 0, 0 };
             yield return new object[] { -2, -8, 6 };
             yield return new object[] { -24, -12, -12 };
             yield return new object[] { 8.75, 3.5, 5.25 };
             yield return new object[] { -2.525, -8.875, 6.35 };
             yield return new object[] { -25.1, -12.65, -12.45 };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
