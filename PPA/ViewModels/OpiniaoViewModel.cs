using System.ComponentModel.DataAnnotations;

namespace PPA.Models
{
    public class OpiniaoViewModel
    {
        [Required(ErrorMessage = "Campo CPF é Obrigatório")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo RG é obrigatório")]
        public string Rg { get; set; }
        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Endereco é obrigatório")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Campo Eixo é obrigatório")]
        public string Eixo { get; set; }
        [Required(ErrorMessage = "Campo Tema é obrigatório")]
        public string Topico { get; set; }
        [Required(ErrorMessage = "Campo Opinão é obrigatorio")]
        public string Opiniao { get; set; }
        [Required(ErrorMessage = "Campo Email é obrigatório")]
        [EmailAddress(ErrorMessage = "Endereco de email não é válido")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Campo Telefone é obrigatório")]
        public string Telefone { get; set; }

        public Opiniao ToModel(string cpf, string rg, string nome, string endereco, string eixo,string opiniao, string telefone,string email)
        {
            return new Opiniao()
            {
                Cpf = cpf,
                Rg = rg,
                Nome = nome,
                Endereco = endereco,
                Eixo = eixo,
                Comentario = opiniao,
                Email = email,
                Telefone = telefone
            };
        }
    }
}