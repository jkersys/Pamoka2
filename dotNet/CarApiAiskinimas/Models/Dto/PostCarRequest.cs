using System.ComponentModel.DataAnnotations;

public class PostCarRequest
{
    [MaxLength(50, ErrorMessage = "Mark cannot be lomger than 50 characters")]
    public string Mark { get; set; }
    [MaxLength(50, ErrorMessage = "Mark cannot be lomger than 50 characters")]
    public string Model { get; set; }
    /// <summary>
    /// Automobilio pagaminimo metai formatu yyyy-MM-dd
    /// </summary>
    [Range(typeof(DateTime), "1900-01-01", "2021-01-01", ErrorMessage = "Year must be between 1900-01-01 and 2021-01-01")]
    public string Year { get; set; }
    [MaxLength(20, ErrorMessage = "Mark cannot be lomger than 20 characters")]
    public string? PlateNumber { get; set; }
    /// <summary>
    /// Autotomobilio pavaru dezes tipas. Galimos reiksmes Manual ir Automatic
    /// </summary>
    [MaxLength(15, ErrorMessage = "Mark cannot be lomger than 15 characters")]
    public string GearBox { get; set; }
    /// <summary>
    /// Automobilio kuro tipas. Galimos reiksmes Petrol, Diesel ir Electric
    /// </summary>
    [MaxLength(15, ErrorMessage = "Mark cannot be lomger than 15 characters")]
    public string Fuel { get; set; }
}

