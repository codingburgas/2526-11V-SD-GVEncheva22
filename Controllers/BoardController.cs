using Microsoft.AspNetCore.Mvc;
using project_GVEncheva22.Models;
using project_GVEncheva22.Services;

namespace project_GVEncheva22.Controllers;

public class BoardController : Controller
{
    private readonly IBoardService _boardService;

    public BoardController(IBoardService boardService)
    {
        _boardService = boardService;
    }

    public async Task<IActionResult> Index()
    {
        var boards = await _boardService.GetAllBoardsAsync();
        return View(boards);
    }

    public async Task<IActionResult> Details(int id)
    {
        var board = await _boardService.GetBoardByIdAsync(id);
        if (board == null)
        {
            return NotFound();
        }
        return View(board);
    }
}