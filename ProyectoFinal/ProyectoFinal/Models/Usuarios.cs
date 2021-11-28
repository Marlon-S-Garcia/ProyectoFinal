using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace ProyectoFinal.Models
{
    public class Usuarios
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(70)]
        public string Correo { get; set; }

        [MaxLength(10)]
        public String Telefono { get; set; }

        [MaxLength(80)]
        public String Direccion { get; set; }


        [MaxLength(30)]
        public string Usuario { get; set; }

        [MaxLength(30)]
        public string Contrasenia { get; set; }


    }
}
