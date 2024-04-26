using System;
namespace Todo_Api.Dto
{
    public class UpdateTodoDto
	{
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;
    }
}

