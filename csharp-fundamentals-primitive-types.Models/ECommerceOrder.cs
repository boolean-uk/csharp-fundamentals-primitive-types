namespace csharp_fundamentals_primitive_types.Models;

public class ECommerceOrder
{
    public uint Id { get; set; } = 9129;
    public ECommerceProduct product { get; set; } = new ECommerceProduct();
    public User user = new User();

}
