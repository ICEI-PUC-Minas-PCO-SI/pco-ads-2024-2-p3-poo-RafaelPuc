namespace com.aluno.veiculos.entidades.carros
{
    public class Sedan : Carro
    {
        public int NumeroDePortas { get; private set; }
        public int CapacidadePortaMalas { get; private set; }

        public Sedan(string placa, string renavam, int numeroDePortas, int capacidadePortaMalas)
            : base(placa, renavam)
        {
            this.NumeroDePortas = numeroDePortas;
            this.CapacidadePortaMalas = capacidadePortaMalas;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Sedan com placa: {Placa}, {NumeroDePortas} portas, capacidade do porta-malas: {CapacidadePortaMalas} litros");
        }
    }
}
