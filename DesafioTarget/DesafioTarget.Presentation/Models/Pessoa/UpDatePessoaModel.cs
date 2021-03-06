using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DesafioTarget.Presentation.Models.Pessoa
{
    public class UpDatePessoaModel
    {
        public int PessoaId { get; set; }
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string NomeCompleto { get; set; }
        [MinLength(11, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(11, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public DateTime DataNascimento { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public DateTime DataCadastro { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public float RendaMensal { get; set; }
    }
}
