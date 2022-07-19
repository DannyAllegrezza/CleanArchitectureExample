using Ardalis.Result;
using CleanArchitectureExample.Core.ProjectAggregate;

namespace CleanArchitectureExample.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(int projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(int projectId, string searchString);
}
