namespace dotnet_webapi_test.Models;

public class SessionItem
{
    public long Id { get; set; }
    public required string Title { get; set; }
    public DateTime StartTime { get; set; }
    public MemberItem[] Speakers { get; set; } = null!;
}