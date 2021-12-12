using System;
using System.Text;
using BibliotecaDeClasesEjercicio14;

namespace Ejercicio14
{
    internal class Program
    {
// 14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase(estáticos) que realicen el
//cálculo del área que corresponda:
//a. double CalcularCuadrado(double)
//b. double CalcularTriangulo(double, double)
//c. double CalcularCirculo(double)
//El ingreso de los datos como la visualización se deberán realizar desde el método Main().
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // calculoDeAreaInstancia.Equals("asd"); -> Método de instancia (NO se declara como static)
            // Método estatico: un método que es de la clase y NO necesita una instancia de un objeto para ser llamado.
            double algunaVariable = CalculoDeArea.CalcularCuadrado(2);

            Console.WriteLine("Lo que quieras escribir.Calculo de area de cuadradi = " + algunaVariable);

            algunaVariable = CalculoDeArea.CalcularTriangulo(1,5);

            Console.WriteLine($"Lo que quieras escribir.Calculo de area de triangulo = {algunaVariable}" );

            algunaVariable = CalculoDeArea.CalcularCirculo(1);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Lo que quieras escribir.Calculo de area de circulo = ");
            stringBuilder.Append(algunaVariable);
            Console.WriteLine(stringBuilder.ToString());


        }
    }
}
