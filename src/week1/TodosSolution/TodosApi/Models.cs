namespace TodosApi;
public record TodoCreateRequest
{
    public string Description { get; set; } = string.Empty;
}

public record TodoCreateResponse
{
    public Guid Id { get; set; }
    public string Description { get; set; } = string.Empty;

    public TodoStatus Status { get; set; } = TodoStatus.Incomplete;
}

public enum TodoStatus { Incomplete, Completed }

