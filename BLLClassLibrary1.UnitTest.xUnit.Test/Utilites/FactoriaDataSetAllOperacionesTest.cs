using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test.Utilites
{
    public class FactoriaDataSetAllOperacionesTest
    {
        public static IEnumerable<object[]> Getsuma() => new List<object[]>
        {
            // colocar los conjutoas de valores de prueba 
              new object[] { 8, 3, 5 },
              new object[] { 0, 0, 0 },
              new object[] { -2, -8, 6 },
              new object[] { -24, -12, -12 },
              new object[] { 8.75, 3.5, 5.25 },
              new object[] { -2.53, -8.875, 6.35 },
              new object[] { -25.1, -12.65, -12.45 }
        };

        public static IEnumerable<object[]> GetResta() => new List<object[]>
        {
            // colocar los conjutoas de valores de prueba 
              new object[] { -2, 3, 5 },
              new object[] { 0, 0, 0 },
              new object[] { -14, -8, 6 },
              new object[] { 0, -12, -12 },
              new object[] { -1.75, 3.5, 5.25 },
              new object[] { -15.225, -8.875, 6.35 },
              new object[] { -0.2, -12.65, -12.45 }
        };

        public static IEnumerable<object[]> GetMultiplicacion() => new List<object[]>
        {
            // colocar los conjutoas de valores de prueba 
              new object[] { 15, 3, 5 },
              new object[] { 0, 0, 0 },
              new object[] { -48, -8, 6 },
              new object[] { 144, -12, -12 },
              new object[] { 18.375, 3.5, 5.25 },
              new object[] { -56.35625, -8.875, 6.35 },
              new object[] { 157.4925, -12.65, -12.45 }
        };

    }
}
