namespace M2S3.Carros
{
    class CadastroCarros
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public Proprietarios Proprietario { get; set; }
    }

    class Proprietarios
    {
        public string Nome { get; set; } 
        public string CPF { get; set; }
        public string Telefone { get; set; }
    }
}
