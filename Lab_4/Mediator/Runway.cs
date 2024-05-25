namespace Agent
{
    public class Runway
    {
        private readonly Guid _id = Guid.NewGuid();
        public Aircraft? IsBusyWithAircraft { get; set; }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {_id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {_id} is free!");
        }
    }
}