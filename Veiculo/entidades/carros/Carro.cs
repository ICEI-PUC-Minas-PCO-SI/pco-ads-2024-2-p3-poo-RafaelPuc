namespace com.aluno.veiculos.entidades.carros
{
    using com.aluno.veiculos.entidades.servicos;

    public class Carro : Veiculo, Seguro
    {
        public int CapacidadePassageiros { get; private set; }

        public Carro(string placa, string renavam) : base(placa, renavam)
        {
            this.CapacidadePassageiros = 5;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Carro com placa: {Placa}, capacidade para {CapacidadePassageiros} passageiros.");
        }

        public void SeguroParticular()
        {
            Console.WriteLine("Seguro particular para o Carro.");
        }
    }
}
