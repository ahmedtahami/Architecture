namespace Architecture.Application;

public sealed record ListCustomerHandler : IHandler<ListCustomerRequest, IEnumerable<CustomerModel>>
{
    private readonly ICustomerRepository _customerRepository;

    public ListCustomerHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

    public async Task<Result<IEnumerable<CustomerModel>>> HandleAsync(ListCustomerRequest request)
    {
        var customers = await _customerRepository.ListModelAsync();

        return Result<IEnumerable<CustomerModel>>.Success(customers);
    }
}
