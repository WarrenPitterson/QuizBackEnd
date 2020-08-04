using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBackEnd.Models
{
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        public Questions[] QuestionsArray { get; set; }
    }
}
