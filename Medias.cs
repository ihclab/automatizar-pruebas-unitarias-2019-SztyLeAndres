using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizarPruebasUnitarias {
    
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) { 

            double sumaTotal = 0;
            double v1 = 0;
            double v2 = 0;
            double promedio = 0;

            for (int =1; i < vals.Length;i++) {
                v1 = vals[i];
                v2 = vals[i+1];
                sumaTotal = v1+v2;
            }
            promedio = sumaTotal/vals.Length;
            return proemdio;
        }

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n) { }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) { }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals) { }
    }
}