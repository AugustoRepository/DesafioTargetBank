using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.Endereco
{
    public class UpDateEnderecoModel
    {
        [Required(ErrorMessage = "Por favor, informe seu Logradouro.")]
        public int EnderecoId { get; set; }
        [MinLength(4, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu Logradouro.")]
        public string Logradouro { get; set; }
        [MinLength(4, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu Bairro.")]
        public string Bairro{ get; set; }
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(8, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu Cep.")]
        public string Cep { get; set; }
        [MinLength(4, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu Cidade.")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu Cidade.")]
        public string Uf { get; set; }
        [MinLength(4, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe seu Cidade.")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Por favor, informe seu Cidade.")]
        public int PessoaID { get; set; }
    }
}
