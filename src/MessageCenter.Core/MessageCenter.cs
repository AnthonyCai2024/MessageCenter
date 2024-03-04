using MessageCenter.Core.Interfaces;
using MessageCenter.Core.Models;
using Microsoft.Extensions.DependencyInjection;

namespace MessageCenter.Core;

public class MessageCenter(IServiceProvider serviceProvider)
{
    public async Task SendMessageAsync(MessagePayload payload)
    {
        var service = serviceProvider.GetServices<IMessageService>()
            .FirstOrDefault(s => s.GetType().Name.StartsWith(payload.Type, StringComparison.OrdinalIgnoreCase));

        if (service == null)
        {
            throw new InvalidOperationException($"No message service found for type {payload.Type}");
        }
        
        await service.SendMessageAsync(payload);
    }
}