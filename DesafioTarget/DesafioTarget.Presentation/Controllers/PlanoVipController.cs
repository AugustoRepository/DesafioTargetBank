using DesafioTarget.Presentation.Models.PlanoVip;
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
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoVipController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(InsertPlanoVipModel model,
            [FromServices] PlanoVipRepository planoVipRepository)
        {
            try
            {
                var planoVip = new PlanoVip();

                planoVip.Pessoa_Id = model.PessoaId;
                planoVip.Valor = model.Valor;
                planoVip.Vip_Ativo = model.VipAtivo;

                planoVipRepository.Insert(planoVip);
                return Ok("Cliente aderiu plano vip");
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }
        [HttpPut]
        public IActionResult Put(UpDatePlanoVipModel model,
            [FromServices] PlanoVipRepository planoVipRepository)
        {
            try
            {
                var planoVip = planoVipRepository.GetById(model.PlanoVipId);
                if (planoVip != null)
                {
                    planoVip.Pessoa_Id = model.PessoaId;
                    planoVip.Vip_Ativo = model.VipAtivo;
                    planoVip.Valor = model.Valor;

                    return Ok("Plano Vip Altereado com sucesso");
                }
                else
                {
                    return StatusCode(400, "Plano Vip nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id,
            [FromServices] PlanoVipRepository planoVipRepository)
        {
            try
            {
                var planoVip = planoVipRepository.GetById(id);
                if (planoVip != null)
                {
                    planoVipRepository.Excluir(planoVip);
                    return Ok("Plano vip Excluido com sucesso");
                    
                }
                else
                {
                    return StatusCode(400, "Plano Vip nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
        }
        [HttpGet]
        public IActionResult GetAll([FromServices] PlanoVipRepository planoVipRepository)
        {
            try
            {
                var consulta = planoVipRepository.GetAll();
                var result = new List<GetPlanoVip>();

                foreach(var item in consulta)
                {
                    var model = new GetPlanoVip();
                    model.PlanoVipId = item.Plano_Vip_Id;
                    model.PessoaId = item.Pessoa_Id;
                    model.Valor = item.Valor;
                    model.VipAtivo = item.Vip_Ativo;                    
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
            [FromServices] PlanoVipRepository planoVipRepository)
        {
            try
            {
                var planoVip = planoVipRepository.GetById(id);
                if (planoVip != null)
                {
                    var model = new GetPlanoVip();
                    model.PlanoVipId = planoVip.Plano_Vip_Id;
                    model.PessoaId = planoVip.Pessoa_Id;
                    model.Valor = planoVip.Valor;
                    model.VipAtivo = planoVip.Vip_Ativo;
                    return Ok(model);
                }
                else
                {
                    return StatusCode(400, "Plano Vip nao cadastrada no sistema");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, "Ocorreu um erro: " + e.Message);
            }
            
        }
    }
}
