namespace NewBlog.Entities;

public class User
{
    public int Id { get; set; }

    public required string Email { get; set; }

    #region Relation

    public ICollection<Post>? Posts { get; set; }

    #endregion
}
