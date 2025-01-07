namespace csharp_fundamentals_primitive_types.Models;

public class Car
{
    public string Make = "Volvo";
    public string Model = "V50";
    public string TransmissionType = "Automatic";
    public int NumberOfDoors = 5;
    public float EngineVolume = 1.8f;
    public string EngineType = "Diesel";
    public Tuple<byte, byte, byte> Colour = new (15,23,66); // Represents RGB, 1 pixel has 3 channels, each channel is 1 byte. Arbitrary default value. Dont even know what colour it is.
    public string Registration = "ABC 123"; // Swedish Format 
}
