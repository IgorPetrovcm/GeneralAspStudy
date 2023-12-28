using System.ComponentModel.DataAnnotations;

namespace ValidationArray.Models;

public class Values
{
    [Required]
    public string[] val;
}