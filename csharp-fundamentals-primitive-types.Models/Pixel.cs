namespace csharp_fundamentals_primitive_types.Models;

public class Pixel
{
    public Tuple<byte, byte, byte> RGB {get;set;} = new(16,255,2);
    public Tuple<int,int> Location { get; set; } = new(14,55);
}
