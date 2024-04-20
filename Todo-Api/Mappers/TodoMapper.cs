using System;
using Todo_Api.Dto;
using Todo_Api.Models;

namespace Todo_Api.Mappers
{
	public static class TodoMapper
	{
		public static Todo ToCreateTodoDto(this CreateTodoDto todoModel)
		{
			return new Todo
			{
				Title = todoModel.Title,
				Description = todoModel.Description,
				IsCompleted = todoModel.IsCompleted,
			};
		}
	}
}

