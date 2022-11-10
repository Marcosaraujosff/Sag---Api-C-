using Api_Sag.Context;
using Api_Sag.Models.Dtos;
using Api_Sag.Models.Entities;
using Api_Sag.Repository.Interfaces;

namespace Api_Sag.Repository
{
    public class FuncionariosRepository : BaseRepository, IFuncionariosrepository
    {
        private readonly SagContext _context;

        public FuncionariosRepository(SagContext context) : base(context)
        {
            _context = context;
        }

        public Task<IEnumerable<FuncionariosDto>> BuscarProfissionais()
        {
            throw new NotImplementedException();
        }

        public Task<Funcionarios> BuscarProfissionaisPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
