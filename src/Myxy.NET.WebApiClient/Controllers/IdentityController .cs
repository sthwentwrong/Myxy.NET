using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

[Route("api/[controller]")]
[ApiController]
[Authorize()]
public class IdentityController : ControllerBase
{
    private readonly ILogger<IdentityController> _logger;
    public IdentityController(ILogger<IdentityController> logger)
    {
        _logger = logger;
        _logger.LogInformation("enter IdentityController constructor");
    }

    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("enter Get in IdentityController");
        return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
    }
}