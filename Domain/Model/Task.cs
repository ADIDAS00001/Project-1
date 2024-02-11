namespace Domain.Model;

public class Task
{
    public int TaskId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public User? Assignee { get; set; }
    public bool Done { get; set; }
    public DateTime CreatedAt { get; set; }
    public Task(int taskid,string title,string description,User assignee,DateTime createdat)
    {
        TaskId=taskid;
        Title=title;
        Description=description;
        Assignee=assignee;
        CreatedAt=createdat;
    }
}
