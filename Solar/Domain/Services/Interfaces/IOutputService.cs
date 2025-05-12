namespace Solar.Domain.Services.Interfaces
{
    ///<summary>
    /// An output service that can show data from the Solar System OpenData API<see href="https://api.le-systeme-solaire.net/"/> to a user via the console. 
    ///</summary>
    public interface IOutputService
    {
        void OutputAllPlanetsAndTheirAverageMoonTemperatureToConsole();
        void OutputAllPlanetsAndTheirMoonsToConsole();
        void OutputAllMoonsAndTheirMassToConsole();
        void OutputAllPlanetsAndTheirAverageMoonGravityToConsole();
    }
}
