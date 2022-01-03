using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.PlanoVip
{
    public class InsertPlanoVip
    {

        [Required(ErrorMessage = "Por favor, informe o PessoaId.")]
        public int PessoaId { get; set; }
        [Required(ErrorMessage = "Por favor, informe o PessoaId.")]
        public float Valor { get; set; }
        [Required(ErrorMessage = "Por favor, informe o PessoaId.")]
        public bool VipAtivo { get; set; }
    }
}
