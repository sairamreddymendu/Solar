using System.Collections.Generic;
using Solar.Domain.DataTransferObjects;
using Solar.Domain.Objects;

namespace Solar.Domain.Services.Interfaces
{
    ///<summary>
    /// A service that can be used to get data from the Solar System OpenData API<see href="https://api.le-systeme-solaire.net/"/>. 
    ///</summary>
    public interface IPlanetService
    {
        IEnumerable<Planet> GetAllPlanets();
    }
}
