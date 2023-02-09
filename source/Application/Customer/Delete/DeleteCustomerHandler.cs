namespace Architecture.Application;

public sealed record DeleteCustomerHandler : IHandler<DeleteCustomerRequest>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCustomerHandler
    (
        ICustomerRepository customerRepository,
        IUnitOfWork unitOfWork
    )
    {
        _customerRepository = customerRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> HandleAsync(DeleteCustomerRequest request)
    {
        await _customerRepository.DeleteAsync(request.Id);

        await _unitOfWork.SaveChangesAsync();

        return Result.Success();
    }
}
