using DesafioTarget.Presentation.Models.Endereco;
using DesafioTarget.Presentation.Security;
using DesafioTarget.Repository.Entities;
using DesafioTarget.Repository.Repositories;
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
    public class EnderecoController : ControllerBase
    {
       [HttpPost]
       public IActionResult Post(InsertEnderecoModel model,
           [FromServices] EnderecoRepository enderecoRepository)
       {
            try
            {
                var endereco = new Endereco();

                endereco.Logradouro = model.Logradouro;
                endereco.Cep = model.Cep;
                endereco.Cidade = model.Cidade;
                endereco.Uf = model.Uf;
                endereco.Complemento = model.Complemento;
                endereco.Bairro = model.Bairro;
                endereco.Pessoa_ID = model.PessoaID;

                enderecoRepository.Update(endereco);
                return Ok("Endereco cadastrado com sucesso");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
       }

        [HttpPut]
        public IActionResult Put(UpDateEnderecoModel model,
          [FromServices] EnderecoRepository enderecoRepository)
        {
            try
            {
                var endereco = enderecoRepository.GetById(model.EnderecoId);
                if (endereco != null)
                {
                    endereco.Logradouro = model.Logradouro;
                    endereco.Cep = model.Cep;
                    endereco.Cidade = model.Cidade;
                    endereco.Uf = model.Uf;
                    endereco.Complemento = model.Complemento;
                    endereco.Bairro = model.Bairro;
                    endereco.Pessoa_ID = model.PessoaID;

                    enderecoRepository.Update(endereco);

                    return Ok("Endereco atualizado com sucesso");
                }
                else
                {
                    return StatusCode(400, "Endereco nao cadastrada no sistema");
                }

            }
             catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }


        [HttpDelete]
        public IActionResult Delete(int id,
          [FromServices] EnderecoRepository enderecoRepository)
        {
            try
            {
                var endereco = enderecoRepository.GetById(id);
                if (endereco != null)
                {
                    enderecoRepository.Excluir(endereco);
                    return Ok("Endereco Excluido com sucesso");
                }
                else
                {
                    return StatusCode(400, "Endereco nao cadastrada no sistema");
                }
              
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }
        [HttpGet]
        public IActionResult GetAll(
            [FromServices] EnderecoRepository enderecoRepository)
        {
            try
            {
                var consulta = enderecoRepository.GetAll();
                var result = new List<GetEnderecoModel>();
                foreach (var item in consulta)
                {
                    var model = new GetEnderecoModel();
                    model.EnderecoId = item.Endereco_Id;
                    model.Logradouro = item.Logradouro;
                    model.Cep = item.Cep;
                    model.Cidade = item.Cidade;
                    model.Uf = item.Uf;
                    model.Complemento = item.Complemento;
                    model.Bairro = item.Bairro;
                    model.PessoaID = item.Pessoa_ID;
                   
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
            [FromServices] EnderecoRepository enderecoRepository)
        {
            try
            {
                var endereco = enderecoRepository.GetById(id);
                if (endereco != null)
                {
                    var model = new GetEnderecoModel();
                    model.EnderecoId = endereco.Endereco_Id;
                    model.Logradouro = endereco.Logradouro;
                    model.Cep = endereco.Cep;
                    model.Cidade = endereco.Cidade;
                    model.Uf = endereco.Uf;
                    model.Complemento = endereco.Complemento;
                    model.Bairro = endereco.Bairro;
                    model.PessoaID = endereco.Pessoa_ID;
                    return Ok(model);
                }
                else
                {
                    return StatusCode(400, "Endereco nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
            
        }
    }
}

