namespace Accounting.Domain
{

    public interface IUser
    {
        string Id { get; }
        string? UserName { get; }
        string? Email { get; }

        string FirstName { get; set; }
        string LastName { get; set; }

        string FullName { get; }

        bool EmailConfirmed { get; set; }



    }
}