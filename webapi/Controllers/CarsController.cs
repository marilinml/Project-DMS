
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class CarsController : ControllerBase
{

    private readonly Services.Services _service;

    public CarsController(Services.Services service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IEnumerable<Models.Cars>> Get(Dealer dealerId, string search = "", string sort = "")
    {
        return await _service.GetDealerCars((int)dealerId, count: 50, search, sort);
    }

    public enum Dealer
    {
        Dealer1 = 1,
        Dealer2 = 2
    }
}
