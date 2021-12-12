using System;

namespace BibliotecaDeClasesEjercicio14
{
 // 14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
 //cálculo del área que corresponda:
 //a. double CalcularCuadrado(double)
 //b. double CalcularTriangulo(double, double)
 //c. double CalcularCirculo(double)
 //El ingreso de los datos como la visualización se deberán realizar desde el método Main().
    public class CalculoDeArea
    {
        // visibilidad retorno NombreDelMetodo(tipoDato1 nombreVariabledato1, TipoDato2 nombreVariabledato2)
        //{ 
        //   /.....La definición del método
        //  return DatoRetornado
        //}
        public static double CalcularCuadrado(double numero)
        {
            double datoRetornado = numero * numero;
            return datoRetornado;
        }
        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double datoRetornado = (baseTriangulo * alturaTriangulo) / 2;
            return datoRetornado;
        }

        public static double CalcularCirculo(double radio)
        {
            double retornarDato = Math.PI * Math.Pow(radio, 2);
            return retornarDato;
        }
    }
}
