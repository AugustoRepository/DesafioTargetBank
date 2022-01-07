using DesafioTarget.Presentation.Models.Pessoa;
using DesafioTarget.Presentation.Security;
using DesafioTarget.Repository.Entities;
using DesafioTarget.Repository.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTarget.Presentation.Controllers
{
    [ApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(InsertPessoaModel model,
            [FromServices] PessoaRepository pessoaRepository )
        {
            try
            {
                var pessoa = new Pessoa();

                pessoa.Nome_Completo = model.NomeCompleto;
                pessoa.Cpf = model.Cpf;
                pessoa.Data_Nascimento = model.DataNascimento;
                pessoa.Data_Cadastro = DateTime.Now;
                pessoa.Renda_Mensal = model.RendaMensal;

                pessoaRepository.Insert(pessoa);

                return Ok("Pessoa cadastrado com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(UpDatePessoaModel model,
            [FromServices] PessoaRepository pessoaRepository)
        {
            var pessoa = pessoaRepository.GetById(model.PessoaId);
            try
            {
                if (pessoa != null)
                {
                    pessoa.Nome_Completo = model.NomeCompleto;
                    pessoa.Cpf = model.Cpf;
                    pessoa.Data_Nascimento = model.DataNascimento;
                    pessoa.Data_Cadastro = DateTime.Now;
                    pessoa.Renda_Mensal = model.RendaMensal;

                    pessoaRepository.Update(pessoa);

                    return Ok("Pessoa Aleterado com sucesso");
                }
                else
                {
                    return StatusCode(400, "Pessoa nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id,
            [FromServices] PessoaRepository pessoaRepository)
        {
            try
            {
                var pessoa = pessoaRepository.GetById(id);
                if (pessoa != null)
                {
                    pessoaRepository.Excluir(pessoa);
                    return Ok("Pessoa Excluida com sucesso");
                }
                else
                {
                    return StatusCode(400, "Pessoa nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }

        [ProducesResponseType(typeof(List<GetPessoaModel>), 200)]
        [HttpGet]
        public IActionResult GetAll(
            [FromServices] PessoaRepository pessoaRepository)
        {
            try
            {
                var consulta = pessoaRepository.GetAll();
                var result = new List<GetPessoaModel>();
                foreach (var item in consulta)
                {
                    var model = new GetPessoaModel();

                    model.PessoaId = item.Pessoa_Id;
                    model.NomeCompleto = item.Nome_Completo;
                    model.Cpf = item.Cpf;
                    model.DataNascimento = item.Data_Nascimento;
                    model.DataCadastro = item.Data_Cadastro;
                    model.RendaMensal = item.Renda_Mensal;

                    result.Add(model);
                }
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id,
            [FromServices] PessoaRepository pessoaRepository)
        {
            try
            {
                var pessoa = pessoaRepository.GetById(id);
                if (pessoa != null)
                {
                    var model = new GetPessoaModel();

                    model.PessoaId = pessoa.Pessoa_Id;
                    model.NomeCompleto = pessoa.Nome_Completo;
                    model.Cpf = pessoa.Cpf;
                    model.DataNascimento = pessoa.Data_Nascimento;
                    model.DataCadastro = pessoa.Data_Cadastro;
                    model.RendaMensal = pessoa.Renda_Mensal;

                    return Ok(model);
                }
                else
                {
                    return StatusCode(500, "Pessoa não encontrada.");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
          
        }
    }
}
