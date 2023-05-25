﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models;

public class Archers
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ArcherId { get; set; }

    [Required]
    [StringLength(50)]
    public string GivenName { get; set; }
    [Required]
    [StringLength(50)]
    public string FamilyName { get; set; }
    [Required]
    public int BirthYear { get; set; }
    [Required]
    public char Gender { get; set; }
}
