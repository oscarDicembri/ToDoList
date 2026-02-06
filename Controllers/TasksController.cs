using Microsoft.AspNetCore.Mvc;
using ToDoList.Api.DTOs;
using ToDoList.Api.Models;
using ToDoList.Api.Services;

namespace ToDoList.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly ITaskService _taskService;

    public TasksController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet]
    public IEnumerable<TaskItem> GetAll() => _taskService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<TaskItem> GetById(int id)
    {
        var task = _taskService.GetById(id);
        if (task == null) return NotFound();
        return task;
    }

    [HttpPost]
    public ActionResult<TaskItem> Create(CreateTaskDto dto)
    {
        var task = _taskService.Create(dto.Title, dto.Description);
        return CreatedAtAction(nameof(GetById), new { id = task.Id }, task);
    }

    [HttpPatch("{id}/toggle")]
    public IActionResult ToggleComplete(int id)
    {
        if (!_taskService.ToggleComplete(id)) return NotFound();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        if (!_taskService.Delete(id)) return NotFound();
        return NoContent();
    }
}
