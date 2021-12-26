namespace Blog.Domain;

public class Post
{
    public string? Content { get; set; }

    public ICollection<Tag>? Tags { get; set; }
    
    
}