using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.Pessoa
{
    public class InsertPessoa
    {
        [MinLength(6, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string NomeCompleto { get; set; }
        [MinLength(11, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(11, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public string DataNascimento { get; set; }
        public string DataCadastro { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        public float RendaMensal { get; set; }

    }
}
