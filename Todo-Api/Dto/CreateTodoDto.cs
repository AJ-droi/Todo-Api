using System;
namespace Todo_Api.Dto
{
    public class CreateTodoDto
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; } = false;
    }
}

