using MessageCenter.Core.Interfaces;

namespace MessageCenter.Core.Services;

public class EmailService : IMessageService
{
    public Task SendMessageAsync(string recipient, string message)
    {
        // 实现发送邮件的逻辑
        Console.WriteLine($"Sending email to {recipient}: {message}");
        return Task.CompletedTask;
    }
}