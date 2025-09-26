using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prova.Dominio;
using Prova.Servico;

namespace Prova.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoServico _servico;

        public AlunoController(IAlunoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            _servico.Adicionar(aluno);
            return Ok("Aluno cadastrado com sucesso!");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.Listar());
        }
    }
}
