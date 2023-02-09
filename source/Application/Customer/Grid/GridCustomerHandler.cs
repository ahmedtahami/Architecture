namespace Architecture.Application;

public sealed record GridCustomerHandler : IHandler<GridCustomerRequest, Grid<CustomerModel>>
{
    private readonly ICustomerRepository _customerRepository;

    public GridCustomerHandler(ICustomerRepository customerRepository) => _customerRepository = customerRepository;

    public async Task<Result<Grid<CustomerModel>>> HandleAsync(GridCustomerRequest request)
    {
        var grid = await _customerRepository.GridAsync(request);

        return Result<Grid<CustomerModel>>.Success(grid);
    }
}
