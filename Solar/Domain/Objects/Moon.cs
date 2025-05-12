using System;
using Solar.Domain.DataTransferObjects;

namespace Solar.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }
        public float AverageTemperature { get; set; }

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
            AverageTemperature = moonDto.AverageTemperature;
        }
    }
}
