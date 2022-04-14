
using Domain.Common;
using Domain.Repository;
using Microsoft.EntityFrameworkCore;
using PersistenceEF.DataContext;

namespace PersistenceEF.Repository
{
    public class ContatoRepository : IRepository<Contato>
    {
        private EF_DataContext _context;
        public ContatoRepository(EF_DataContext context)
        {
            _context = context;
        }
        public IReadOnlyCollection<Contato> ObterTodos()
        {
            return _context.Contatos.AsNoTracking().ToList().AsReadOnly();
        }
        public Contato Gravar(Contato obj)
        {
            if (obj.PessoaID == null)
            {
                obj.PessoaID = Guid.NewGuid();
                _context.Contatos.Add(obj);
            }
            else
            {
                _context.Update(obj);
            }
            _context.SaveChanges();
            return obj;
        }

        public Contato ObterPorID(Guid? ID)
        {
            throw new NotImplementedException();
        }


        public void Remover(Contato obj)
        {
            _context.Contatos.Remove(obj);
            _context.SaveChanges();
        }
    }
}
