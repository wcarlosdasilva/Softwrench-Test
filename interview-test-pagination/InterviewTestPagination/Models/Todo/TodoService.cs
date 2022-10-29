using InterviewTestPagination.Search.Todo;
using System.Collections.Generic;
using System.Linq;

namespace InterviewTestPagination.Models.Todo {
    /// <summary>
    /// Todo Service Service layer extending from ITodoService interface that implements the base IModelService. 
    /// </summary>
    public class TodoService : ITodoService {
        private readonly ITodoRepository _todoRepository;

        public TodoService(ITodoRepository todoRepository) {
            _todoRepository = todoRepository;
        }

        public IEnumerable<Todo> All()
        {
            return _todoRepository.All();
        }
        public IEnumerable<Todo> List()
        {
            // invoke Datasource layer
            return _todoRepository.All();
        }
    }
}
