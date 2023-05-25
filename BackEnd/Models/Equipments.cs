﻿using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models;

public class Equipments
{
    [Key]
    [StringLength(50)]
    public string EquipmentName { get; set; }
}
