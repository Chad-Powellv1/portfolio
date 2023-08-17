using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Api.Controllers;

/// <summary name="ErrorsController">
/// The controller for errors.
/// </summary>
public class ErrorsController : ControllerBase
{

    [Route("/error")]

    public IActionResult Error()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem();
    }
}