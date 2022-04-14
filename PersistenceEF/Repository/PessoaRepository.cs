

using Domain.Common;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using PersistenceEF.DataContext;

namespace PersistenceEF.Repository
{
    public class PessoaRepository : IRepository<Pessoa>
    {
        private EF_DataContext _context;

        public PessoaRepository(EF_DataContext context)
        {
            _context = context;
        }
        public IReadOnlyCollection<Pessoa> ObterTodos()
        {
            //return _context.Pessoas.AsNoTracking().Include(e => e.Itens).ToList().AsReadOnly();
            return _context.Pessoas.AsNoTracking().OrderBy(e => e.Nome).Include(e => e.Contato).ToList().AsReadOnly();
        }


        public Pessoa Gravar(Pessoa obj)
        {
            if (obj.PessoaID == null)
            {
                obj.PessoaID = Guid.NewGuid();
                _context.Pessoas.Add(obj);
            }
            else
            {
                _context.Update(obj);
            }
            _context.SaveChanges();
            return obj;
        }

        public Pessoa ObterPorID(Guid? ID)
        {
            throw new NotImplementedException();
        }

        public void Remover(Pessoa obj)
        {
            _context.Pessoas.Remove(obj);
            _context.SaveChanges();
        }
    }
}
