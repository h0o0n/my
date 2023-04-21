// See https://aka.ms/new-console-template for more information
using TodoApp.Models;

ITodoRepositoryInMemory _repository = new TodoRepositoryInMemory();
List<Todo> todos = new List<Todo>();
//todos = _repository.getAll();

//[2] 데이터 입력
Todo todo = new() { Title = "Database", IsDone = true };

_repository.Add(todo);
todos = _repository.getAll();

//[3] 데이터 출력
foreach (Todo t in todos)
{
    Console.WriteLine(  $"{t.Id} - {t.Title}({t.IsDone})" );
}

