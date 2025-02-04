using WebAPI_Video.Models;

namespace WebAPI_Video.Service.FuncionarioService
{
    public interface IFuncionarioInterface
    {
        Task<ServiceResponse<List<FuncionarioModel>>> GetFuncioarios();

        Task<ServiceResponse<List<FuncionarioModel>>> CreateFuncioario(FuncionarioModel novoFuncionario);

        Task<ServiceResponse<FuncionarioModel>> GetFuncioarioById(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> UpdateFuncioario(FuncionarioModel editadoFuncionario);

        Task<ServiceResponse<List<FuncionarioModel>>> DeleteFuncioario(int id);

        Task<ServiceResponse<List<FuncionarioModel>>> InativaFuncioario(int id);


    }
}
