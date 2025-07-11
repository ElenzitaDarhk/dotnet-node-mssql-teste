using ApiTeste.Domain.Entities;
using ApiTeste.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTeste.Application.Services
{
    public class AlunoService
    {
        private readonly AlunoRepository _repository;

        public AlunoService(AlunoRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Aluno>> ListarAlunosAsync()
            => _repository.GetAllAsync();

        public Task<Aluno?> BuscarAlunoPorIdAsync(int id)
            => _repository.GetByIdAsync(id);

        public Task InserirAlunoAsync(Aluno aluno)
            => _repository.AddAsync(aluno);

        public Task AlterarAlunoAsync(Aluno aluno)
            => _repository.UpdateAsync(aluno);

        public Task ExcluirAlunoAsync(int id)
            => _repository.DeleteAsync(id);
    }
}
