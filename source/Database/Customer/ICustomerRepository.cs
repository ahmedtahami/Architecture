namespace Architecture.Database;

public interface ICustomerRepository : IRepository<Customer>
{
    Task<CustomerModel> GetModelAsync(long id);

    Task<Grid<CustomerModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<CustomerModel>> ListModelAsync();
}
