using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TodoItemsController : ControllerBase
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
