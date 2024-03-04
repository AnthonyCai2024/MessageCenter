using MessageCenter.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageCenter.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MyController : ControllerBase
{
    // 使用路由名称
    [HttpGet(Name = "GetItems")]
    public IActionResult GetItems()
    {
        // 方法实现
        return Ok();
    }

    // 或者，使用路由模板
    [HttpGet("items/{id}", Name = "GetItemById")]
    public IActionResult GetItemById(int id)
    {
        // 方法实现
        return Ok();
    }

    // 对于其他的HTTP方法也是类似的
    [HttpPost("items", Name = "CreateItem")]
    public IActionResult CreateItem([FromBody] MessagePayload payload)
    {
        // 方法实现
        return Ok();
    }
}