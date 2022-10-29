using System.Collections.Generic;

namespace InterviewTestPagination.Models.Todo {
    public interface ITodoService : IModelService<Todo> {
        IEnumerable<Todo> All();
    }
}
