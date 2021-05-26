using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace PC3.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage="¡Ingrese un producto!")]
        [Display(Name="Nombre del producto")]
        public string Nombre { get; set; }

        [Required(ErrorMessage="¡Ingrese un URl correcta!")]
        [Display(Name="URL foto")]
        public string FotoUrl { get; set; }

        [Required(ErrorMessage="¡Ingrese un Descripción!")]
        [Display(Name="Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage="¡Ingrese Precio!")]
        [Display(Name="Precio")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage="¡Ingrese Telefono!")]
        [Display(Name="Telefono")]
        public int Telefono { get; set; }

        [Required(ErrorMessage="¡Ingrese un Lugar de Compra!")]
        [Display(Name="Lugar de Compra")]
        public string LugarCompra { get; set;}

        [Required(ErrorMessage="¡Ingrese Nombre de Comprador!")]
        [Display(Name="Nombre de Comprador")]
        public string NombreComprador { get; set; }
      
       [Required]
        public DateTime addDate { get; set; }
        public ICollection<Categoria> Categorias {get; set;}
    }
}