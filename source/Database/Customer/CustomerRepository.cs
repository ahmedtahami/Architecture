namespace Architecture.Database;

public sealed class CustomerRepository : EFRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(Context context) : base(context) { }

    public static Expression<Func<Customer, CustomerModel>> Model => customer => new CustomerModel { Id = customer.Id, Name = customer.Name };

    public Task<CustomerModel> GetModelAsync(long id) => Queryable.Where(customer => customer.Id == id).Select(Model).SingleOrDefaultAsync();

    public Task<Grid<CustomerModel>> GridAsync(GridParameters parameters) => Queryable.Select(Model).GridAsync(parameters);

    public async Task<IEnumerable<CustomerModel>> ListModelAsync() => await Queryable.Select(Model).ToListAsync();
}
