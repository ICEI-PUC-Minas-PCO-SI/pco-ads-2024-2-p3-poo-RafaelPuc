namespace com.aluno.veiculos.entidades
{
    public class Veiculo
    {
        private string placa;
        private string renavam;

        public Veiculo(string placa, string renavam)
        {
            this.placa = placa;
            this.renavam = renavam;
        }

        public string Placa
        {
            get { return placa; }
        }

        public string Renavam
        {
            get { return renavam; }
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Veículo com placa: {placa}");
        }
    }
}
