using Microsoft.AspNetCore.Mvc;
using SharpCache.Interfaces;
using SharpCache.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SharpCache.Controllers
{
	[Route("sharpecache")]
	[ApiController]
	public class CommandController : ControllerBase
	{
		private readonly ICommandService _commandService;
		public CommandController(ICommandService commandService)
		{
			_commandService = commandService;
		}
		[HttpGet("/get")]
		public ActionResult Get()
		{
			return Ok("Value");
		}

		[HttpPost("/command")]
		public IActionResult Set(string command)
		{
			var result = _commandService.ProcessCommand(command);
			if(result.Success)
				return Ok(result.Message);
			return BadRequest(result.Message);
				
		}

		
	}
}
