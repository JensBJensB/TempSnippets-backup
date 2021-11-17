using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.GuessTheNumber.Models
{
    public class GuessNumberModel
    {
        public int CorrectNumber { get; set; }

        //=========================================
        //             GÅ IGENOM IGEN
        // Detta täcker antagligen inte "10a" t.ex.
        //=========================================

        [Required]
        [Range(1, 101, ErrorMessage = "Guess a number between 1-100")]
        public int GussedNumber { get; set; }

        public bool ShowResult { get; set; }
        public bool Success { get; set; }

        public void GenerateRandomNumber()
        {
            Random random = new Random();
            this.CorrectNumber = random.Next(1, 101);
        }
    }
}

