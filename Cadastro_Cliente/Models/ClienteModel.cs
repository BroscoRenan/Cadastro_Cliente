using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cadastro_Cliente.Models
{ 
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do cliente")]
        [MaxLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o e-mail do cliente")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido")]
        [MaxLength(100, ErrorMessage = "O e-mail deve ter no máximo 100 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite o CPF do cliente")]
        [MaxLength(14, ErrorMessage = "O CPF deve ter no máximo 14 caracteres")]        
        public string CPF { get; set; }

        [Required(ErrorMessage = "Digite o telefone do cliente")]
        [Phone(ErrorMessage = "O telefone informado não é válido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Digite o endereco do cliente (Rua)")]
        [MaxLength(100, ErrorMessage = "O endereço deve ter no máximo 100 caracteres")]
        public string Endereco { get; set; }

        [MaxLength(10, ErrorMessage = "O número deve ter no máximo 10 caracteres")]
        public string Numero { get; set; }

        [MaxLength(50, ErrorMessage = "O complemento deve ter no máximo 50 caracteres")]
        public string Complemento { get; set; }

        [MaxLength(50, ErrorMessage = "O bairro deve ter no máximo 50 caracteres")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Digite a cidade do cliente")]
        [MaxLength(50, ErrorMessage = "O município deve ter no máximo 50 caracteres")]
        public string Municipio { get; set; }

        [Required(ErrorMessage = "Digite o Estado do cliente")]
        [MaxLength(2, ErrorMessage = "A UF deve ter no máximo 2 caracteres")]
        public string UF { get; set; }

        [Required(ErrorMessage = "Digite CEP do cliente")]
        [MaxLength(10, ErrorMessage = "O CEP deve ter no máximo 10 caracteres")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Digite a data de cadastro")]
        [DataType(DataType.Date)]
        public DateTime Data_Cadastro { get; set; }
    }

}
