namespace com.aluno.veiculos.entidades.motos
{
    using com.aluno.veiculos.entidades;

    public class Moto : Veiculo
    {
        public int CapacidadePassageiros { get; private set; }

        public Moto(string placa, string renavam) : base(placa, renavam)
        {
            this.CapacidadePassageiros = 2;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Moto com placa: {Placa}, capacidade para {CapacidadePassageiros} passageiros.");
        }
    }
}
