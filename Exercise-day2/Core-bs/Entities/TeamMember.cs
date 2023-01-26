using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_bs.Entities;

public class TeamMember
{
    public int Id { get; set; }
    [Required]
    public string? Image { get; set; }
    [Required,MaxLength(100)]
    public string? Name { get; set; }
    [Required,MaxLength(100)]
    public string? Position { get; set; }
    public string? Facebook { get; set; }
    public string? Twitter { get; set; }
    public string? Instagram { get; set; }

}
