using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using project_GVEncheva22.Models;
using project_GVEncheva22.Services;

namespace project_GVEncheva22.Controllers;

[Authorize]
public class TaskController : Controller
{
    private readonly ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    public async Task<IActionResult> Index()
    {
        var tasks = await _taskService.GetAllTasksAsync();
        return View(tasks);
    }

    public async Task<IActionResult> Details(int id)
    {
        var task = await _taskService.GetTaskByIdAsync(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = "AdminOnly")]
    public async Task<IActionResult> Create(TaskItem task)
    {
        if (ModelState.IsValid)
        {
            await _taskService.CreateTaskAsync(task);
            return RedirectToAction("Index");
        }
        return View(task);
    }

    public async Task<IActionResult> Edit(int id)
    {
        var task = await _taskService.GetTaskByIdAsync(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = "AdminOnly")]
    public async Task<IActionResult> Edit(int id, TaskItem task)
    {
        if (id != task.Id)
        {
            return BadRequest();
        }
        if (ModelState.IsValid)
        {
            await _taskService.UpdateTaskAsync(task);
            return RedirectToAction("Index");
        }
        return View(task);
    }

    public async Task<IActionResult> Delete(int id)
    {
        var task = await _taskService.GetTaskByIdAsync(id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(Policy = "AdminOnly")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _taskService.DeleteTaskAsync(id);
        return RedirectToAction("Index");
    }
}