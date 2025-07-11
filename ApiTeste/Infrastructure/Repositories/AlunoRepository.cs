using ApiTeste.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiTeste.Infrastructure.Repositories
{
    public class AlunoRepository
    {
        private readonly DbContext _context;
        public AlunoRepository(DbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Aluno>> GetAllAsync()
        {
            return await _context.Set<Aluno>().ToListAsync();
        }

        public async Task<Aluno?> GetByIdAsync(int id)
        {
            return await _context.Set<Aluno>().FindAsync(id);
        }

        public async Task AddAsync(Aluno aluno)
        {
            await _context.Set<Aluno>().AddAsync(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Aluno aluno)
        {
            _context.Set<Aluno>().Update(aluno);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var aluno = await GetByIdAsync(id);
            if (aluno != null)
            {
                _context.Set<Aluno>().Remove(aluno);
                await _context.SaveChangesAsync();
            }
        }
    }
}
