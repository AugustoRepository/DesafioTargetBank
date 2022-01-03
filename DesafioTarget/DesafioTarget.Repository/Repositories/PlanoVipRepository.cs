using Dapper;
using DesafioTarget.Repository.Contracts;
using DesafioTarget.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DesafioTarget.Repository.Repositories
{
    public class PlanoVipRepository : IPlanoVipRepository
    {
        private readonly string _connectionString;

        public PlanoVipRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }
        public void Insert(PlanoVip obj)
        {
            var query = "INSERT INT PLANO_VIP (VALOR, VIP_ATIVO, PESSOA_ID)" +
                "VALUES (@VALOR, TRUE, @PESSOA_ID)";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);

            }
        }

        public void Update(PlanoVip obj)
        {
            var query = "UPDATE INTO PLANO_VIP SET VALOR = @VALOR, VIP_ATIVO = @VIP_ATIVO, PESSOA_ID = @PESSOA_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, obj);

            }
        }

        public void Excluir(PlanoVip obj)
        {
            var query = "DELETE FROM PLANO_VIP WHERE PLANO_ID = @PLANO_ID";
            using (var connection = new SqlConnection(_connectionString))
            {
               
                connection.Execute(query, obj);
            }
        }

        public List<PlanoVip> GetAll()
        {
            var query = "SELECT * FROM PLANO_VIP";
            using (var connection = new SqlConnection(_connectionString))
            {
                
                return connection.Query<PlanoVip>(query).ToList();

            }
        }

        public PlanoVip GetById(int id)
        {
            var query = "SELECT * FROM PLANO_VIP WHERE PALNO_ID = PLANO_ID";

            using (var connection = new SqlConnection(_connectionString))
            {

                return connection.Query(query).FirstOrDefault();
            }
        }
    }
}
