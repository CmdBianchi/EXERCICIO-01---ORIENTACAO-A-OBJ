using System;
namespace EXERCICIO_01___ORIENTACAO_A_OBJ{
    class Program{
        //-----> INICIO
        ////////////////////////////////////////////////////////////////////////////////////////////
        static void Main(string[] args){
            Retangulo r = new Retangulo();

            Console.Write("Largura: ");
                r.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
                r.Altura = double.Parse(Console.ReadLine());

            Console.Write("Area: " + r.Area().ToString("F2"));
            Console.WriteLine("");
            Console.Write("Perimetro: " + r.Area().ToString("F2"));
            Console.WriteLine("");
            Console.WriteLine("Diagonal" + r.Diagonal().ToString("F2"));
        }
        ////////////////////////////////////////////////////////////////////////////////////////////
        //-----> FIM
    }
}
