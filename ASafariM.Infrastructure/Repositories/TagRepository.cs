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
    public class TagRepository : ITagRepository
    {
        private readonly AppDbContext _context;

        public TagRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Tag>> GetAllAsync()
        {
            return await _context
                .Tags.Include(t => t.PostTags)
                .Where(t => !t.IsDeleted)
                .ToListAsync();
        }

        public async Task<Tag> GetByIdAsync(Guid id)
        {
            return await _context
                .Tags.Include(t => t.PostTags)
                .FirstOrDefaultAsync(t => t.Id == id && !t.IsDeleted);
        }

        public async Task<Tag> GetBySlugAsync(string slug)
        {
            return await _context
                .Tags.Include(t => t.PostTags)
                .FirstOrDefaultAsync(t => t.Slug == slug && !t.IsDeleted);
        }

        public async Task<IEnumerable<Tag>> GetTagsByPostIdAsync(Guid postId)
        {
            return await _context
                .PostTags.Where(pt => pt.PostId == postId)
                .Select(pt => pt.Tag)
                .Where(t => !t.IsDeleted)
                .ToListAsync();
        }

        public async Task<Tag> AddAsync(Tag tag)
        {
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();
            return tag;
        }

        public async Task<Tag> UpdateAsync(Tag tag)
        {
            _context.Tags.Update(tag);
            await _context.SaveChangesAsync();
            return tag;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag == null)
                return false;

            tag.IsDeleted = true;
            tag.DeletedAt = DateTime.UtcNow;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(Guid id)
        {
            return await _context.Tags.AnyAsync(t => t.Id == id && !t.IsDeleted);
        }

        public async Task<bool> SlugExistsAsync(string slug)
        {
            return await _context.Tags.AnyAsync(t => t.Slug == slug && !t.IsDeleted);
        }
    }
}
