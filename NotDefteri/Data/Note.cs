using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri.Data
{
    public class Note
    {
        public int Id { get; set; }
        [Required,MaxLength(200)]
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;

    }
}
