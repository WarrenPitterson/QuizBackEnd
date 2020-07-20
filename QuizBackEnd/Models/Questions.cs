using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizBackEnd.Models
{
    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        public string Question { get; set; }
        
        public string CorrectAnswer { get; set; }

        public string IncorrectAnswer1 { get; set; }

        public string IncorrectAnswer2 { get; set; }

        public string IncorrectAnswer3 { get; set; }
    }
}
