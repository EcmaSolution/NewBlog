using System.ComponentModel.DataAnnotations.Schema;

namespace NewBlog.Entities;

public class Post
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public string? Description { get; set; }

    #region Relation

    public int AuthorId { get; set; }

    [ForeignKey("AuthorId")]
    public User? Author { get; set; }

    #endregion
}
