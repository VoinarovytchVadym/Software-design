namespace Lab_2.task_1.subscriptions;

public class PremiumSubscription (double price, int subscriptionPeriod, int channelsCount, string details)
    : ISubscription
{
    public double Price { get; set; } = price;
    public int SubscriptionPeriod { get; set; } = subscriptionPeriod;
    public int ChannelsCount { get; set; } = channelsCount;
    public string Details { get; set; } = details;
    
    public void Info()
    {
        Console.WriteLine($"Price: {Price}");
        Console.WriteLine($"SubscriptionPeriod: {SubscriptionPeriod}");
        Console.WriteLine($"Channels count: {ChannelsCount}");
        Console.WriteLine($"Details: {Details}");
    }
}