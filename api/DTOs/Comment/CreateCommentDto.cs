using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.DTOs.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5,ErrorMessage ="Title must be at least 5 characters long")]
        [MaxLength(280, ErrorMessage ="title cannot be over 280 characters")]
        public string Title {get; set;} = string.Empty;
         [Required]
        [MinLength(5,ErrorMessage ="Content must be at least 5 characters long")]
        [MaxLength(280, ErrorMessage ="Content cannot be over 280 characters")]
        public String Content { get; set; } =string.Empty;
    }
}