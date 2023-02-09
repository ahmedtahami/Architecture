namespace Architecture.Application;

public sealed record UpdateCustomerHandler : IHandler<UpdateCustomerRequest>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ICustomerRepository _customerRepository;

    public UpdateCustomerHandler
    (
        IUnitOfWork unitOfWork,
        ICustomerRepository customerRepository
    )
    {
        _unitOfWork = unitOfWork;
        _customerRepository = customerRepository;
    }

    public async Task<Result> HandleAsync(UpdateCustomerRequest request)
    {
        var customer = new Customer(request.Id, request.Name);

        await _customerRepository.UpdateAsync(customer);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
