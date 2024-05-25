using Lab_2.task_1.subscriptions;

namespace Lab_2.task_1.subscriptionsCreators;
public enum SubscriptionType
{
    DomesticSubscription,
    EducationalSubscription,
    PremiumSubscription,
}
interface ISubscriptionCreator
{
    
    public ISubscription CreateSubscription(SubscriptionType type, int subscriptionPeriod);
}