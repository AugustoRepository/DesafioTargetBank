using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTarget.Repository.Entities
{
    public class PlanoVip
    {
        public int PlanoVipId { get; set; }
        public int PessoaId { get; set; }
        public float Valor { get; set; }

        public bool VipAtivo { get; set; }
        #region Relacionamentos
        public List<Pessoa> Pessoas { get; set; }
        #endregion
    }
}
