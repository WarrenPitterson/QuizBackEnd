using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizBackEnd.Models
{
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        public string Name { get; set; }
        public  List<Questions> Questions { get; set; }
    }
}
