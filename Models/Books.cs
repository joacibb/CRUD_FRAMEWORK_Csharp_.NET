//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRUD_FRAMEWORK.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Books
    {
        [System.ComponentModel.DataAnnotations.Display(Name = "#")]
        public int id { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Nombre del libro")]
        public string nameBook { get; set; }
        [System.ComponentModel.DataAnnotations.Display(Name = "Autor")]
        public string author { get; set; }

        [System.ComponentModel.DataAnnotations.Display(Name = "Fecha de lanzamiento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> date { get; set; }
    }
}