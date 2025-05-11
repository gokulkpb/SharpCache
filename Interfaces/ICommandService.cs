using SharpCache.Models;

namespace SharpCache.Interfaces
{
	public interface ICommandService
	{
		public CommandResult ProcessCommand(string command);
	}
}
