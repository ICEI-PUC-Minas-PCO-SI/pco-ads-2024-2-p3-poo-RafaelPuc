namespace com.aluno.veiculos.entidades.motos
{
    public class Motocros : Moto
    {
        public int Cilindradas { get; private set; }
        public Motocros(string placa, string renavam, int cilindradas)
            : base(placa, renavam)
        {
            this.Cilindradas = cilindradas;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Motocros com placa: {Placa}");
        }
    }
}
