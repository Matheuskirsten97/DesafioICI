using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvaCandidato.Data.Entidade
{
  [Table("Cliente")]
  public class Cliente
  {
    [Key]
    [Column("codigo")]
    public int Codigo { get; set; }


    [Required(ErrorMessage = "Favor informar um nome")]
    [StringLength(50, ErrorMessage = "Nome muito grande")]
    [MinLength(3, ErrorMessage = "Nome muito curto")]
    [Column("nome")]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "Favor a data de nascimento")]
    [Column("data_nascimento")]
    [Display(Name = "Data de nascimento")]
    public DateTime? DataNascimento { get; set; }

    
    [Column("codigo_cidade")]
    [Display(Name = "Cidade")]
    public int CidadeId { get; set; }

    public bool Ativo { get; set; }

    [ForeignKey("CidadeId")]
    public virtual Cidade Cidade { get; set; }

  }
}