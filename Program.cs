using System;
using System.Globalization;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Para trabalhar com moedas no geral, preços, salários, é bom usar o 'decimal'
            decimal valor = 10.25m;
            Console.WriteLine(valor);

            // Formatar a moeda: converter para uma cultura específica
            // decimal valor = 10.25m;
            // Console.WriteLine(valor.ToString(
            //     "C",
            //     CultureInfo.CreateSpecificCulture("en-US")));
            // decimal valor = 10456.25m;
            // Console.WriteLine(valor.ToString(
            //     "F",
            //     CultureInfo.CreateSpecificCulture("en-US")));
            // decimal valor = 10456.25m;
            // Console.WriteLine(valor.ToString(
            //     "P",
            //     CultureInfo.CreateSpecificCulture("en-US")));
            // decimal valor = 10456.25m;
            // Console.WriteLine(valor.ToString(
            //     "N",
            //     CultureInfo.CreateSpecificCulture("en-US")));

            // Conversão de valores: para arredondar ou pra cima ou pra baixo
            // decimal valor = 10456.25m;
            // Console.WriteLine(Math.Round(valor));
            // Console.WriteLine(Math.Ceiling(valor));
            // Console.WriteLine(Math.Floor(valor));


        }
    }
}