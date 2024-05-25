namespace Lab_2.task_1.subscriptions
{
    interface ISubscription
    {
        public double Price { get; set; }
        public int SubscriptionPeriod { get; set; }
        public int ChannelsCount { get; set; }
        public string Details { get; set; }
        
        public void Info();
    }
}

