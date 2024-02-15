using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLLClassLibrary1.UnitTest.xUnit.Test.Utilites
{
    public class FactoriaDataSetMultiplicacionTest : TheoryData<double, double, double >

    {

        public FactoriaDataSetMultiplicacionTest()
        {
            // colocar los conjutoas de valores de prueba 
           Add ( 15, 3, 5 );
           Add ( 0, 0, 0 );
           Add ( -48, -8, 6 );
           Add ( 144, -12, -12 );
           Add ( 18.375, 3.5, 5.25 );
           Add ( -56.35625, -8.875, 6.35 );
           Add ( 157.4925, -12.65, -12.45 );
        
       
       
        }

    }
}
