using MessageCenter.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageCenter.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MessagesController(Core.MessageCenter messageCenter) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody] MessagePayload payload)
    {
        try
        {
            await messageCenter.SendMessageAsync(payload);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}