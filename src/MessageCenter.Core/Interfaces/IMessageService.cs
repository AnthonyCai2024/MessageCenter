using MessageCenter.Core.Models;

namespace MessageCenter.Core.Interfaces;

public interface IMessageService
{
    Task SendMessageAsync(MessagePayload payload);
}