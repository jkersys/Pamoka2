namespace CarApiAiskinimas.Models.Dto
{
    public class FilterCarRequest
    {
        public string? Mark { get; set; }
        public string? Model { get; set; }
        public string? GearBox { get; set; }
        /// <summary>
        /// Automobilio kuro tipas. Galimos reiksmes Petrol, Diesel ir Electric
        /// </summary>
        public string? Fuel { get; set; }

    }

}

