using Lab_2.task_1.subscriptions;

namespace Lab_2.task_1.subscriptionsCreators;

class ManagerCallSubscriptionCreator : ISubscriptionCreator
{
    private const string Details = "Subscription via Call";

    public ISubscription CreateSubscription(SubscriptionType type, int subscriptionPeriod)
    {
        return type switch
        {
            SubscriptionType.DomesticSubscription => subscriptionPeriod >= 12
                ? new DomesticSubscription(200, subscriptionPeriod, 150, Details)
                : new DomesticSubscription(300, subscriptionPeriod, 150, Details),
            SubscriptionType.EducationalSubscription => subscriptionPeriod >= 12
                ? new EducationalSubscription(300, subscriptionPeriod, 250, Details)
                : new EducationalSubscription(400, subscriptionPeriod, 250, Details),
            SubscriptionType.PremiumSubscription => subscriptionPeriod >= 12
                ? new PremiumSubscription(400, subscriptionPeriod, 400, Details)
                : new PremiumSubscription(600, subscriptionPeriod, 400, Details),
            _ => throw new NotImplementedException($"Unknown type {type}")
        };
    }
}