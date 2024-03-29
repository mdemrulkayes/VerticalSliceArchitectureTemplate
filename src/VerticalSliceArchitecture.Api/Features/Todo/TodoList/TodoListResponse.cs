﻿namespace VerticalSliceArchitecture.Api.Features.Todo.TodoList;

public class TodoListResponse
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
}
