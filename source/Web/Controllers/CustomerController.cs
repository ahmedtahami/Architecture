namespace Architecture.Web;

[ApiController]
[Route("api/customers")]
public sealed class CustomerController : BaseController
{
    [HttpPost]
    public IActionResult Add(AddCustomerRequest request) => Mediator.HandleAsync<AddCustomerRequest, long>(request).ApiResult();

    [HttpDelete("{id:long}")]
    public IActionResult Delete(long id) => Mediator.HandleAsync(new DeleteCustomerRequest(id)).ApiResult();

    [HttpGet("{id:long}")]
    public IActionResult Get(long id) => Mediator.HandleAsync<GetCustomerRequest, CustomerModel>(new GetCustomerRequest(id)).ApiResult();

    [HttpGet("grid")]
    public IActionResult Grid([FromQuery] GridCustomerRequest request) => Mediator.HandleAsync<GridCustomerRequest, Grid<CustomerModel>>(request).ApiResult();

    [HttpGet]
    public IActionResult List() => Mediator.HandleAsync<ListCustomerRequest, IEnumerable<CustomerModel>>(new ListCustomerRequest()).ApiResult();

    [HttpPut("{id:long}")]
    public IActionResult Update(UpdateCustomerRequest request) => Mediator.HandleAsync(request).ApiResult();
}
