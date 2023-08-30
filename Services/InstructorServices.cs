using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAPI.ApiConnections;
using MyAPI.Models;
using MyAPI.Services.IServices;

namespace MyAPI.Services
{
    public class InstructorService : IIstructorService
    {
        private readonly ApiDbConnection _context;

        public InstructorService(ApiDbConnection context)
        {
            _context = context;
            
        }
        public async Task<string> AddInstructorAsync(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            await _context.SaveChangesAsync();
            return "instructor added successfully";
        }

        public async Task<string> DeleteInstructorAsync(Instructor instructor)
        {
            _context.Instructors.Remove(instructor);
            await _context.SaveChangesAsync();
            return "Instructor removed successfully";
        }

        public async Task<List<Instructor>> GetAllInstructorsAsync()
        {
            return await _context.Instructors.ToListAsync();
    
        }

        public async Task<Instructor> GetOneInstructorAsync(Guid id)
        {
            return await _context.Instructors.Where(x => x.InstructorID == id).FirstOrDefaultAsync();
        }

        public async Task<string> UpdateInstructorAsync(Instructor instructor)
        {
            _context.Instructors.Update(instructor);
            await _context.SaveChangesAsync();
            return "instructor updated successfully";
        }

    }
}