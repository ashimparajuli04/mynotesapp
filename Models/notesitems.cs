using System;
using System.ComponentModel.DataAnnotations;
namespace notes.Models
{
public class Note
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(100)]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
    }
}