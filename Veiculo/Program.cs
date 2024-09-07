using com.aluno.veiculos.entidades.carros;
using com.aluno.veiculos.entidades.motos;

namespace com.aluno.veiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan("ABC1234", "1234567890", 4, 500);
            Picape picape = new Picape("DEF5678", "0987654321", 1000, true);
            sedan.Mostrar();
            picape.Mostrar();
            sedan.SeguroParticular();
            picape.SeguroParticular();

            Scooter scooter = new Scooter("GHI9012", "5678901234", 150);
            Motocros motocros = new Motocros("JKL3456", "6789012345", 450);
            scooter.Mostrar();
            motocros.Mostrar();

            Console.ReadLine();
        }
    }
}
