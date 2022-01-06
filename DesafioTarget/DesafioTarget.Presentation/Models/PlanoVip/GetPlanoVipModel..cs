using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Models.PlanoVip
{
    public class GetPlanoVip
    {
        public int PlanoVipId { get; set; }
        public int PessoaId { get; set; }
        public float Valor { get; set; }
        public bool VipAtivo { get; set; }
    }
}
