using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Todo_Api.Data;
using Todo_Api.Dto;
using Todo_Api.Mappers;

namespace Todo_Api.Controllers
{
	[Route("api/todo")]
	public class TodoController: ControllerBase
	{
		private readonly ApplicationDBContext _context;


		public TodoController(ApplicationDBContext context)
		{
			_context = context;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			var todos = await _context.Todo.ToListAsync();

			return Ok(todos);
		}

		[HttpGet]
		[Route("{id:Guid}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
		{
			var todo = await _context.Todo.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            return Ok(todo);

        }


        [HttpPost]
		public async Task<IActionResult> Create([FromBody] CreateTodoDto todoDto)
		{
			var todoModel = todoDto.ToCreateTodoDto();
			await _context.Todo.AddAsync(todoModel);
			await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = todoModel.Id }, todoModel);
		}

        [HttpPut]
        [Route("{id:Guid}")]
        public async Task<IActionResult> UpdateById([FromRoute] Guid id, [FromBody] UpdateTodoDto todoModel)
        {
			var todo = await _context.Todo.FirstOrDefaultAsync(x => x.Id == id);

            if (todo == null)
            {
                return NotFound();
            }

			todo.Title = todoModel.Title;
			todo.Description = todoModel.Description;
			todo.IsCompleted = todoModel.IsCompleted;

			await _context.SaveChangesAsync();

			return Ok(todo);
        }


        [HttpDelete]
        [Route("{id:Guid}")]
        public async Task<IActionResult> DeleteById([FromRoute] Guid id)
        {
            var todo = await _context.Todo.FirstOrDefaultAsync(x => x.Id == id);

            if (todo == null)
            {
                return NotFound();
            }


            _context.Remove(todo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

    }
}

