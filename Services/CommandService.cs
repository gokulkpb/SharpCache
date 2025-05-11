using SharpCache.Interfaces;
using SharpCache.Models;

namespace SharpCache.Services
{
	public class CommandService:ICommandService
	{
		public CommandService() { }
		public CommandResult ProcessCommand(string command)
		{
			if (string.IsNullOrEmpty(command))
				return new CommandResult
				{
					Success = false,
					Message = "Empty Command"
				};
			if(command == "sample")
				return new CommandResult
				{
					Success = false,
					Message = "Invalid input"
				};
			return new CommandResult
			{
				Success = true,
				Message = "Data Added"
			};
		}
	}
}
