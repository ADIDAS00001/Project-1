namespace Domain.Model;

public class TaskManager
{
    List<Task> tasks=new List<Task>();
    List<User> users=new List<User>();
    List<Category> cotegories=new List<Category>();
    public TaskManager(List<Task> task,List<User> user,List<Category> category)
    {
        tasks=task;
        users=user;
        cotegories=category;
    }
}
