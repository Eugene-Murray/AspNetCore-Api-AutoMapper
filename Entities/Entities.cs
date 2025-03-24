public class SourceClass
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

public class DestinationClass
{
    public int Id { get; set; }
    public string? FullName { get; set; }
}
