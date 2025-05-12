using System.Collections.Generic;
using Newtonsoft.Json;

namespace Solar.Domain.DataTransferObjects
{
    public class PlanetDto
    {
        public string Id { get; set; }
        public float SemiMajorAxis { get; set; }
        public ICollection<MoonDto> Moons { get; set; }
    }
}