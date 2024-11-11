using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.EntityFrameworkCore;
using api.Dtos.Comment;
using api.Interfaces;
using api.Models;

namespace api.Repository
{
    public class CommentRepository:ICommentRepository
    {
        private readonly ApplicationDBContext _context;
        public CommentRepository(ApplicationDBContext context)
        {
            _context=context;
        }

        public Task<Comment> CreateAsync(Comment commentModel)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public Task<Comment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> UpdateAsync(int id, UpdateCommentRequestDto commentModel)
        {
            throw new NotImplementedException();
        }
    }
}