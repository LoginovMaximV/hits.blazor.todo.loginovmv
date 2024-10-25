using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MemoryDataService : IDataService
    {
        private readonly static IEnumerable<TaskItem> tasks =
        [
            new TaskItem { Id = 1, Title = "Задача 1", Description = "Описание 1", CreatedDate = DateTime.Now},
            new TaskItem { Id = 2, Title = "Задача 2", Description = "Описание 2", CreatedDate = DateTime.Now},
            new TaskItem { Id = 3, Title = "Задача 3", Description = "Описание 3", CreatedDate = DateTime.Now},
        ];

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> GetTaskAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            await Task.Delay(1000);
            return await Task.FromResult(tasks);
        }

        public Task SaveAsync(TaskItem item)
        {
            throw new NotImplementedException();
        }
    }
}
