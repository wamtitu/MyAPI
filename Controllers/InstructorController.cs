using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;
using MyAPI.Requests;
using MyAPI.Responses;
using MyAPI.Services.IServices;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController :ControllerBase
    {
        private readonly IIstructorService _istructorService;
        private readonly IMapper _imapper;

        public InstructorController(IMapper imapper, IIstructorService istructorService){
            _istructorService = istructorService;
            _imapper = imapper;
        }

        [HttpPost]
        public async Task<ActionResult<MessageSucces>> AddInstructor(AddInstructor newInstructor){
            var instructor = _imapper.Map<Instructor>(newInstructor);
            var res = await _istructorService.AddInstructorAsync(instructor);
            return CreatedAtAction(nameof(AddInstructor), new MessageSucces(201, res));
        }

        [HttpGet]
        public async Task<ActionResult<MessageSucces>> GetInstructors(){
            var instructors = await _istructorService.GetAllInstructorsAsync();
            return Ok(instructors);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Instructor>> GetInstructor(Guid id){
            var instructor = await _istructorService.GetOneInstructorAsync(id);
            if(instructor == null){
                return NotFound(new MessageSucces(404, "Instructor not found"));
            }
            return Ok(instructor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MessageSucces>> UpdateInstructor(Guid id, AddInstructor updatedInstructor){
            var response = await _istructorService.GetOneInstructorAsync(id);
            if(response == null){
                return NotFound(new MessageSucces(404, "instructor not found"));
            }
            var updated = _imapper.Map(updatedInstructor, response);
            var res = await _istructorService.UpdateInstructorAsync(updated);
            return Ok(new MessageSucces(201, res));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MessageSucces>> DeleteUser(Guid id){
            var response = await _istructorService.GetOneInstructorAsync(id);
            if(response == null){
                return NotFound(new MessageSucces(404, "Instructor not found"));
            }
            var res = await _istructorService.DeleteInstructorAsync(response);
            return Ok(new MessageSucces(200, res));
        }
    }
}