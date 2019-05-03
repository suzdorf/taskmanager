﻿using System.Linq;
using System.Threading.Tasks;

namespace TaskManager.Core.DataProviders
{
    public interface ITaskDataProvider
    {
        Task AddAsync(int userId, ITaskInfo task);
        IQueryable<ITask> GetLiveTasks(int userId, int? projectId);
        Task UpdateStatusAsync(int taskId, TaskStatus status);
    }
}