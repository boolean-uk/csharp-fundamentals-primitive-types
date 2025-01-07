namespace csharp_fundamentals_primitive_types.Models;

public class SocialMediaPost
{
    public string PostText { get; set; } = "Enjoying the sunset in Bali! Peace!";
    public uint Id = 18293; // Post ID
    public User user { get; set; } = new User();
}
