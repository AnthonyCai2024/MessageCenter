namespace MessageCenter.Core.Models;

public class MessagePayload
{
    public required string Type { get; set; } // 如 "email", "sms", "mqtt", 等
    public required string Destination { get; set; } // 收件人地址或主题
    public required string Content { get; set; } // 消息内容
}