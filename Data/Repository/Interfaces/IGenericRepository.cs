namespace ProductCatalog.Data.Repository.Interfaces;
public interface IGenericRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    Task<T> GetById(Guid id);
    Task Create(T entity);
    void Update(T entity);
    Task Delete(Guid id);
    Task Save();
}