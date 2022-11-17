
namespace Teachy.DataAccess.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NickName { get; set; }
    public bool Active { get; set; }
    public DateTime DateCreated { get; set; }
}
