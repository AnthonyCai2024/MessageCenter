using MessageCenter.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageCenter.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MessagesController(Core.MessageCenter messageCenter) : ControllerBase
{
    [HttpPost(Name = "SendMessage")]
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

    [HttpGet(Name = "GetMessageHistory")]
    public async Task<IActionResult> GetMessageHistory()
    {
        return Ok();
    }
}