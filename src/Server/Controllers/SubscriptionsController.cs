using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.Services;

namespace Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionService _service;

    public SubscriptionsController(SubscriptionService service)
    {
        _service = service;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Subscription>> Get()
    {
        return Ok(_service.GetAll());
    }

    [HttpPost]
    public ActionResult<Subscription> Post([FromBody] AddSubscriptionRequest req)
    {
        if (req == null || string.IsNullOrWhiteSpace(req.Url))
        {
            return BadRequest(new { error = "url is required" });
        }
        var created = _service.Add(req.Url.Trim());
        return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
    }
}
