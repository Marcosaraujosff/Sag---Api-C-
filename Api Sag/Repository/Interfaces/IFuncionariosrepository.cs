using Api_Sag.Models.Dtos;
using Api_Sag.Models.Entities;

namespace Api_Sag.Repository.Interfaces
{
    public interface IFuncionariosrepository 
    {
        Task<IEnumerable<FuncionariosDto>> BuscarProfissionais();
        Task<Funcionarios> BuscarProfissionaisPorId(int id);
    }
}
