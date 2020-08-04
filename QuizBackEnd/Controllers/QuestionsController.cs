﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizBackEnd.Data;
using QuizBackEnd.Models;

namespace QuizBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public QuestionsController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Questions
        [HttpGet("quiz/{id}")]
        public async Task<ActionResult<IEnumerable<Questions>>> GetAllQuizQuestionsById(int id)
        {
            return await _context.Questions.Where(f => f.QuizId == id).ToListAsync();
        }

        // GET: api/Questions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Questions>> GetQuestions(int id)
        {
            var questions = _context.Questions.FirstOrDefaultAsync(f => f.QuizId == id);

            if (questions == null)
            {
                return NotFound();
            }

            return await questions;
        }

        // PUT: api/Questions/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutQuestions(int id, Questions questions)
        {
            if (id != questions.QuestionId)
            {
                return BadRequest();
            }

            _context.Entry(questions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QuestionsExists(id))
                {
                    return NotFound();
                }
             
            }

            return NoContent();
        }




        private bool QuestionsExists(int id)
        {
            return _context.Questions.Any(e => e.QuestionId == id);
        }





    }
}
