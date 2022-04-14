namespace Domain.Repository
{
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> ObterTodos();
        public T ObterPorID(Guid? ID);
        public T Gravar(T obj);
        public void Remover(T obj);
    }
}
