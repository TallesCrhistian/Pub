namespace PubApi.Data.Entidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public bool Ativo { get; set; } = true;
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
    }
}
