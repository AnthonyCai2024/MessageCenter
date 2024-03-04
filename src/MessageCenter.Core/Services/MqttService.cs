using MessageCenter.Core.Interfaces;

namespace MessageCenter.Core.Services;

public class MqttService : IMessageService
{
    public Task SendMessageAsync(string recipient, string message)
    {
        // 实现发送短信的逻辑
        Console.WriteLine($"Sending Mqtt to {recipient}: {message}");
        return Task.CompletedTask;
    }
}