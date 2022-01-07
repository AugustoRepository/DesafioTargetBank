using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTarget.Repository.Entities
{
    public class PlanoVip
    {
        public int Plano_Vip_Id { get; set; }
        public int Pessoa_Id { get; set; }
        public float Valor { get; set; }

        public bool Vip_Ativo { get; set; }
        #region Relacionamentos
        public List<Pessoa> Pessoas { get; set; }
        #endregion
    }
}
