using JABO.Data.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JABO.Data.Repository
{
	public static class TodoMessagesRepository
	{
		public const string FilePath = "todo.json";

		public static IEnumerable<TodoMessageModel> Load()
		{
			try
			{
				var json = File.ReadAllText(FilePath);

				return JsonConvert.DeserializeObject<
					List<TodoMessageModel>>(json);
			}
			catch
			{
				return new List<TodoMessageModel>();
			}
		}

		public static void Save(IEnumerable<TodoMessageModel> messages)
		{
			var json = JsonConvert.SerializeObject(
				messages.ToList(), Formatting.Indented);

			File.WriteAllText(FilePath, json);
		}
	}
}
