namespace Infrastructure.Services;
using Domain.Model;
public class TaskServices
{
    List<Task> tasks = new List<Task>();
    public List<Task> GetAllTasks()
    {
        return tasks;
    }
    public void AddTask(Task task)
    {
        tasks.Add(task);
    }
    public Task GetTaskById(int id)
    {
        var task = tasks.FirstOrDefault(p => p.TaskId == id);
        return task;
    }
    public void UpdateTask(Task task)
    {
        var update = tasks.FirstOrDefault(p => p.TaskId == task.TaskId);
        if (update == null)
        {
            return;
        }
        update.Title = task.Title;
        update.Description = update.Description;
    }
    public void DeleteTask(int id) 
    {
        var delete = tasks.FirstOrDefault(e => e.TaskId == id); 
        tasks.Remove(delete); 
        Console.WriteLine("Deleted was successfully"); 
    }
    public void GetInfoAboutTasks() 
    { 
        Console.WriteLine($"Info About List {tasks}"); 
    }
    public List<Task> GetCompletedTasks(bool complete) 
    {
        return tasks.Where(e => e.Done == complete).ToList(); 
    }
    public List<Task> GetNotCompletedTasks(bool notcomplete)
    {
        return tasks.Where(e => e.Done == notcomplete).ToList(); 
    }
}
