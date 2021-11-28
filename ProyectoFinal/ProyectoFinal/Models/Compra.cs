using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyectoFinal.Models
{
    public class Compra
    {
        [PrimaryKey, AutoIncrement]
        public int IdCompra { get; set; }

        [MaxLength(50)]
        public string NombreProducto { get; set; }

        [MaxLength(3)]
        public int Cantidad { get; set; }

        [MaxLength(5)]
        public int Valor { get; set; }

        [MaxLength(5)]
        public int ValorPago { get; set; }


    }
}
