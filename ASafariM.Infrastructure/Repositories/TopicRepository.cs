using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASafariM.Domain.Entities;
using ASafariM.Domain.Interfaces;
using ASafariM.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ASafariM.Infrastructure.Repositories
{
    public class TopicRepository : ITopicRepository
    {
        private readonly AppDbContext _context;

        public TopicRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Topic>> GetAllAsync()
        {
            return await _context
                .Topics.Include(t => t.ParentTopic)
                .Include(t => t.ChildTopics)
                .Include(t => t.Posts)
                .Where(t => !t.IsDeleted)
                .ToListAsync();
        }

        public async Task<Topic> GetByIdAsync(Guid id)
        {
            return await _context
                .Topics.Include(t => t.ParentTopic)
                .Include(t => t.ChildTopics)
                .Include(t => t.Posts)
                .FirstOrDefaultAsync(t => t.Id == id && !t.IsDeleted);
        }

        public async Task<Topic> GetBySlugAsync(string slug)
        {
            return await _context
                .Topics.Include(t => t.ParentTopic)
                .Include(t => t.ChildTopics)
                .Include(t => t.Posts)
                .FirstOrDefaultAsync(t => t.Slug == slug && !t.IsDeleted);
        }

        public async Task<IEnumerable<Topic>> GetChildTopicsAsync(Guid parentId)
        {
            return await _context
                .Topics.Include(t => t.Posts)
                .Where(t => t.ParentTopicId == parentId && !t.IsDeleted)
                .ToListAsync();
        }

        public async Task<Topic> AddAsync(Topic topic)
        {
            await _context.Topics.AddAsync(topic);
            await _context.SaveChangesAsync();
            return topic;
        }

        public async Task<Topic> UpdateAsync(Topic topic)
        {
            _context.Topics.Update(topic);
            await _context.SaveChangesAsync();
            return topic;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            if (await ExistsAsync(id) == false)
                return false;
            var topic = await _context.Topics.FindAsync(id);
            if (topic == null)
                return false;

            topic.IsDeleted = true;
            topic.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Topics.AnyAsync(t => t.Id == id && !t.IsDeleted);
        }

        public async Task<bool> SlugExistsAsync(string slug)
        {
            return await _context.Topics.AnyAsync(t => t.Slug == slug && !t.IsDeleted);
        }
    }
}
