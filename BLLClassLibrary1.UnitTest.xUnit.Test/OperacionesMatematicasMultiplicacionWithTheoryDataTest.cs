using BLLClassLibrary1.UnitTest.xUnit.Test.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test
{
    public class OperacionesMatematicasMultiplicacionWithTheoryDataTest
    {

        [Theory]
        [ClassData(typeof(FactoriaDataSetMultiplicacionTest))]
        public void Multiplicacion_debeRetornarLasMultiplicacionCorrecta(double esperado, double a, double b)
        {
            //arrage
          

            //act
            double resultado = OperacionesMatematicas.multiplicacion(a, b);

            //assert
            Assert.Equal(esperado, resultado, 5);// utiliza precicion de dos decimales 
        }
    }
}


        