using BLLClassLibrary1.UnitTest.xUnit.Test.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test
{
    public class OperacionesMatematicasWithClassDataMemberDataTests
    {
        [Theory]
        [MemberData(nameof(FactoriaDataSetAllOperacionesTest.Getsuma), MemberType =typeof(FactoriaDataSetAllOperacionesTest))]
        public void suma_debeRetornarLasumaCorrecta(double esperado, double a, double b)
        {
            //arrage

            //act
            double resultado = OperacionesMatematicas.suma(a, b);

            //assert
            Assert.Equal(esperado, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Theory]
        [MemberData(nameof(FactoriaDataSetAllOperacionesTest.GetResta), MemberType = typeof(FactoriaDataSetAllOperacionesTest))]
        public void Resta_debeRetornarLaRestaCorrecta(double esperado, double a, double b)
        {
            //arrage
            

            //act
            double resultado = OperacionesMatematicas.resta(a, b);

            //assert
            Assert.Equal(esperado, resultado, 2);// utiliza precicion de dos decimales 
        }

        [Theory]
        [MemberData(nameof(FactoriaDataSetAllOperacionesTest.GetMultiplicacion), MemberType = typeof(FactoriaDataSetAllOperacionesTest))]
        public void Multiplicacion_debeRetornarElProductoCorrecto(double esperado, double a, double b)
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


        