using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpinutechCodeTest.Models
{
    public class Palindrome
    {
        [Required]
        public decimal input { get; set; }
        [Required]
        public bool isPalindrome { get; set; }
    }
}
