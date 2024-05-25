namespace Agent;

public interface ICommandCenter
{
    void RequestLanding(Aircraft aircraft);
    void RequestTakeOff(Aircraft aircraft);
}