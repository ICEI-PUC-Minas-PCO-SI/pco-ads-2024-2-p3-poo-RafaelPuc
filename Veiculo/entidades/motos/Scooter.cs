namespace com.aluno.veiculos.entidades.motos
{
    public class Scooter : Moto
    {
        public int Cilindradas { get; private set; }

        public Scooter(string placa, string renavam, int cilindradas) : base(placa, renavam)
        {
            this.Cilindradas = cilindradas;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Scooter com placa: {Placa}, {Cilindradas} cilindradas");
        }
    }
}
