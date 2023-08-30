using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyAPI.Models;

namespace MyAPI.Services.IServices
{
    public interface IIstructorService
    {
        //adding an instructor
       Task<string> AddInstructorAsync(Instructor instructor);
       //updating
       Task<string> UpdateInstructorAsync(Instructor instructor);
       //deleting
       Task<string> DeleteInstructorAsync(Instructor instructor);
       //getting all instructors
       Task<List<Instructor>> GetAllInstructorsAsync();
       //getting one instructor
       Task<Instructor> GetOneInstructorAsync(Guid id);
    }
}