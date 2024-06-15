using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }
        public int Radius { get;  set; } // Added new property

        public Moon(MoonDto moonDto)
        {
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
        }
    }
}
