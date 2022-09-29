using PubApi.Compartilhado.Mensagens;

namespace PubApi.Compartilhado.DTOs
{
    public class RespostaServicoDTO<T>
    {
        public T Dados { get; set; }
        public bool Sucesso { get; set; } = true;
        public string Mensagem { get; set; } = ConstantesMensagens.OperacaoConcluidaComSucesso;
    }
}
