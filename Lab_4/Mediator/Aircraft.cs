using System;

namespace Agent
{
    public class Aircraft(string name)
    {
        public string Name { get; set; } = name;
        public bool IsTakingOff { get; set; }
        public void Land()
        { 
            Console.WriteLine($"Aircraft {Name} is landing.");
        }

        public void TakeOff()
        { 
            Console.WriteLine($"Aircraft {Name} is taking off.");
        }
    }
}