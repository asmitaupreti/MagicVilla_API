﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Dto
{
	public class VillaDTO
	{
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
