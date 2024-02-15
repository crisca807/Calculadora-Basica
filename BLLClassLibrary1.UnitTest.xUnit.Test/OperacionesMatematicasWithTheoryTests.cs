using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test
{
    public class OperacionesMatematicasWithTheoryTests
    {
        [Theory]
        [InlineData(8,3,5)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, -8, 6)]
        [InlineData(-24, -12, -12)]
        public void suma_debeRetornarLasumaCorrecta(double esperado, double a, double b)
        {
            //arrage
          

            //act
            double resultado = OperacionesMatematicas.suma(a, b);

            //assert
            Assert.Equal(esperado, resultado, 2);// utiliza precicion de dos decimales 
        }


        [Theory]
        [InlineData(-2, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-14, -8, 6)]
        [InlineData(0, -12, -12)]
        public void Resta_debeRetornarLaRestaCorrecta(double esperado, double a, double b)
        {
            //arrage
           

            //act
            double resultado = OperacionesMatematicas.resta(a, b);

            //assert
            Assert.Equal(esperado, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Theory]
        [InlineData(15, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-48, -8, 6)]
        [InlineData(144, -12, -12)]
        public void Multiplicacion_debeRetornarLaMultiplicacionCorrecta(double esperado, double a, double b)
        {

            //arrage          

            //act
            double resultado = OperacionesMatematicas.multiplicacion(a, b);

            //assert
            Assert.Equal(esperado, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void Division_debeRetornarLaDivisionCorrecta()
        {
            //arrage
            double a = 15, b = 3;

            //act
            double resultado = OperacionesMatematicas.division(a, b);

            //assert
            Assert.Equal(5, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void Division_DivisionPorCero_DebeLanzarExepcion()
        {
            //arrage
            double a = 10, b = 0;

            //act y assert
            Assert.Throws<ArgumentException>( () => OperacionesMatematicas.division(a, b)); 
        }

        [Fact]
        public void Exponenciacion_debeRetornarLaPotenciaCorrecta()
        {
            //arrage
            double basevalue = 2, exponente = 3;

            //act
            double resultado = OperacionesMatematicas.Exponenciacion(basevalue, exponente);

            //assert
            Assert.Equal(8, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void Porcentaje_debeRetornarElPorcentajeCorrecto()
        {
            //arrage
            double Total = 100, Porcentaje = 10;

            //act
            double resultado = OperacionesMatematicas.porcentaje(Total, Porcentaje);

            //assert
            Assert.Equal(10, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void EsPar_debeRetornarCorrectamenteSiEsPar()
        {
            //arrage
            int numeroPar = 4;

            //act
            bool resultado = OperacionesMatematicas.espar(numeroPar);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void EsImpar_debeRetornarCorrectamenteSiEsImpar()
        {
            //arrage
            int numeroImpar = 3;

            //act
            bool resultado = OperacionesMatematicas.esimpar(numeroImpar);

            //assert
            Assert.True(resultado);
        }

        [Fact]
        public void EsImpar_debeRetornarCorrectamenteSiNoEsImpar()
        {
            //arrage
            int numeroPar = 2;

            //act
            bool resultado = OperacionesMatematicas.esimpar(numeroPar);

            //assert
            Assert.False(resultado);
        }

        [Fact]
        public void EsImpar_debeRetornarCorrectamenteParaCero()
        {
            //arrage
            int numeroCero = 0;

            //act
            bool resultado = OperacionesMatematicas.esimpar(numeroCero);

            //assert
            Assert.False(resultado);
        }
    }
}


        