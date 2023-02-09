namespace Architecture.Application;

public sealed class GridCustomerRequestValidator : AbstractValidator<GridCustomerRequest>
{
    public GridCustomerRequestValidator() => RuleFor(request => request).Grid();
}
