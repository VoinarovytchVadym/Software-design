namespace Agent
{
    public class CommandCenter : ICommandCenter
    {
        private readonly List<Runway> _runways = new List<Runway>();

        public CommandCenter(IEnumerable<Runway> runways)
        {
            _runways.AddRange(runways);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            var availableRunway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft == null);
            if (availableRunway != null)
            {
                aircraft.Land();
                availableRunway.IsBusyWithAircraft = aircraft;
                availableRunway.HighLightRed();
            }
            else
            {
                Console.WriteLine($"No available runway for aircraft {aircraft.Name} to land.");
            }
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            var runway = _runways.FirstOrDefault(r => r.IsBusyWithAircraft == aircraft);
            if (runway != null)
            {
                aircraft.TakeOff();
                runway.IsBusyWithAircraft = null;
                runway.HighLightGreen();
            }
            else
            {
                Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway to take off.");
            }
        }
    }
}