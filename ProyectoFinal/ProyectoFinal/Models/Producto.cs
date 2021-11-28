using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyectoFinal.Models
{
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int IdCodigo { get; set; }

        [MaxLength(50)]
        public string nombreProducto { get; set; }

        [MaxLength(5)]
        public float Valor { get; set; }
    }
}
