namespace MessageCenter.Core.Interfaces;

public interface IMessageService
{
    Task SendMessageAsync(string recipient, string message);
}