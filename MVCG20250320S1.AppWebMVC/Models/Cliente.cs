using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCG20250320S1.AppWebMVC.Models;

public partial class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    public string Nombre { get; set; } = null!;
  
    [Display(Name = "Dirección")]
    public string? Direccion { get; set; }

  
    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    public string? Email { get; set; }
}
