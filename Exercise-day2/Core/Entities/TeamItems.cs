using Core.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class TeamItems:IEntity
    {
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string? Name { get; set; }
       
        [Required]
        public string? Image { get; set; }
       
        [Required, MaxLength(100)]
        public string? Position { get; set; }

        [Required, MaxLength(400)]
        public string? Desc { get; set; }


        public string? Facebook { get; set; }
        public string? Twitter { get; set; }
        public string? Instagram { get; set; }
        public string? Linkedin { get; set; }


        
    }
}
