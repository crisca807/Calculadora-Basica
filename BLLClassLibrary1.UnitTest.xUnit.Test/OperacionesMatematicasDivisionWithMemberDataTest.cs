using BLLClassLibrary1.UnitTest.xUnit.Test.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test
{
    public class OperacionesMatematicasDivisionWithMemberDataTest
    {

        [Theory]

        [MemberData(nameof(GetData), parameters:4)]
        public void Division_debeRetornarLaDivisionCorrecta(double esperado, double a, double b)
        {
            //arrage

            //act
            double resultado = OperacionesMatematicas.division(a, b);

            //assert
            Assert.Equal(esperado, resultado, 2);// utiliza precicion de dos decimales 
        }

        public static IEnumerable<object[]> Data => new List<object[]>

        {
            // colocar los conjutoas de valores de prueba 
             new object[] { 0.6, 3, 5 },
             //new object[] { 0, 0, 0 },
             new object[] { -1.3333, -8, 6 },
             new object[] { 1, -12, -12 },
             new object[] { 0.6665, 3.5, 5.25 },
             new object[] { -1.3976, -8.875, 6.35 },
             new object[] { 1.016, -12.65, -12.45 }
        };

        public static IEnumerable<object[]> GetData(int test)
        {
            var datos = new List<object[]>
            {
                  // colocar los conjutoas de valores de prueba 
             new object[] { 0.6, 3, 5 },
             new object[] { -1.3333, -8, 6 },
             new object[] { 1, -12, -12 },
             new object[] { 0.6665, 3.5, 5.25 },
             new object[] { -1.3976, -8.875, 6.35 },
             new object[] { 1.016, -12.65, -12.45 }

            };

            return datos.Take(test);
        }
    }
}

