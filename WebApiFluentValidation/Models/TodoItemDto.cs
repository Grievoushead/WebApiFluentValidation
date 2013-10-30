using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using WebApiFluentValidation.Validators;

namespace WebApiFluentValidation.Models
{
    public class TodoItemDto : ValidateDto<TodoItemDto>
    {
        /// <summary>
        /// Data transfer object for <see cref="TodoItem"/>
        /// </summary>
        public TodoItemDto()
        {
            // Todo: Remove when register in ioc.
            this.validator = new TodoItemValidator();
        }

        public TodoItemDto(TodoItem item)
        {
            TodoItemId = item.TodoItemId;
            Title = item.Title;
            IsDone = item.IsDone;
            TodoListId = item.TodoListId;
        }

        [Key]
        public int TodoItemId { get; set; }

        public string Title { get; set; }

        public bool IsDone { get; set; }

        public int TodoListId { get; set; }

        public TodoItem ToEntity()
        {
            return new TodoItem
            {
                TodoItemId = TodoItemId,
                Title = Title,
                IsDone = IsDone,
                TodoListId = TodoListId
            };
        }
    }
}
