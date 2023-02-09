namespace Architecture.Application;

public sealed record AddCustomerHandler : IHandler<AddCustomerRequest, long>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddCustomerHandler
    (
        ICustomerRepository customerRepository,
        IUnitOfWork unitOfWork
    )
    {
        _customerRepository = customerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<long>> HandleAsync(AddCustomerRequest request)
    {
        var customer = new Customer(request.Name);

        await _customerRepository.AddAsync(customer);

        await _unitOfWork.SaveChangesAsync();

        return Result<long>.Success(customer.Id);
    }
}
