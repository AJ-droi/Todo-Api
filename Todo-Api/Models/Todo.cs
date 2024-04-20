using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Todo_Api.Models
{
	public class Todo
	{
        [Column("id")]
        public Guid Id { get; set; }
        [Column("title")]
        public string Title { get; set; } = string.Empty;
        [Column("description")]
        public string Description { get; set; } = string.Empty;
        [Column("isCompleted")]
        public bool IsCompleted { get; set; } = false;

    }
}

