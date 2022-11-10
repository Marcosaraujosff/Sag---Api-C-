using Api_Sag.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api_Sag.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionariosController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CadastrarNovoFuncionario(Funcionarios funcionarios)
        {
            if(funcionarios == null)
            {
                return BadRequest("Ops, faltam dados necessarios a serem informados");
            }

            var funcionarioAdicionar = new Funcionarios
            {
                Nome = funcionarios.Nome,
                Email = funcionarios.Email,
                Cargo = funcionarios.Cargo,
                Salario = funcionarios.Salario,
                Senioridade = funcionarios.Senioridade,
            };

            return Ok(funcionarioAdicionar);
        }
    }
}
