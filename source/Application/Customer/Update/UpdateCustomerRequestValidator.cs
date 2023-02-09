namespace Architecture.Application;

public sealed class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
{
    public UpdateCustomerRequestValidator()
    {
        RuleFor(request => request.Id).Id();
        RuleFor(request => request.Name).Name();
    }
}
