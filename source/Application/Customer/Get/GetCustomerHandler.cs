namespace Architecture.Application;

public sealed record GetCustomerHandler : IHandler<GetCustomerRequest, CustomerModel>
{
    private readonly ICustomerRepository _customerRepository;

    public GetCustomerHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

    public async Task<Result<CustomerModel>> HandleAsync(GetCustomerRequest request)
    {
        var customer = await _customerRepository.GetModelAsync(request.Id);

        return Result<CustomerModel>.Success(customer);
    }
}
