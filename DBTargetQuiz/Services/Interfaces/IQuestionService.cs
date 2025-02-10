﻿using DBTargetQuiz.Models;

namespace DBTargetQuiz.Services.Interfaces
{
    public interface IQuestionService
    {
        Task<IEnumerable<Question>> GetAllAsync();
        Task<Question?> GetByIdAsync(int id);
        Task AddAsync(Question entity);
        Task UpdateAsync(Question entity);
        Task DeleteAsync(int id);
        Task<IEnumerable<Question>> GetAllWithAnswersAsync();
    }
}
