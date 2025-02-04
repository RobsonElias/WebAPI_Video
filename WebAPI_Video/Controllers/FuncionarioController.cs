using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using WebAPI_Video.Models;
using WebAPI_Video.Service.FuncionarioService;

namespace WebAPI_Video.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IFuncionarioInterface _funcionarioInterface;
        public FuncionarioController(IFuncionarioInterface funcionarioInterface)
        {
            _funcionarioInterface = funcionarioInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> GetFuncioarios()
        {
            return Ok(await _funcionarioInterface.GetFuncioarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<FuncionarioModel>>> GetFuncioarioById(int id)
        {
            ServiceResponse<FuncionarioModel> serviceResponse = await _funcionarioInterface.GetFuncioarioById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> CreateFuncionario(FuncionarioModel novoFuncionario)
        {
            return Ok(await _funcionarioInterface.CreateFuncioario(novoFuncionario));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> UpdateFuncionario(FuncionarioModel editaFuncionario)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.UpdateFuncioario(editaFuncionario);
            return Ok(serviceResponse);
        }

        [HttpPut("inativaFuncionario")]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> InativaFuncionario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.InativaFuncioario(id);
            return Ok(serviceResponse);
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<FuncionarioModel>>>> DeleteFuncioario(int id)
        {
            ServiceResponse<List<FuncionarioModel>> serviceResponse = await _funcionarioInterface.DeleteFuncioario(id);
            return Ok(serviceResponse);
        }
        
    }
}
