﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace ProvaCandidato.Data.Entidade
{
  [Table("Cidade")]
  public class Cidade
  {
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }

    [Column("nome")]
    [StringLength(50, ErrorMessage = "Cidade muito grande")]
    [MinLength(3, ErrorMessage = "Cidade muito curto")]
    [Display(Name = "Nome")]
    [Required]
    public string Nome { get; set; }
  }
}
