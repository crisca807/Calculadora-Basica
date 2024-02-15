using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test
{
    public class OperacionesMatematicasWithFactTests
    {
        [Fact]
        public void suma_debeRetornarLasumaCorrecta()
        {
            //arrage
            double a = 3, b = 5;

            //act
            double resultado = OperacionesMatematicas.suma(a, b);

            //assert
            Assert.Equal(8, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void suma_debeRetornarLasumaCorrecta0()
        {
            //arrage
            double a = 0, b = 0;

            //act
            double resultado = OperacionesMatematicas.suma(a, b);

            //assert
            Assert.Equal(0, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void suma_debeRetornarLasumaCorrecta_Negativo_Positivo()
        {
            //arrage
            double a = -8, b = 6;

            //act
            double resultado = OperacionesMatematicas.suma(a, b);

            //assert
            Assert.Equal(-2, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void suma_debeRetornarLasumaCorrecta_Negativo_Negativo()
        {
            //arrage
            double a = -12, b = -12;

            //act
            double resultado = OperacionesMatematicas.suma(a, b);

            //assert
            Assert.Equal(-24, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void Resta_debeRetornarLaRestaCorrecta()
        {
            //arrage
            double a = 10, b = 4;

            //act
            double resultado = OperacionesMatematicas.resta(a, b);

            //assert
            Assert.Equal(6, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Fact]
        public void Multiplicacion_debeRetornarLaMultiplicacionCorrecta()
        {
            //arrage
            double a = 7, b = 3;

            //act
            double resultado = OperacionesMatematicas.multiplicacion(a, b);

            //assert
            Assert.Equal(21, resultado, 2);// utiliza precicion de dos decimales 
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


        