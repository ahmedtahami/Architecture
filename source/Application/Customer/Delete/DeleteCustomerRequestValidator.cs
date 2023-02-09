namespace Architecture.Application;

public sealed class DeleteCustomerRequestValidator : AbstractValidator<DeleteCustomerRequest>
{
    public DeleteCustomerRequestValidator() => RuleFor(request => request.Id).Id();
}
