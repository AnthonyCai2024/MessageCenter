using MessageCenter.Core.Interfaces;
using MessageCenter.Core.Models;

namespace MessageCenter.Core.Services;

public class SmsService : IMessageService
{
    public async Task SendMessageAsync(MessagePayload payload)
    {
        // 实现发送邮件的逻辑
        Console.WriteLine($"Sending SMS to {payload.Destination}: {payload.Content}");
        await Task.CompletedTask;
    }
}