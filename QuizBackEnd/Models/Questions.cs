using System.ComponentModel.DataAnnotations;

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
        public int QuizId { get; set; }
    }
}
