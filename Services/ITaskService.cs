using ToDoList.Api.Models;

namespace ToDoList.Api.Services;

public interface ITaskService
{
    IEnumerable<TaskItem> GetAll();
    TaskItem? GetById(int id);
    TaskItem Create(string title, string description);
    bool ToggleComplete(int id);
    bool Delete(int id);
}
