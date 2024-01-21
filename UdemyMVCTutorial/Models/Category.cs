using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UdemyMVCTutorial.Models;

public class Category
{
    [Key] public int Id { get; set; }

    [DisplayName("Category Name")]
    [MaxLength(50)]
    [Required]
    public string Name { get; set; }

    [Range(1, 100)]
    [DisplayName("Display Order")]
    public int DisplayOrder { get; set; }
}