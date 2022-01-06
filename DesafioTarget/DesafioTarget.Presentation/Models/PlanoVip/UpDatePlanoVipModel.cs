using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.PlanoVip
{
    public class UpDatePlanoVipModel
    {
        [Required(ErrorMessage = "Por favor, informe o PessoaId.")]
        public int PlanoVipId { get; set; }

        [Required(ErrorMessage = "Por favor, informe o PessoaId.")]
        public int PessoaId { get; set; }
        public float Valor { get; set; }
        [Required(ErrorMessage = "Por favor, informe o PessoaId.")]
        public bool VipAtivo { get; set; }
    }
}
