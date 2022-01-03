using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTarget.Repository.Entities
{
    public class Endereco
    {
        public int EnderecoId { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Complemento { get; set; }
        public string PessoaID { get; set; }

        #region Relacionamentos
        public Pessoa Pessoa { get; set; }
        #endregion
    }
}
