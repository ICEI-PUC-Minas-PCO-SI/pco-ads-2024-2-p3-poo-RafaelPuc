namespace com.aluno.veiculos.entidades.carros
{
    public class Picape : Carro
    {
        public int CapacidadeCarga { get; private set; }
        public bool Tracao4x4 { get; private set; }

        public Picape(string placa, string renavam, int capacidadeCarga, bool tracao4x4)
            : base(placa, renavam)
        {
            this.CapacidadeCarga = capacidadeCarga;
            this.Tracao4x4 = tracao4x4;
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Picape com placa: {Placa}, capacidade de carga: {CapacidadeCarga} kg, 4x4: {(Tracao4x4 ? "Sim" : "Não")}");
        }
    }
}
